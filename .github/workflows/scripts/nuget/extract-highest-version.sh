#!/bin/bash

# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

FILENAME="dotnet-versions.txt"

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

# --- Find Highest Valid Version ---

# Regex to match semantic versions (X.Y.Z)
# Anchored (^$) to ensure the whole line matches
version_regex='^[0-9]+\.[0-9]+\.[0-9]+$'

# 1. Filter the file for lines matching the version format using grep.
# 2. Sort the valid versions using version sort (-V) in reverse order (-r).
# 3. Take the first line (which is the highest version) using head.
#
# If 'grep' finds no matching lines, it exits with status 1.
# Because 'set -o pipefail' is active, the non-zero exit status of grep
# will cause the entire pipeline (and thus the script, due to 'set -e') to fail.
# This elegantly handles the case of an empty file or a file with no valid versions.
HIGHEST_VERSION=$(grep -E "$version_regex" "$FILENAME" | sort -Vr | head -n 1)

# Explicit check (good practice, though redundant with pipefail+grep behavior):
if [ -z "$HIGHEST_VERSION" ]; then
  echo "Error: No valid X.Y.Z versions found in ${FILENAME}."
  exit 1
fi

echo "Info: found highest version: ${FILENAME}"

if ! [[ "$HIGHEST_VERSION" =~ $version_regex ]]; then
  echo "Error: Invalid version '$HIGHEST_VERSION': should be in format X.Y.Z"
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
