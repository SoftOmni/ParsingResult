#!/bin/bash

# check that we have a single argument
if [ "$#" -ne 3 ]; then
  if [ "$#" -eq 1 ]; then
    echo "ERROR: expected the path to the test project but no arguments were provided."
  else
    echo "ERROR: expected three arguments 
    (a path to a test project, a base directory, a dotnet version) 
    but $# were provided."
  fi
  
  exit 2
fi

# check that the first argument points to a valid file
if [ ! -f "$1" ]; then
  echo "The dotnet project \"$1\" does not exist!"
  exit 1
fi

# check that the second argument point to a directory
if [ ! -d "$2" ]; then
  echo "The base directory \"$2\" does not exist!"
  exit 4
fi

# extract the parent directory of the provided file path
PARENT_DIRECTORY=$(dirname "$1")
echo "Parent directory: $PARENT_DIRECTORY"

# extract the current directory for later
PROJECT_DIRECTORY=$(pwd)
echo "Project directory: $PROJECT_DIRECTORY"

echo "PROJECT_DIRECTORY=$PROJECT_DIRECTORY" >> "$GITHUB_ENV"

cd "$PARENT_DIRECTORY" || exit 3

echo "Changed directory successfully to $PROJECT_DIRECTORY"
echo "Running tests:"

dotnet test --configuration Release --framework "$3" --logger "trx;LogFileName=$2/test_results/$3/test_results.trx" --no-build

echo "Changing back to main directory \"$PROJECT_DIRECTORY\""
cd "$PROJECT_DIRECTORY" || exit  5

echo "Changed directory successfully to $PROJECT_DIRECTORY"
