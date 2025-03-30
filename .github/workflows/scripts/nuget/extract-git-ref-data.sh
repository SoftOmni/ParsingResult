#!/bin/bash

if [ ! -f "github_refs.wd" ]; then
  echo "The file ${GITHUB_WORKSPACE}/github_refs.wd does not exist"
  exit 1
fi


GIT_REFERENCE=$(sed -n '1p' github_refs.wd)  # Read the first line (git reference) into the variable 'GIT_REFERENCE'
GIT_TAG=$(sed -n '2p' github_refs.wd)  # Read the second line (tag if present) into the variable 'tag'

# Optionally, export the variables so they are accessible outside the script
echo "GIT_REFERENCE=${GIT_REFERENCE}" >> "$GITHUB_ENV"
echo "GIT_TAG=${GIT_TAG}" >> "$GIT_TAG"