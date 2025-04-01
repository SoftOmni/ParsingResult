#!/bin/bash

# Exit immediately if a command exits with a non-zero status.
set -e
# Treat unset variables as an error when substituting.
# set -u # Optional: uncomment if you want to be stricter about unset variables
# The return value of a pipeline is the status of the last command to exit with a non-zero status.
set -o pipefail

# --- Configuration ---
TAG_NAME="$1"
# Regex for strict X.Y.Z version format (e.g., 1.0.0, 0.2.10, 123.45.678)
version_regex='^[0-9]+\.[0-9]+\.[0-9]+$'
# Explicit string often used to indicate no tag was found upstream
no_tag_marker="No tag"
# GitHub Actions specific exit code for neutral outcome (skip)
neutral_exit_code=78

echo "Info: Received potential tag name: '${TAG_NAME}'"

# --- Initial Tag Validation ---
# Check if the tag name looks like a valid version format and isn't the "No tag" marker.
if [[ -z "$TAG_NAME" ]]; then
    echo "Validation failed: No tag name provided (argument was empty). Skipping further steps."
    exit $neutral_exit_code
elif [ "$TAG_NAME" == "$no_tag_marker" ]; then
    echo "Validation failed: Tag explicitly indicated as '${no_tag_marker}'. Skipping further steps."
    exit $neutral_exit_code
elif ! [[ "$TAG_NAME" =~ $version_regex ]]; then
    echo "Validation failed: Tag format invalid: '${TAG_NAME}'. Expected strictly X.Y.Z format. Skipping further steps."
    exit $neutral_exit_code
else
    echo "Info: Tag '${TAG_NAME}' format is valid X.Y.Z."
    # Tag format is valid, proceed to compare with existing Git tags.
fi

# --- Fetch and Compare with Existing Git Tags ---

echo "Info: Fetching latest tags from remote repository..."
# Use --force to ensure local tags are updated even if they exist
# Use --prune to remove local refs that no longer exist on the remote
# Use --prune-tags if supported (Git 2.17+) as a more specific alternative to --prune for tags
# Handle potential fetch failure
if ! git fetch --tags --force --prune; then
    echo "Error: Failed to fetch tags from the remote repository. Cannot compare versions."
    exit 1 # Exit with a non-neutral code indicating a real failure
fi
echo "Info: Fetch complete."

echo "Info: Listing existing tags and finding highest X.Y.Z version..."
# List all local tags (now updated from remote), filter for X.Y.Z, sort, get highest
# Use process substitution and handle case where no matching tags are found
highest_existing_tag=$(git tag --list | grep -E "$version_regex" | sort -V | tail -n 1 || true)
# The '|| true' prevents script exit if grep finds no matching tags (pipefail would otherwise trigger)

if [ -z "$highest_existing_tag" ]; then
    echo "Info: No existing tags with X.Y.Z format found in the repository. Assuming '${TAG_NAME}' is the first valid version."
else
    echo "Info: Highest existing X.Y.Z tag found: '${highest_existing_tag}'"

    # Perform the comparison only if an existing tag was found
    # Combine the new tag and the highest existing tag, sort them by version.
    # The strictly newer tag *must* appear last in the sorted list.
    # We also check that they are not identical.
    sorted_versions=$(printf "%s\n%s" "$highest_existing_tag" "$TAG_NAME" | sort -V)
    highest_overall=$(echo "$sorted_versions" | tail -n 1)

    if [ "$TAG_NAME" == "$highest_existing_tag" ]; then
        echo "Validation failed: Tag '${TAG_NAME}' is identical to the highest existing tag '${highest_existing_tag}'. Skipping further steps."
        exit $neutral_exit_code
    elif [ "$TAG_NAME" != "$highest_overall" ]; then
        # If the new tag is NOT the highest in the combined sorted list, it's older or equal.
        echo "Validation failed: Tag '${TAG_NAME}' is not strictly greater than the highest existing tag '${highest_existing_tag}'. Skipping further steps."
        exit $neutral_exit_code
    else
        # New tag is the highest overall and not equal to the previous highest -> valid.
         echo "Info: Tag '${TAG_NAME}' is greater than highest existing tag '${highest_existing_tag}'."
    fi
fi

# --- Final Success ---
# If the script reaches here, all checks passed.
echo "Validation passed: Tag '${TAG_NAME}' is valid and newer than existing tags (or is the first version)."
echo "Info: Proceeding with steps using valid tag: ${TAG_NAME}"
# Add subsequent commands that should run only with a valid tag here.
