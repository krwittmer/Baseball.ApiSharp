#!/bin/sh
docker run -v "$(pwd)"/TestResults:/bbshapi/Baseball.ApiSharp.Dal.Tests/TestResults/ kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-tests
