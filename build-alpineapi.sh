#!/bin/sh

docker build -f MultiStageDockerfile -t kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-alpine --target=webapi-runtime-alpine .
docker images
#
