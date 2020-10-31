@echo off

REM Copyright & OSS License
REM All source is copyright, Kevin Wittmer
REM See License.txt for more information (check Visual Studio Solution Items)

dotnet ef migrations add IAT -o EfStructures\Migrations -c Baseball.ApiSharp.Dal.EfStructures.LahmansDbMigrationContext