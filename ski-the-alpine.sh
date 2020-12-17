#!/bin/sh
docker run -e "ASPNETCORE_URLS=http://*:5000" -e "MYSQL_DATABASE=LahmanDB" -e "MYSQL_SERVICE_HOST=10.2.1.1" -e "MYSQL_USER_ID=root" -e "MYSQL_USER_PASSWORD='somePassword" --rm -p 8086:5000 --name bbshapi-x1 kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-alpine
