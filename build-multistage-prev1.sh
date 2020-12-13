#!/bin/sh
docker build -f MultiStageDockerfile-prev1 -t kb8vme7/aspnet-core-chicago-repo:ms-bbshapi .
docker images

