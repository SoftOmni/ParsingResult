#!/bin/bash

location="tests_results/${1}"

if [ ! -d "${location}" ]; then
  echo "Creating directory ${location}"
  mkdir "${location}"
  if [ -d "${location}" ]; then
    echo "Created directory ${location}"
  else
    echo "Failed to create directory ${location} for some reasons. Check logs right above me."
    exit 1
  fi
else
  echo "Directory ${location} already exists!"
fi

exit 0
