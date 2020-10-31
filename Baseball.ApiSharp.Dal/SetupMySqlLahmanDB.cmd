@echo off

REM
REM Commands to drop and re-create DB/schema for Lahman.
"E:\MySQL 8.0.18\bin\mysql" -h localhost -u root --password=MiSs-5.7.17$ -e "drop database lahmans2019db"
"E:\MySQL 8.0.18\bin\mysql" -h localhost -u root --password=MiSs-5.7.17$ -e "create database lahmans2019db"
"E:\MySQL 8.0.18\bin\mysql" -h localhost -u root --password=MiSs-5.7.17$ < "e:\Lahmans DB Import\lahman2019-mysql-dump.sql"

REM
REM Run from subdirectory path .\Baseball.ApiSharp\Baseball.ApiSharp.Dal
REM Make sure the DB context connects to a MySQL instance.
REM
REM Make sure this public propertiy is set to false:
REM   public bool IsSqlServerDb { get; set; };
REM
dotnet ef database update -c Baseball.ApiSharp.Dal.EfStructures.LahmansDbMigrationContext