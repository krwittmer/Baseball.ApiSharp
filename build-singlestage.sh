#!/bin/sh

#
# This does not work, yet! ;)
#

docker build -f MultiStageDockerfile -t kb8vme7/aspnet-core-chicago-repo:ms-bbshapi --target=webapi-build .
docker images

#
# Build first stage only, then copy published binaries from Docker image:
docker cp repo:ms-bbshapi:/bbshapi/Baseball.ApiSharp.Api/api-binary-published/. PublishedBinary
#
