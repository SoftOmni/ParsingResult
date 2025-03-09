#!/bin/bash

HIGHEST_VERSION=$(sort -r dotnet-versions.txt | head -n 1)
echo "Highest .NET version found: $HIGHEST_VERSION"
echo "DOTNET_VERSION=$HIGHEST_VERSION" >> "$GITHUB_ENV"
