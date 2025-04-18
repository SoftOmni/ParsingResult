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

# --- Find Highest Valid Version ---

# Regex to match .NET versions like netX.Y or netX.Y.Z (more flexible)
# Anchored (^$) to ensure the whole string matches
# Allows for single or multi-digit major/minor versions
# netX.Y format: ^net[0-9]+\.[0-9]+$
# netX.Y.Z format: ^net[0-9]+\.[0-9]+\.[0-9]+$ (unlikely for SDK target frameworks, but possible)
# Combined (optional patch): ^net[0-9]+\.[0-9]+(\.[0-9]+)?$
version_regex='^net[0-9]+\.[0-9]+$' # Sticking to netX.Y as per example

# 1. Use jq to extract the raw strings from the array under the specified key.
# 2. Filter the extracted lines for those matching the version format using grep.
# 3. Sort the valid versions using version sort (-V) in reverse order (-r).
# 4. Take the first line (which is the highest version) using head.
#
# If 'jq' fails (e.g., file not JSON, key missing), script exits due to 'set -e'.
# If 'grep' finds no matching lines, it exits with status 1.
# Because 'set -o pipefail' is active, the non-zero exit status of grep
# will cause the entire pipeline (and thus the script, due to 'set -e') to fail *if* no valid versions are found.
# We add an explicit check later for clarity and a better error message.

# Use a temporary variable to store the result, handling potential grep failure more explicitly
extracted_versions=$(jq -r --arg key "$JSON_KEY" '.[$key][]' "$FILENAME")
if [ -z "$extracted_versions" ]; then
    echo "Info: The array under key \"${JSON_KEY}\" in ${FILENAME} is empty. No versions to process."
    # Depending on requirements, you might want to exit here or proceed (resulting in "No valid versions found" later)
    # exit 0 # Or exit 1 if an empty array is an error
fi

# Now filter, sort, and get the highest
# Use || true for grep to prevent script exit if no match, handle empty result explicitly
HIGHEST_VERSION=$(echo "$extracted_versions" | grep -E "$version_regex" | sort -Vr | head -n 1 || true)


# Explicit check for whether a valid version was found after filtering/sorting
if [ -z "$HIGHEST_VERSION" ]; then
  echo "Error: No valid versions matching the format '${version_regex}' found under key \"${JSON_KEY}\" in ${FILENAME}."
  exit 1
fi

# Final sanity check on the format (mostly redundant due to grep, but good practice)
if ! [[ "$HIGHEST_VERSION" =~ $version_regex ]]; then
  # This case should theoretically not be reached if grep worked correctly
  echo "Error: Internal inconsistency. Found version '$HIGHEST_VERSION' does not match expected format '${version_regex}' after filtering."
  exit 1
fi

echo "Highest valid .NET version found: $HIGHEST_VERSION"

# --- Export Variable ---
# Check if GITHUB_ENV is set and is a file (standard in GitHub Actions)
if [ -z "$GITHUB_ENV" ] || [ ! -f "$GITHUB_ENV" ]; then
    echo "Warning: GITHUB_ENV environment variable is not set or not a file. Skipping export."
    echo "Would have exported: DOTNET_VERSION=${HIGHEST_VERSION}"
else
    echo "Info: Exporting DOTNET_VERSION=${HIGHEST_VERSION} to ${GITHUB_ENV}"
    # Append the variable in the format required by GitHub Actions
    echo "DOTNET_VERSION=${HIGHEST_VERSION}" >> "${GITHUB_ENV}"
    echo "Exported: DOTNET_VERSION=${HIGHEST_VERSION}"
fi

echo "Script finished successfully."