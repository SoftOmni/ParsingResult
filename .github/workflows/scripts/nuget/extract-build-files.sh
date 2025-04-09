#!/bin/bash

# --- Configuration & Setup ---
# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

# --- Variables ---
ARCHIVE_NAME="build-data.zip"
WORKSPACE_DIR=$(pwd) # Should be the root of the checkout

echo "Info: Starting build artifact extraction process."
echo "Info: Working directory: ${WORKSPACE_DIR}"
echo "Info: Expected archive: ${ARCHIVE_NAME}"

# --- Validate Input Archive ---
if [ ! -f "${ARCHIVE_NAME}" ]; then
  echo "Error: Build data archive '${ARCHIVE_NAME}' not found in the current directory."
  echo "Error: Ensure the 'Download build data' step succeeded."
  exit 1
fi
echo "Info: Found build data archive: ${ARCHIVE_NAME}"

# --- Temporary Directory ---
TEMP_DIR=$(mktemp -d)
# Ensure temporary directory is cleaned up on script exit or interruption
trap 'EXIT_CODE=$?; echo "Info: Cleaning up temporary extraction directory: ${TEMP_DIR}"; rm -rf "${TEMP_DIR}"; exit $EXIT_CODE' EXIT HUP INT QUIT PIPE TERM
echo "Info: Created temporary directory for extraction: ${TEMP_DIR}"

# --- Extract Archive ---
echo "Info: Extracting '${ARCHIVE_NAME}' to '${TEMP_DIR}'..."
if ! unzip -q "${ARCHIVE_NAME}" -d "${TEMP_DIR}"; then
    echo "Error: Failed to extract '${ARCHIVE_NAME}'."
    # The trap will handle cleanup
    exit 1
fi
echo "Info: Archive extracted successfully."
echo "Info: Contents of extraction directory:"
ls -l "${TEMP_DIR}"

# --- Process Extracted Projects ---
# Find all top-level directories within the temporary extraction folder.
# These directories should correspond to the project names.
find "${TEMP_DIR}" -mindepth 1 -maxdepth 1 -type d -print0 | while IFS= read -r -d $'\0' extracted_proj_dir; do

    project_name=$(basename "$extracted_proj_dir")
    echo "--- Processing project: ${project_name} ---"

    # --- Locate Source Project and .csproj File ---
    source_proj_dir="${WORKSPACE_DIR}/${project_name}"
    if [ ! -d "${source_proj_dir}" ]; then
        echo "Warning: Source directory '${source_proj_dir}' for project '${project_name}' not found in workspace. Skipping placement."
        continue # Skip to the next project
    fi

    # Assuming .csproj file has the same name as the directory
    csproj_file="${source_proj_dir}/${project_name}.csproj"
    if [ ! -f "${csproj_file}" ]; then
        echo "Warning: .csproj file '${csproj_file}' not found for project '${project_name}'. Cannot determine target frameworks. Skipping placement."
        continue # Skip to the next project
    fi
    echo "Info: Found source project directory: ${source_proj_dir}"
    echo "Info: Found .csproj file: ${csproj_file}"

    # --- Extract Target Frameworks (TFM) from .csproj ---
    # Look for <TargetFramework>...</TargetFramework> OR <TargetFrameworks>...</TargetFrameworks>
    # This grep/sed approach is basic and might fail on complex csproj files.
    # It extracts the content between the tags and replaces ';' with spaces.
    tfm_line=$(grep -E '<TargetFramework>s?([^<]*)<\/TargetFramework>s?' "${csproj_file}" || true)
    target_frameworks=$(echo "$tfm_line" | sed -n 's/.*<TargetFramework>s*>\(.*\)<[/]TargetFramework>s*>.*/\1/p' | sed 's/;/ /g')

    if [ -z "$target_frameworks" ]; then
        echo "Warning: Could not extract TargetFramework(s) from '${csproj_file}'. Skipping placement for '${project_name}'."
        continue # Skip to the next project
    fi
    echo "Info: Extracted Target Framework(s): ${target_frameworks}"

    # --- Place Artifacts for Each TFM ---
    for tfm in $target_frameworks; do
        # Define the final destination directory based on standard build output structure
        destination_dir="${source_proj_dir}/bin/Release/${tfm}"

        echo "Info: Preparing destination for TFM '${tfm}': ${destination_dir}"
        # Create the destination directory if it doesn't exist
        mkdir -p "${destination_dir}"

        echo "Info: Copying artifacts from '${extracted_proj_dir}' to '${destination_dir}'"
        # Copy *all* extracted files for this project into the TFM-specific directory.
        # 'dotnet pack' will use these when processing this specific TFM.
        # Use 'cp -a' to preserve attributes, '.' ensures hidden files are copied too.
        if ! cp -a "${extracted_proj_dir}/." "${destination_dir}/"; then
             echo "Error: Failed to copy artifacts for project '${project_name}' TFM '${tfm}'."
             # Let the script exit due to set -e
             # The trap will handle cleanup
             exit 1
        fi
        echo "Info: Successfully copied artifacts for TFM '${tfm}'."
    done
    echo "--- Finished processing project: ${project_name} ---"

done

# Cleanup is handled by the trap EXIT handler
echo "Info: Build artifact extraction and placement completed successfully."