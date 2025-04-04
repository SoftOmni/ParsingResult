#!/bin/bash

# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

# --- Get Git Hash ---
echo "Info: Getting current Git commit hash..."
GIT_HASH=$(git rev-parse HEAD)
if [ -z "$GIT_HASH" ]; then
  echo "Error: Failed to retrieve Git commit hash using 'git rev-parse HEAD'."
  exit 1
fi
echo "Info: Git commit hash retrieved: ${GIT_HASH}"

# --- Get Git Tag (if exists) ---
echo "Info: Attempting to retrieve Git tag for the current commit..."
GIT_TAG=$(git describe --tags --exact-match 2>/dev/null || true)
if [ -z "$GIT_TAG" ]; then
  GIT_TAG="No tag"
  echo "Info: No exact Git tag found for the current commit."
else
  echo "Info: Exact Git tag found: ${GIT_TAG}"
fi

# --- Output to Standard Output (and optionally GitHub Actions env) ---
echo "--- Script Output ---"
echo "GIT_HASH=${GIT_HASH}"
echo "GIT_TAG=${GIT_TAG}"
echo "--- End Script Output ---"

# --- Export to GitHub Actions environment ---
if [ -n "$GITHUB_ENV" ] && [ -f "$GITHUB_ENV" ]; then
  echo "Info: Exporting GIT_HASH and GIT_TAG to GITHUB_ENV"
  echo "GIT_HASH=${GIT_HASH}" >> "$GITHUB_ENV"
  echo "GIT_TAG=${GIT_TAG}" >> "$GITHUB_ENV"
  echo "Exported: GIT_HASH=${GIT_HASH}"
  echo "Exported: GIT_TAG=${GIT_TAG}"
else
  echo "Warning: GITHUB_ENV is not set or not a file. Skipping export to GITHUB_ENV."
fi

echo "Script finished successfully."
