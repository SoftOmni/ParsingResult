#!/bin/bash

# --- Configuration & Setup ---
# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

# --- Argument Validation ---
dotnet_version_regex='^net[0-9]+\.[0-9]+$'
if [[ ! "$1" =~ $dotnet_version_regex ]]; then
  echo "Error: Please provide the target .NET version in netX.Y format (e.g., net8.0)."
  echo "Usage: $0 <dotnet_version>"
  exit 1
fi

DOTNET_VERSION="$1"
# Define the root directory where build artifacts are stored
ARTIFACTS_ROOT_DIR="build-artifacts-${DOTNET_VERSION}"
OUTPUT_ZIP="release_bin_files_${DOTNET_VERSION}.zip" # Make zip name version specific
SCRIPT_START_DIR=$(pwd) # Remember where we started

echo "Info: Target .NET Version: ${DOTNET_VERSION}"
echo "Info: Searching for artifacts in root: ${ARTIFACTS_ROOT_DIR}"
echo "Info: Output Zip File: ${OUTPUT_ZIP}"

# --- Validate Artifacts Root Directory ---
if [ ! -d "${ARTIFACTS_ROOT_DIR}" ]; then
  echo "Error: Artifacts root directory '${ARTIFACTS_ROOT_DIR}' not found."
  echo "Error: Please ensure the projects have been built using the corresponding build script/process"
  echo "Error: which places outputs in '${ARTIFACTS_ROOT_DIR}'."
  exit 1
fi

# --- Temporary Directory ---
# Create a temporary directory for staging files
TEMP_DIR=$(mktemp -d)
# Ensure temporary directory is cleaned up on script exit or interruption
# Use a more robust trap that also shows the exit code
trap 'EXIT_CODE=$?; echo "Info: Cleaning up temporary directory: ${TEMP_DIR}"; rm -rf "${TEMP_DIR}"; exit $EXIT_CODE' EXIT HUP INT QUIT PIPE TERM

echo "Info: Created temporary directory: ${TEMP_DIR}"

# --- Find and Process Artifact Directories ---
projects_packaged=0
total_projects_found_in_artifacts=0

# Find all directories matching the final artifact path structure within the artifacts root.
# -print0 and read -d are used for safe handling of paths with spaces/special chars.
echo "Info: Searching for final artifact directories within ${ARTIFACTS_ROOT_DIR}..."
find "${ARTIFACTS_ROOT_DIR}" -type d -path "*/bin/Release/${DOTNET_VERSION}" -print0 | while IFS= read -r -d $'\0' source_bin_dir; do

    total_projects_found_in_artifacts=$((total_projects_found_in_artifacts + 1))

    # Extract the project name from the path.
    # Example path: build-artifacts-net8.0/MyProject.Lib/bin/Release/net8.0
    # 1. Get parent dir: build-artifacts-net8.0/MyProject.Lib/bin/Release
    # 2. Get parent dir: build-artifacts-net8.0/MyProject.Lib/bin
    # 3. Get parent dir: build-artifacts-net8.0/MyProject.Lib
    # 4. Get basename:   MyProject.Lib
    project_name_dir=$(dirname "$(dirname "$(dirname "$source_bin_dir")")")
    project_name=$(basename "$project_name_dir")

    echo "Info: Found potential artifacts for project: ${project_name} in ${source_bin_dir}"

    # --- Filter out Test Projects ---
    # Check if the project name looks like a test project (case-insensitive)
    if [[ "$project_name" =~ \.[Tt]ests?$ || "$project_name" == *[Tt]est* ]]; then
        echo "Info: Skipping test project: ${project_name}"
        continue # Skip to the next found directory
    fi

    # Check if the specific artifact directory is not empty
    if [ "$(ls -A "$source_bin_dir")" ]; then
        echo "Info: Found non-empty artifact directory for non-test project: ${project_name}"
        dest_proj_dir="${TEMP_DIR}/${project_name}"

        echo "Info: Creating destination subdirectory: ${dest_proj_dir}"
        mkdir -p "$dest_proj_dir"

        echo "Info: Copying files from ${source_bin_dir} to ${dest_proj_dir}"
        # Copy contents using 'cp -a' to preserve attributes, '.' ensures hidden files are copied too
        if cp -a "$source_bin_dir/." "$dest_proj_dir/"; then
             projects_packaged=$((projects_packaged + 1))
        else
            echo "Error: Failed to copy files from ${source_bin_dir} to ${dest_proj_dir}"
            # Let the script exit due to set -e
            # Or explicitly exit if set -e is removed: exit 1
        fi
    else
        echo "Warning: Artifact directory '${source_bin_dir}' is empty for project '${project_name}'. Skipping packaging this one."
    fi
done

echo "Info: Total potential project artifact directories found: ${total_projects_found_in_artifacts}"

# --- Create Zip File ---
if [ "$projects_packaged" -gt 0 ]; then
    echo "Info: Packaged files from ${projects_packaged} non-test projects."
    echo "Info: Creating zip file: ${OUTPUT_ZIP}"
    # Change directory to TEMP_DIR so the paths inside the zip are relative (e.g., MyProject/... instead of tmp/tmp.Xxx/MyProject/...)
    # Zip contents of TEMP_DIR (which now contains sub-dirs per project)
    if (cd "$TEMP_DIR" && zip -r "${SCRIPT_START_DIR}/${OUTPUT_ZIP}" .); then
        echo "Success: Created zip file: ${SCRIPT_START_DIR}/${OUTPUT_ZIP}"
    else
        # This else block might not be reached if 'set -e' is active,
        # as the script would exit on zip failure before executing the else.
        echo "Error: Failed to create zip file."
        # EXIT trap will still handle cleanup
        exit 1 # Explicit exit just in case set -e is bypassed somehow or removed
    fi
else
    echo "Warning: No non-empty artifact directories found for any non-test projects in '${ARTIFACTS_ROOT_DIR}'."
    echo "Warning: Ensure the relevant projects have been built successfully in 'Release' configuration for the target framework '${DOTNET_VERSION}'."
    echo "Warning: No zip file created."
fi

# Cleanup is handled by the trap EXIT handler
echo "Script finished."