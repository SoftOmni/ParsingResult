#!/bin/bash

# --- Configuration & Setup ---
# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

# --- Determine Mode (Single Version vs. All Versions) ---
MODE="single" # Default mode
if [ -z "$1" ]; then
  MODE="all"
  echo "Info: No .NET version specified. Script will process artifacts for all found versions."
else
  MODE="single"
  DOTNET_VERSION_ARG="$1"
  echo "Info: Specific .NET version requested: ${DOTNET_VERSION_ARG}"
fi

# --- Variable Initialization based on Mode ---
SCRIPT_START_DIR=$(pwd) # Remember where we started
projects_packaged=0
total_projects_found_in_artifacts=0

if [ "$MODE" == "all" ]; then
  ARTIFACTS_ROOT_PATTERN="build-artifacts-net*.*" # Pattern to find root dirs
  SEARCH_ROOT="." # Search from the current directory
  # Define the path pattern to find *any* netX.Y dir within any matching root dir
  PATH_PATTERN="./${ARTIFACTS_ROOT_PATTERN}/*/bin/Release/net[0-9]*.[0-9]*"
  OUTPUT_ZIP="release_bin_files_all_versions.zip"
  REPORTING_VERSION_TEXT="all found versions"

  # --- Validate At Least One Artifacts Root Directory Exists ---
  # Use ls -d which exits cleanly if no match is found, suppress output
  if ! ls -d "${ARTIFACTS_ROOT_PATTERN}" > /dev/null 2>&1; then
    echo "Error: No artifact root directories matching '${ARTIFACTS_ROOT_PATTERN}' found in the current directory."
    echo "Error: Please ensure projects have been built using the corresponding build script/process."
    exit 1
  fi
  echo "Info: Searching for artifacts across all roots matching: ${ARTIFACTS_ROOT_PATTERN}"

else # MODE == "single"
  # --- Argument Validation for Single Version Mode ---
  dotnet_version_regex='^net[0-9]+\.[0-9]+$'
  if [[ ! "$DOTNET_VERSION_ARG" =~ $dotnet_version_regex ]]; then
    echo "Error: Please provide the target .NET version in netX.Y format (e.g., net8.0)."
    echo "Usage: $0 [<dotnet_version>]"
    echo "       (Omit <dotnet_version> to package all found versions)"
    exit 1
  fi

  DOTNET_VERSION="$DOTNET_VERSION_ARG"
  ARTIFACTS_ROOT_DIR="build-artifacts-${DOTNET_VERSION}"
  OUTPUT_ZIP="release_bin_files_${DOTNET_VERSION}.zip" # Make zip name version specific
  REPORTING_VERSION_TEXT="target framework '${DOTNET_VERSION}'"
  SEARCH_ROOT="${ARTIFACTS_ROOT_DIR}" # Search within the specific root
  # Define the path pattern relative to the specific root dir
  PATH_PATTERN="*/bin/Release/${DOTNET_VERSION}"

  echo "Info: Target .NET Version: ${DOTNET_VERSION}"
  echo "Info: Searching for artifacts in root: ${ARTIFACTS_ROOT_DIR}"

  # --- Validate Specific Artifacts Root Directory ---
  if [ ! -d "${ARTIFACTS_ROOT_DIR}" ]; then
    echo "Error: Artifacts root directory '${ARTIFACTS_ROOT_DIR}' not found."
    echo "Error: Please ensure the projects have been built using the corresponding build script/process"
    echo "Error: which places outputs in '${ARTIFACTS_ROOT_DIR}'."
    exit 1
  fi
fi

echo "Info: Output Zip File: ${OUTPUT_ZIP}"

# --- Temporary Directory ---
# Create a temporary directory for staging files
TEMP_DIR=$(mktemp -d)
# Ensure temporary directory is cleaned up on script exit or interruption
# Use a more robust trap that also shows the exit code
trap 'EXIT_CODE=$?; echo "Info: Cleaning up temporary directory: ${TEMP_DIR}"; rm -rf "${TEMP_DIR}"; exit $EXIT_CODE' EXIT HUP INT QUIT PIPE TERM

echo "Info: Created temporary directory: ${TEMP_DIR}"

# --- Find and Process Artifact Directories ---
# Use process substitution (< <(...)) to run the while loop in the current shell.
# The find command parameters are set based on the MODE determined earlier.
echo "Info: Searching for final artifact directories..."
echo "Info: Search Root: '${SEARCH_ROOT}'"
echo "Info: Path Pattern: '${PATH_PATTERN}'"

while IFS= read -r -d $'\0' source_bin_dir; do

    total_projects_found_in_artifacts=$((total_projects_found_in_artifacts + 1))

    # Extract the project name from the path. This logic works regardless of
    # whether the path starts with './build-artifacts...' or just 'MyProject/...'
    # because it works backwards from the known structure '.../ProjectName/bin/Release/netX.Y'
    project_name_dir=$(dirname "$(dirname "$(dirname "$source_bin_dir")")")
    project_name=$(basename "$project_name_dir")
    # Extract the .NET version from the source directory for potential sub-folder structuring if needed later
    source_dotnet_version=$(basename "$source_bin_dir")

    echo "Info: Found potential artifacts for project: ${project_name} (${source_dotnet_version}) in ${source_bin_dir}"

    # --- Filter out Test Projects ---
    if [[ "$project_name" =~ \.[Tt]ests?$ || "$project_name" == *[Tt]est* ]]; then
        echo "Info: Skipping test project: ${project_name}"
        continue # Skip to the next found directory
    fi

    # Check if the specific artifact directory is not empty
    if [ "$(ls -A "$source_bin_dir")" ]; then
        echo "Info: Found non-empty artifact directory for non-test project: ${project_name} (${source_dotnet_version})"
        # Structure within temp dir: ProjectName/netX.Y/ (optional, but good practice if mixing versions)
        # If sticking to original structure (just ProjectName): dest_proj_dir="${TEMP_DIR}/${project_name}"
        dest_proj_dir="${TEMP_DIR}/${project_name}" # Keeping original structure for simplicity

        echo "Info: Creating destination subdirectory: ${dest_proj_dir}"
        mkdir -p "$dest_proj_dir"

        echo "Info: Copying files from ${source_bin_dir} to ${dest_proj_dir}"
        # Copy contents using 'cp -a'. If multiple versions map to the same project name,
        # the last one processed will overwrite previous ones in the TEMP_DIR.
        # If this is undesirable, the dest_proj_dir needs to include the source_dotnet_version.
        if cp -a "$source_bin_dir/." "$dest_proj_dir/"; then
             projects_packaged=$((projects_packaged + 1)) # Count successful packages
        else
            echo "Error: Failed to copy files from ${source_bin_dir} to ${dest_proj_dir}"
            # Let the script exit due to set -e
        fi
    else
        echo "Warning: Artifact directory '${source_bin_dir}' is empty for project '${project_name}'. Skipping packaging this one."
    fi
done < <(find "${SEARCH_ROOT}" -type d -path "${PATH_PATTERN}" -print0)

echo "Info: Total potential project artifact directories found matching pattern: ${total_projects_found_in_artifacts}"

# --- Create Zip File ---
if [ "$projects_packaged" -gt 0 ]; then
    echo "Info: Copied artifacts from ${projects_packaged} non-test project directories."
    echo "Info: Creating zip file: ${OUTPUT_ZIP}"
    # Zip contents of TEMP_DIR
    if (cd "$TEMP_DIR" && zip -rq "${SCRIPT_START_DIR}/${OUTPUT_ZIP}" .); then
        echo "Success: Created zip file: ${SCRIPT_START_DIR}/${OUTPUT_ZIP}"
    else
        echo "Error: Failed to create zip file."
        exit 1
    fi
else
    echo "Warning: No non-empty artifact directories found for any non-test projects."
    echo "Warning: Ensure the relevant projects have been built successfully in 'Release' configuration for ${REPORTING_VERSION_TEXT}."
    echo "Warning: No zip file created."
fi

# Cleanup is handled by the trap EXIT handler
echo "Script finished."