#!/bin/sh
docker run -v "$(pwd)"/PublishedBinary:/bbshapi/Baseball.ApiSharp.Api/api-binary-published/ kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-deployed
