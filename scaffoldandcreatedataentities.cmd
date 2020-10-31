REM
REM Copyright Information
REM All source is copyright, Kevin Wittmer
REM See License.txt for more information (check Visual Studio Solution Items)
REM

REM
REM To begin, the dotnet ef can be installed as a global tool.
REM dotnet tool install --global dotnet-ef
REM
REM Also take care for this:
REM   dotnet add package Microsoft.EntityFrameworkCore.Design
REM
REM   https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet
REM  PowerShell link: https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell
REM
REM  Note, the latest version: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/
REM

REM
REM dotnet ef dbcontext scaffold
REM
dotnet ef dbcontext scaffold "Server=DBSERVER\SQLEXPRESS17;Database=LahmansDB;User Id=dbuser;Password=dbp@ssw0RD;" Microsoft.EntityFrameworkCore.SqlServer -o DataEntities

REM
REM Use the command dotnet ef migrations to setup for EF-TSQL DB migrations
REM
dotnet ef migrations add TSQL -c LahmanContext
