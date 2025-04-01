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
  echo "Error: Please provide the target .NET version in netX.Y format (e.g., net6.0)."
  echo "Usage: $0 <dotnet_version>"
  exit 1
fi

DOTNET_VERSION="$1"
OUTPUT_ZIP="release_bin_files.zip"
SCRIPT_START_DIR=$(pwd) # Remember where we started

echo "Info: Target .NET Version: ${DOTNET_VERSION}"
echo "Info: Output Zip File: ${OUTPUT_ZIP}"

# --- Temporary Directory ---
# Create a temporary directory for staging files
TEMP_DIR=$(mktemp -d)
# Ensure temporary directory is cleaned up on script exit or interruption
trap 'echo "Info: Cleaning up temporary directory: ${TEMP_DIR}"; rm -rf "${TEMP_DIR}"' EXIT HUP INT QUIT PIPE TERM

echo "Info: Created temporary directory: ${TEMP_DIR}"

# --- Find and Process Projects ---
projects_processed=0
files_found_to_zip=0

# Find all .csproj files, excluding common build/hidden folders and test projects.
# -print0 and read -d are used for safe handling of filenames with spaces/special chars.
# We exclude paths containing '/test/' or ending in '.Tests.csproj' (case-insensitive)
echo "Info: Searching for non-test .csproj files..."
find . -type f -name "*.csproj" \
    -not \( \
        -path "*/bin/*" -o \
        -path "*/obj/*" -o \
        -path "*/.*/*" \
     \) \
    -not \( \
        -ipath "*test*/*.csproj" -o \
        -ipath "*/*.tests.csproj" \
     \) \
    -print0 | while IFS= read -r -d $'\0' project_file; do

    projects_processed=$((projects_processed + 1))
    project_dir=$(dirname "$project_file")
    # Use the csproj filename (without extension) as a subdirectory name for uniqueness
    project_name=$(basename "$project_file" .csproj)
    source_bin_dir="${project_dir}/bin/Release/${DOTNET_VERSION}"

    echo "Info: Processing project: ${project_file}"

    # Check if the specific Release directory exists and is not empty
    if [ -d "$source_bin_dir" ] && [ "$(ls -A "$source_bin_dir")" ]; then
        echo "Info: Found Release directory: ${source_bin_dir}"
        dest_proj_dir="${TEMP_DIR}/${project_name}"

        echo "Info: Creating destination subdirectory: ${dest_proj_dir}"
        mkdir -p "$dest_proj_dir"

        echo "Info: Copying files from ${source_bin_dir} to ${dest_proj_dir}"
        # Copy contents using 'cp -a' to preserve attributes, '.' ensures hidden files are copied too
        cp -a "$source_bin_dir/." "$dest_proj_dir/"
        files_found_to_zip=$((files_found_to_zip + 1))
    else
        echo "Warning: Release directory '${source_bin_dir}' not found or is empty for project '${project_file}'. Skipping."
    fi
done

echo "Info: Total projects checked: ${projects_processed}"

# --- Create Zip File ---
if [ "$files_found_to_zip" -gt 0 ]; then
    echo "Info: Found files from ${files_found_to_zip} projects to include in the zip."
    echo "Info: Creating zip file: ${OUTPUT_ZIP}"
    # Change directory to TEMP_DIR so the paths inside the zip are relative
    # Zip contents of TEMP_DIR (which now contains subdirs per project)
    (cd "$TEMP_DIR" && zip -r "${SCRIPT_START_DIR}/${OUTPUT_ZIP}" .)
    # Check zip command exit status (though set -e should handle it)
    if [ $? -eq 0 ]; then
        echo "Success: Created zip file: ${SCRIPT_START_DIR}/${OUTPUT_ZIP}"
    else
        echo "Error: Failed to create zip file."
        # EXIT trap will still handle cleanup
        exit 1
    fi
else
    echo "Warning: No non-empty 'bin/Release/${DOTNET_VERSION}' directories found for any non-test projects."
    echo "Warning: Ensure the projects have been built successfully in 'Release' configuration for the target framework '${DOTNET_VERSION}'."
    echo "Warning: No zip file created."
fi

# Cleanup is handled by the trap EXIT handler
echo "Script finished."
