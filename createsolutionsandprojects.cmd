rem
rem This cmd file was derived from Phil's VSLive script
rem

rem create the global json file and pin the .NET Core SDK version
dotnet new globaljson --sdk-version 3.1.401

rem create the solution
dotnet new sln -n Baseball.ApiSharp

rem create the ASP.NET Core Web App project and add it to the solution
dotnet new mvc -n Baseball.ApiSharp.Mvc -au none --no-https  -o .\Baseball.ApiSharp.Mvc
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Mvc

rem create the ASP.NET Core Web API project and add it to the solution
dotnet new mvc -n Baseball.ApiSharp.Api -au none --no-https  -o .\Baseball.ApiSharp.Api
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Api

rem create the Data Access Layer class library, and add to the solution
dotnet new classlib -n Baseball.ApiSharp.Dal -o .\Baseball.ApiSharp.Dal -f netcoreapp3.1
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Dal

rem create the Data (objects) library, and add to the solution
dotnet new classlib -n Baseball.ApiSharp.Data.Lahman -o .\Baseball.ApiSharp.Data.Lahman -f netcoreapp3.1
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Data.Lahman
mkdir Baseball.ApiSharp.Data.Lahman\BaseEntities

rem create the class library for the Models and add it to the solution
dotnet new classlib -n Baseball.ApiSharp.Models -o .\Baseball.ApiSharp.Models -f netcoreapp3.1
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Models

rem create the data-centric tests XUnit project and add it to the solution
dotnet new xunit -n Baseball.ApiSharp.Dal.Tests -o .\Baseball.ApiSharp.Dal.Tests
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Dal.Tests

rem create the models-centric XUnit project and add it to the solution
dotnet new xunit -n Baseball.ApiSharp.Models.Tests -o .\Baseball.ApiSharp.Models.Tests
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Models.Tests

rem create the API-centric XUnit project and add it to the solution
dotnet new xunit -n Baseball.ApiSharp.Api.Tests -o .\Baseball.ApiSharp.Api.Tests
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Api.Tests

rem create a F# RESTful client
dotnet new console -lang F# -n Baseball.ApiSharp.Client -o .\Baseball.ApiSharp.Client
dotnet sln Baseball.ApiSharp.sln add Baseball.ApiSharp.Client

dotnet add Baseball.ApiSharp.Mvc reference Baseball.ApiSharp.Models
dotnet add Baseball.ApiSharp.Mvc reference Baseball.ApiSharp.Dal

dotnet add Baseball.ApiSharp.Dal reference Baseball.ApiSharp.Models
dotnet add Baseball.ApiSharp.Dal reference Baseball.ApiSharp.LahmanData

dotnet add Baseball.ApiSharp.Dal.Tests reference Baseball.ApiSharp.Models
dotnet add Baseball.ApiSharp.Dal.Tests reference Baseball.ApiSharp.Dal

dotnet add Baseball.ApiSharp.Models.Tests reference Baseball.ApiSharp.Models

dotnet add Baseball.ApiSharp.Api.Tests reference Baseball.ApiSharp.Api

dotnet add Baseball.ApiSharp.Mvc package AutoMapper -v 9.0.0
dotnet add Baseball.ApiSharp.Mvc package LigerShark.WebOptimizer.Core -v 3.0.250
dotnet add Baseball.ApiSharp.Mvc package Microsoft.Web.LibraryManager.Build -v 2.0.96
dotnet add Baseball.ApiSharp.Mvc package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.0

dotnet add Baseball.ApiSharp.Dal package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.0 
dotnet add Baseball.ApiSharp.Dal package Microsoft.EntityFrameworkCore.Design -v 3.1.0
dotnet add Baseball.ApiSharp.Dal package Microsoft.EntityFrameworkCore.Tools -v 3.1.0
dotnet add Baseball.ApiSharp.Dal package System.Text.Json -v 4.7.0

dotnet add Baseball.ApiSharp.Models package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.0 
dotnet add Baseball.ApiSharp.Models package Microsoft.EntityFrameworkCore.Design -v 3.1.0
dotnet add Baseball.ApiSharp.Models package Microsoft.EntityFrameworkCore.Tools -v 3.1.0
dotnet add Baseball.ApiSharp.Models package System.Text.Json -v 4.7.0

dotnet add Baseball.ApiSharp.Data.Lahman package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.0 
dotnet add Baseball.ApiSharp.Data.Lahman package Microsoft.EntityFrameworkCore.Design -v 3.1.0
dotnet add Baseball.ApiSharp.Data.Lahman package Microsoft.EntityFrameworkCore.Tools -v 3.1.0
dotnet add Baseball.ApiSharp.Data.Lahman package System.Text.Json -v 4.7.0

dotnet add Baseball.ApiSharp.Models package Microsoft.EntityFrameworkCore.Abstractions -v 3.1.0
dotnet add Baseball.ApiSharp.Models package AutoMapper -v 9.0.0
dotnet add Baseball.ApiSharp.Models package System.Text.Json -v 4.7.0

dotnet add Baseball.ApiSharp.Dal.Tests package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.0
