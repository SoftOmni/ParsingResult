#!/bin/bash

# Find all test projects (adjust the pattern/path as needed)
echo "Finding test projects..."
test_projects=$(find "${1}" -type f -name "*Tests.csproj")
echo "Found projects: $test_projects"

# Extract .NET versions from the earlier matrix (assumes it's a JSON object with an 'include' key)
versions=$(echo '${{ needs.generate-matrix.outputs.matrix }}' | jq -r '.include[].dotnet_version')

# Build a JSON array of matrix entries.
matrix_entries="[]"
for project in $test_projects; do
  for version in $versions; do
    matrix_entries=$(echo "$matrix_entries" | jq --arg v "$version" --arg p "$project" '. + [{"dotnet_version": $v, "test_project": $p}]')
  done
done

echo "Generated test matrix:"
echo "$matrix_entries"
echo "::set-output name=test-matrix::$matrix_entries"