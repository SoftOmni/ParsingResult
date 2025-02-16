#!/bin/bash

# Dynamically find all test projects (you can adjust the search pattern as needed)
for testproj in $(find . -type f -name "*Tests.csproj"); do
  echo "Running tests for $testproj with target framework ${1}"
  echo "Logs: $(basename "$testproj" .csproj)_${1}.trx"
  
  # Run dotnet test in the background and store the PID
  dotnet test "$testproj" --configuration Release \
    /p:TargetFramework="${1}" \
    /p:Version="${2}" \
    --logger "trx;LogFileName=test_results/${1}/$(basename "$testproj" .csproj)_${1}.trx" \
    --no-build &
  
  # Capture the PID of the last background process
  pids+=($!)
done

for pid in "${pids[@]}" ; do
  wait "$pid" 
done