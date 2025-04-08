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
GIT_TAG=$(git describe --tags --exact-match 2>/dev/null || echo "No tag") # Simplified assignment
if [ "$GIT_TAG" == "No tag" ]; then
  echo "Info: No exact Git tag found for the current commit."
else
  echo "Info: Exact Git tag found: ${GIT_TAG}"
fi

# --- Output to Standard Output (for logging) ---
echo "--- Script Logging Output ---"
echo "GIT_HASH=${GIT_HASH}"
echo "GIT_TAG=${GIT_TAG}"
echo "--- End Script Logging Output ---"

# --- Set GitHub Actions Step Outputs via Environment File ---
# Check if the GITHUB_OUTPUT environment variable is set and is a file
if [ -n "$GITHUB_OUTPUT" ] && [ -f "$GITHUB_OUTPUT" ]; then
    echo "Info: Setting step outputs via GITHUB_OUTPUT file..."
    # Append outputs in KEY=VALUE format to the file specified by GITHUB_OUTPUT
    echo "GIT_HASH=${GIT_HASH}" >> "$GITHUB_OUTPUT"
    echo "GIT_TAG=${GIT_TAG}" >> "$GITHUB_OUTPUT"
    echo "Info: Step outputs GIT_HASH and GIT_TAG written to GITHUB_OUTPUT."
else
    echo "Error: GITHUB_OUTPUT environment variable is not set or not a file."
    echo "Error: Cannot set step outputs using the required environment file method."
    exit 1 # Fail the step if the modern output mechanism isn't available
fi


# --- Export to GitHub Actions environment (Optional - only if needed by later steps IN THE SAME JOB) ---
# This remains unchanged, but consider if you still need it now that outputs are set correctly.
if [ -n "$GITHUB_ENV" ] && [ -f "$GITHUB_ENV" ]; then
  echo "Info: Exporting GIT_HASH and GIT_TAG to GITHUB_ENV (for potential use in subsequent steps of this job)"
  echo "GIT_HASH=${GIT_HASH}" >> "$GITHUB_ENV"
  echo "GIT_TAG=${GIT_TAG}" >> "$GITHUB_ENV"
else
  echo "Warning: GITHUB_ENV is not set or not a file. Skipping export to GITHUB_ENV."
fi

echo "Script finished successfully."