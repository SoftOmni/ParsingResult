#!/bin/bash

# Find all test projects (adjust the pattern/path as needed)
echo "Finding test projects..."
test_projects=$(find . -type f -name "*Tests.csproj")
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

echo "Generated test matrix (array):"
echo "$matrix_entries"

# Wrap the array in an object with the 'include' key.
final_matrix=$(jq -n --argjson entries "$matrix_entries" '{include: $entries}')
echo "Final test matrix (object):"
echo "$final_matrix"

echo "::set-output name=test-matrix::$final_matrix"