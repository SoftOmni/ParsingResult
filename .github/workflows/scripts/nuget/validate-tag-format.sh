#!/bin/bash




TAG_NAME="$1"

if [[ -z "$TAG_NAME" ]]; then
  echo "No tag found. Skipping publish."
  exit 0
fi
if [[ ! "$TAG_NAME" =~ ^[0-9]+\.[0-9]+\.[0-9]+$ ]]; then
  echo "Tag format invalid: $TAG_NAME. Skipping publish."
  exit 0
fi

echo "Valid tag: $TAG_NAME"