#!/bin/bash

# Ensure a .NET version is provided
if [[ ! "$1" =~ ^net[0-9]+\.[0-9]+$ ]]; then
  echo "Error: Please provide the .NET version in netX.Y format (e.g., net6.0)."
  echo "Usage: $0 <dotnet_version>"
  exit 1
fi

DOTNET_VERSION="$1"
OUTPUT_ZIP="release_bin_files.zip"

# Find all non-test project directories (exclude directories with 'Test' in their name)
PROJECT_DIRS=$(find . -type d -not -path "*/bin/*" -not -path "*/obj/*" -not -path "*/.*/*" -not -iname "*Test*" -exec test -e {}/*.csproj \; -print)

# Prepare a temporary directory for zipping
TEMP_DIR=$(mktemp -d)

# Collect all bin/Release/<dotnet_version> directories
for PROJECT_DIR in $PROJECT_DIRS; do
  BIN_DIR="$PROJECT_DIR/bin/Release/$DOTNET_VERSION"
  if [ -d "$BIN_DIR" ]; then
    cp -r "$BIN_DIR"/* "$TEMP_DIR"
  fi
done

# Create the zip file
if [ "$(ls -A "$TEMP_DIR")" ]; then
  zip -r "$OUTPUT_ZIP" "$TEMP_DIR"/*
  echo "Created zip file: $OUTPUT_ZIP"
else
  echo "No files to zip. Ensure the projects have been built in Release mode for .NET version $DOTNET_VERSION."
fi

# Clean up temporary directory
rm -rf "$TEMP_DIR"