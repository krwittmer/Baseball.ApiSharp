#!/bin/sh
docker build --target webapi-tests -f MultiStageDockerfile -t kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-tests .
docker run -v "$(pwd)"/TestResults:/bbshapi/Baseball.ApiSharp.Dal.Tests/TestResults/ kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-tests
