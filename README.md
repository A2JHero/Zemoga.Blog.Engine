# Zemoga.Blog.Engine Solution
Public repository with .NET Test in MVC. Solution to Zemoga .Net Technical Assessment (Dec 2019)

# Specification
1. The project works with .Net Core 3.0 and Entity Framework Core 3.0
2. Zemoga.Blog.Engine.Web: Is the UI project implemented with ASP.NET Core
3. Zemoga.Blog.Engine.Tests: Unit tests for application services, built with NUnit
4. Zemoga.Blog.Engine.Domain: Domain model and business rules
5. Zemoga.Blog.Engine.Infrastructure: Data infrastructure with Entity Framework Code First, Repository and Unit of Work patterns
6. Zemoga.Blog.Engine.Common: Common classes and helpers

## Prerequisites
.Net Core 3.0 
MS SQL Server 

## Installation
1. Open solution folder in file explore
2. locate file DatabaseCreationScript.sql and execute it in local machine, database objects will be created locally (ConnectionString are set locally)
3. Navigate to Zemoga.Blog.Engine.Web folder and open a command prompt in Administratpr mode
4. Type dotnet run and wait for application initialization be confirmed (will be hosted in http://localhost:5000)

# How to use
You should be able to navigate the app here <http://localhost:5000> as an anonymous user.

## Login as a viewer user
Go to <http://localhost:5000/Security/Login> and login with username "viewer" and any password.

## Login as a writer user
Go to <http://localhost:5000/Security/Login> and login with username "Writer" and any password.

## Login as a editor user
Go to <http://localhost:5000/Security/Login> and login with username "Editor" and any password.

Assessment Test Navigations and functionalities are followed as requested, so from login the use of the functionalities is restricted by the user's role. 