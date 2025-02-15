#!/bin/bash

# Dynamically find all test projects (you can adjust the search pattern as needed)
for testproj in $(find . -type f -name "*Tests.csproj"); do
  echo "Running tests for $testproj with target framework ${{ matrix.dotnet_version }}"
  echo "Logs: $(basename "$testproj" .csproj)_${{ matrix.dotnet_version }}.trx"
  
  # Run dotnet test in the background and store the PID
  dotnet test "$testproj" --configuration Release \
    /p:TargetFramework=${{ matrix.dotnet_version }} \
    /p:Version=${{ env.VERSION }} \
    --logger "trx;LogFileName=$(basename "$testproj" .csproj)_${{ matrix.dotnet_version }}.trx" \
    --no-build &
  
  # Capture the PID of the last background process
  pids+=($!)
done

for pid in "${pids[@]}" ; do
  wait "$pid" 
done