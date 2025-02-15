#!/bin/bash

# Convert the current matrix target framework (e.g. net6.0) to an SDK version (e.g. 6.0.x)
sdk_version=$(echo "${{ matrix.dotnet_version }}" | sed 's/^net//').x
echo "Calculated .NET SDK version for test: $sdk_version"
echo "sdk_version=$sdk_version" >> $GITHUB_OUTPUT