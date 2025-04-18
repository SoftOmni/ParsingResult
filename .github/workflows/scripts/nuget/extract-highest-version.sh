#!/bin/bash

# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

FILENAME="dotnet-versions.txt"
JSON_KEY="dotnet_version" # Key in the JSON containing the version array
GLOBAL_JSON_FILENAME="global.json" # Name of the file to generate

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
version_regex='^net[0-9]+\.[0-9]+(\.[0-9]+)?$'

extracted_versions=$(jq -r --arg key "$JSON_KEY" '.[$key][]' "$FILENAME")
if [ -z "$extracted_versions" ]; then
    echo "Info: The array under key \"${JSON_KEY}\" in ${FILENAME} is empty. No versions to process."
    HIGHEST_NET_VERSION=""
else
    HIGHEST_NET_VERSION=$(echo "$extracted_versions" | grep -E "$version_regex" | sort -Vr | head -n 1 || true)
fi

if [ -z "$HIGHEST_NET_VERSION" ]; then
  echo "Error: No valid versions matching the format '${version_regex}' found under key \"${JSON_KEY}\" in ${FILENAME}."
  exit 1
fi

echo "Info: Highest raw version found: ${HIGHEST_NET_VERSION}"

# --- Convert Highest Version to X.Y.Z Format ---
VERSION_NUMERIC_PART=$(echo "$HIGHEST_NET_VERSION" | sed 's/^net//')

if [[ "$VERSION_NUMERIC_PART" == *.*.* ]]; then
    HIGHEST_XYZ_VERSION="$VERSION_NUMERIC_PART"
elif [[ "$VERSION_NUMERIC_PART" == *.* ]]; then
    HIGHEST_XYZ_VERSION="${VERSION_NUMERIC_PART}.0"
else
    echo "Error: Could not parse version part '$VERSION_NUMERIC_PART' from '$HIGHEST_NET_VERSION' into X.Y or X.Y.Z format after stripping 'net'."
    exit 1
fi

echo "Highest valid .NET version (formatted as X.Y.Z): $HIGHEST_XYZ_VERSION"

# --- Generate global.json ---
# Creates a global.json file in the current directory specifying the highest found SDK version.
# The 'rollForward' policy ensures compatible newer SDKs can be used if the exact one isn't present.
echo "Info: Generating ${GLOBAL_JSON_FILENAME} with SDK version ${HIGHEST_XYZ_VERSION}..."
printf '{\n  "sdk": {\n    "version": "%s",\n    "rollForward": "latestMajor"\n  }\n}\n' "$HIGHEST_XYZ_VERSION" > "$GLOBAL_JSON_FILENAME"
# Check if file was created (optional, set -e handles most write errors)
if [ ! -f "$GLOBAL_JSON_FILENAME" ]; then
    echo "Error: Failed to create ${GLOBAL_JSON_FILENAME}"
    exit 1
fi
echo "Info: Successfully generated ${GLOBAL_JSON_FILENAME}"
cat "$GLOBAL_JSON_FILENAME" # Optional: display the generated file contents

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