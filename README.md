After spending a few hours trying to figure out how to configure EF Core 2.1 in a separate class library project, and having looked at what's available on the internet, I thought of creating this project for anyone looking to do the same so they can benefit of this easy approach.

## Solution Projects
| Project | Application Layer |
| :--- | :--- |
| API | Web API Project |
| Data | Data Context and Repositories |

## Technologies
| Dependency | Version*
| :--- | ---:
| .NET Core Framework | 2.1
| Entity Framework Core | 2.1.4

## Links 
This project creates the DbContext from a design-time factory, details - 
https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation

## dotnet commands used in the project
*Create a webapi project*
dotnet new webapi --name API --output API

*Create the Data Class Library Project*
dotnet new classlib --name Data --output Data
Change the .csproj TargetFramework to netcoreapp2.1 to target .NET core

*Add Data project reference from API directory*
dotnet add reference ../Data/Data.csproj

## Required dependencies
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Design

## Optional dependencies
Following dependencies are required to access the appsettings configuration in the Data project from the API project:
Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.Json
Newtonsoft.Json