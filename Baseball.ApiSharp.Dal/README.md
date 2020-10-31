
#
# This README file overviews the commands to setup and initialize the backend database, namely MySQL.
#

## MySQL command series
### Commands to drop, create and re-init Lahman database
#### "\MySQL\bin\mysql" -h localhost -u dbuser -p -e "drop database lahmans2019db"
#### "\MySQL\bin\mysql" -h localhost -u dbuser -p -e "create database lahmans2019db"
#### "\MySQL\bin\mysql" -h localhost -u dbuser -p < "\Lahmans\lahman2019-mysql-dump.sql"

## Applying an existing EF Core migration
###
### Consider EF Migration commands, and work from this subdirectory:
####   \Source\repos\Baseball.ApiSharp\Baseball.ApiSharp.Dal
####
####   dotnet ef database update -c Baseball.ApiSharp.Dal.EfStructures.LahmansDbMigrationContext

## Capturing the EF Core migrations
###
### Execute this EF command to define/create the EF migration:
####  This is a one-time capture. Source files generated <timestame>_IAT.cs and <db>DbMigrationContextModelSnapshot.cs
####  dotnet ef migrations add IAT -o EfStructures\Migrations -c Baseball.ApiSharp.Dal.EfStructures.LahmansDbMigrationContext

###
### Note, prior to execution verify the status of the bool member, IsSqlServerDb
### This should be set to false when accessing MySQL.
###
