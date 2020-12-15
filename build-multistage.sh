#!/bin/sh
docker build -f MultiStageDockerfile -t kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-deployed .
docker images
