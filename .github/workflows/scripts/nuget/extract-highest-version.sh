#!/bin/bash

# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

FILENAME="dotnet-versions.txt"
JSON_KEY="dotnet_version" # Key in the JSON containing the version array

# --- Prerequisite Check: jq ---
if ! command -v jq &> /dev/null; then
    echo "Error: 'jq' command not found. Please install jq to parse the JSON file."
    exit 1
fi
echo "Info: 'jq' command found."

# --- File Existence Check ---
if [ ! -f "$FILENAME" ]; then
  # Try checking with GITHUB_WORKSPACE prefix if the simple name doesn't exist
  if [ -n "$GITHUB_WORKSPACE" ] && [ -f "${GITHUB_WORKSPACE}/${FILENAME}" ]; then
      FILENAME="${GITHUB_WORKSPACE}/${FILENAME}"
      echo "Info: Found versions file at ${FILENAME}"
  else
      echo "Error: The versions file ${FILENAME} (or ${GITHUB_WORKSPACE}/${FILENAME} if defined) does not exist."
      exit 1
  fi
fi
echo "Info: Processing versions from ${FILENAME}"

# --- JSON Validation and Data Extraction ---

# 1. Validate if the file is valid JSON
if ! jq empty "$FILENAME" > /dev/null 2>&1; then
    echo "Error: ${FILENAME} is not a valid JSON file."
    exit 1
fi
echo "Info: ${FILENAME} is valid JSON."

# 2. Validate if the specific key exists and is an array
if ! jq -e --arg key "$JSON_KEY" 'has($key) and (.[$key] | type == "array")' "$FILENAME" > /dev/null; then
    echo "Error: JSON file ${FILENAME} does not contain the key \"${JSON_KEY}\" or its value is not an array."
    exit 1
fi
echo "Info: JSON key \"${JSON_KEY}\" exists and is an array."

# --- Find Highest Valid Version (netX.Y or netX.Y.Z) ---

# Regex to match .NET versions like netX.Y or netX.Y.Z
# Anchored (^$) to ensure the whole string matches
# Allows for single or multi-digit major/minor/patch versions
version_regex='^net[0-9]+\.[0-9]+(\.[0-9]+)?$'

# 1. Use jq to extract the raw strings from the array under the specified key.
# 2. Filter the extracted lines for those matching the version format using grep.
# 3. Sort the valid versions using version sort (-V) in reverse order (-r).
# 4. Take the first line (which is the highest version) using head.
#
# Handles potential grep failure explicitly after the pipeline.

extracted_versions=$(jq -r --arg key "$JSON_KEY" '.[$key][]' "$FILENAME")
if [ -z "$extracted_versions" ]; then
    echo "Info: The array under key \"${JSON_KEY}\" in ${FILENAME} is empty. No versions to process."
    # Setting HIGHEST_NET_VERSION to empty will trigger the error check below
    HIGHEST_NET_VERSION=""
else
    # Filter, sort, and get the highest net version (netX.Y or netX.Y.Z)
    # Use || true for grep/sort/head to prevent script exit if no match, handle empty result explicitly
    HIGHEST_NET_VERSION=$(echo "$extracted_versions" | grep -E "$version_regex" | sort -Vr | head -n 1 || true)
fi


# Explicit check for whether a valid version was found after filtering/sorting
if [ -z "$HIGHEST_NET_VERSION" ]; then
  echo "Error: No valid versions matching the format '${version_regex}' found under key \"${JSON_KEY}\" in ${FILENAME}."
  exit 1
fi

echo "Info: Highest raw version found: ${HIGHEST_NET_VERSION}"

# --- Convert Highest Version to X.Y.Z Format ---
# Strip the leading 'net'
VERSION_NUMERIC_PART=$(echo "$HIGHEST_NET_VERSION" | sed 's/^net//') # e.g., "9.0" or "8.0.100"

# Check if it already has a patch version (two dots)
if [[ "$VERSION_NUMERIC_PART" == *.*.* ]]; then
    # Already X.Y.Z format
    HIGHEST_XYZ_VERSION="$VERSION_NUMERIC_PART"
elif [[ "$VERSION_NUMERIC_PART" == *.* ]]; then
    # It's X.Y format, append .0
    HIGHEST_XYZ_VERSION="${VERSION_NUMERIC_PART}.0"
else
    # This case should be unlikely if the regex worked, but provides safety
    echo "Error: Could not parse version part '$VERSION_NUMERIC_PART' from '$HIGHEST_NET_VERSION' into X.Y or X.Y.Z format after stripping 'net'."
    exit 1
fi

echo "Highest valid .NET version (formatted as X.Y.Z): $HIGHEST_XYZ_VERSION"

# --- Export Variable ---
# Check if GITHUB_ENV is set and is a file (standard in GitHub Actions)
if [ -z "$GITHUB_ENV" ] || [ ! -f "$GITHUB_ENV" ]; then
    echo "Warning: GITHUB_ENV environment variable is not set or not a file. Skipping export."
    echo "Would have exported: DOTNET_VERSION=${HIGHEST_XYZ_VERSION}"
else
    echo "Info: Exporting DOTNET_VERSION=${HIGHEST_XYZ_VERSION} to ${GITHUB_ENV}"
    # Append the variable in the format required by GitHub Actions
    echo "DOTNET_VERSION=${HIGHEST_XYZ_VERSION}" >> "${GITHUB_ENV}"
    echo "Exported: DOTNET_VERSION=${HIGHEST_XYZ_VERSION}"
fi

echo "Script finished successfully."