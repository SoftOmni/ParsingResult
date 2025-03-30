#!/bin/bash

# Save the current git hash (ref) on the first line of github_refs.wd
git rev-parse HEAD > github_refs.wd

# Save the git tag on the second line if it exists
git describe --tags --exact-match 2>/dev/null >> github_refs.wd || echo "No tag" >> github_refs.wd
