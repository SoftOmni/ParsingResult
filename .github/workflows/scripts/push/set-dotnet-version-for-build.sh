#!/bin/bash

# Convert the highest target framework to an SDK version.
# E.g., "net9.0" becomes "9.0.x"
sdk_version=$(echo "${{ needs.generate-matrix.outputs.highest }}" | sed 's/^net//').x
echo "Calculated .NET SDK version for build: $sdk_version"
echo "sdk_version=$sdk_version" >> $GITHUB_OUTPUT