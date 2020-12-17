#!/bin/sh
docker run -e "MYSQL_DATABASE=LahmanDB" -e "MYSQL_SERVICE_HOST=10.2.1.1" -e "MYSQL_USER_ID=root" -e "MYSQL_USER_PASSWORD='somePassword" -it --rm -p 8086:5000 --name bbshapi-x1 kb8vme7/aspnet-core-chicago-repo:ms-bbshapi-alpine
