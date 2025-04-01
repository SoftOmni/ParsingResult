#!/bin/bash

EXPECTED_VERSION="$1"
if [ -z "$EXPECTED_VERSION" ]; then
  echo "Error: No version argument provided. Please provide the expected version as a parameter."
  exit 1
fi

if ! [[ "$EXPECTED_VERSION" =~ [0-9]+\.[0-9]+\.[0-9]+ ]]; then
    echo "Error: The expected version argument must follow [0-9]+\.[0-9]+\.[0-9]+ but did not: $EXPECTED_VERSION"
    exit 1
fi

set -e
SCRIPT_PATH=$(pwd)

# Find all .csproj files in the repository
PROJECT_FILES=$(find "$SCRIPT_PATH" -type f -name "*.csproj")

# Initialize an array to store target frameworks
VERSIONS=()

for PROJECT_FILE in $PROJECT_FILES; do
  # Extract single target framework (ignore if not present)
  TARGET=$(grep -oPm1 "(?<=<Version>)(.*)(?=</Version>)" "$PROJECT_FILE" || true)
  echo "Debug print: $TARGET"
  if [[ "$TARGET" =~ [0-9]+\.[0-9]+\.[0-9]+ ]]; then
    echo "Debug print: Adding $TARGET"
    VERSIONS+=("$TARGET")
  fi
done

NUMBER_OF_VERSIONS="${#VERSIONS[@]}"
if [ "$NUMBER_OF_VERSIONS" -eq "0" ]; then
  echo "Did not find any dotnet version. Aborting..."
  exit 1
fi

if [ "$NUMBER_OF_VERSIONS" -ne "1" ]; then
  mapfile -t UNIQUE_VERSIONS < <(printf "%s\n" "${VERSIONS[@]}" | sort -u)
  if [ "${#UNIQUE_VERSIONS[@]}" -ne 1 ]; then
    echo "Error: Multiple dotnet versions found (${UNIQUE_VERSIONS[*]}). Ensure all projects use the same version. Aborting..."
    exit 1
  fi
fi

ACTUAL_VERSION="${UNIQUE_VERSIONS[0]}"
if [ "$EXPECTED_VERSION" != "$ACTUAL_VERSION" ]; then
  echo "Error: Version mismatch. Expected '$EXPECTED_VERSION', but found '$ACTUAL_VERSION'. Aborting..."
  exit 1
fi

echo "Version check passed. Version: $ACTUAL_VERSION"
