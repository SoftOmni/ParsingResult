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

# --- Extract Version Parts ---
# Strip the leading 'net' -> e.g., "9.0" or "8.0.100"
VERSION_NUMERIC_PART=$(echo "$HIGHEST_NET_VERSION" | sed 's/^net//')
# Extract Major.Minor part -> e.g., "9.0" or "8.0"
BASE_VERSION_XY=$(echo "$VERSION_NUMERIC_PART" | cut -d. -f1,2)

echo "Info: Base Major.Minor version: ${BASE_VERSION_XY}"

# --- Convert Highest Version to X.Y.Z Format (for potential other uses) ---
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

# --- Generate global.json using X.Y format ---
# This format requests the latest available feature band for the specified major.minor version.
# The 'rollForward' policy ensures compatible newer SDKs can be used if the exact one isn't present.
echo "Info: Generating ${GLOBAL_JSON_FILENAME} with SDK version specification '${BASE_VERSION_XY}'..."
printf '{\n  "sdk": {\n    "version": "%s",\n    "rollForward": "latestFeature"\n  }\n}\n' "$BASE_VERSION_XY" > "$GLOBAL_JSON_FILENAME"
# Note: Using 'latestFeature' rollForward is often suitable when specifying only X.Y.
# 'latestMajor' might jump from 9.0 to 10.0 if available, which might not be desired here.
# 'latestMinor' would roll forward within 9.x (e.g., 9.1, 9.2) if those existed.
# 'latestFeature' effectively means latest patch within the 9.0 feature band.

# Check if file was created (optional, set -e handles most write errors)
if [ ! -f "$GLOBAL_JSON_FILENAME" ]; then
    echo "Error: Failed to create ${GLOBAL_JSON_FILENAME}"
    exit 1
fi
echo "Info: Successfully generated ${GLOBAL_JSON_FILENAME}"
echo "Info: Content of ${GLOBAL_JSON_FILENAME}:"
cat "$GLOBAL_JSON_FILENAME" # Display the generated file contents

# --- Export FULL X.Y.Z Variable ---
# Export the potentially non-installable X.Y.Z version, in case other tools need it.
# setup-dotnet should now use the global.json generated above.
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