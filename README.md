# EF Core - Sample

This is a sample project that shows the implementation of EF Core, managing the migrations separately from the actual entities and the code. In general, there when we talk about CI/CD in any commercial projects, the database and their deployments come in to the picture. Though EF Core in itself gives an option to migrate the database post deployment but that generally is not the best strategy, since the feedback is super-late.

In order to improve the odds and shifting left, here we are trying to leverage the script generation capabilities of EF Core for the CD pipeline to deploy.

## Introduction

The project has been setup in the .NET 6.0 and C# 10.0 and we have followed a simple structure meant to house the source code in the `src` folder.

### Projects

Based on other samples from other sources, categorizing the projects into `Apps` and `Infrastructure` whereby `Data` would house the code for the EF-Core.

1. __Infrastructure.Data.DataAccess__ - This project houses the actual entities for the system. The code has been structured in such a way that the configurations for the entities have been segregated into configurations for each entity under the `Configurations` folder. We can perform operations like indexes, master data, entity defaults, etc.
2. __Infrastructure.Data.DataSetup.Development__ - This projects houses the migrations for the development environment.
3. __Infrastructure.Data.DataSetup.Release__ - This projects houses the migrations for the release environment.
4. __Application.WithMigration__ - This is the application project that uses the migrations in the traditional sense, which can migrate the database with EF Core.
5. __Application.WithoutMigration__ - This is the application project that assumes there is a separate pipeline that runs the migrations on the database and we are just running the application with the data context.

## Commands Used

- __Generate Migrations__
  - dotnet ef migrations add dev.1.0.0 -p src/Infrastructure.Data.DataSetup.Development
  - dotnet ef migrations add dev.1.0.1 -p src/Infrastructure.Data.DataSetup.Development
  - dotnet ef migrations add v1.0.0 -p src/Infrastructure.Data.DataSetup.Release
  
- __Generate Scripts__
  - dotnet ef migrations script -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Up/dev.0.0.0-dev.1.0.0.sql
  - dotnet ef migrations script dev.1.0.0 0 -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Down/dev.1.0.0-dev.0.0.0.sql
  - dotnet ef migrations script dev.1.0.0 dev.1.0.1 -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Up/dev.1.0.0-dev.1.0.1.sql
  - dotnet ef migrations script dev.1.0.1 dev.1.0.0 -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Down/dev.1.0.1-dev.1.0.0.sql
  - dotnet ef migrations script -i -p src/Infrastructure.Data.DataSetup.Release -o src/Infrastructure.Data.DataSetup.Release/Scripts/Up/v0.0.0-v1.0.0.sql
  - dotnet ef migrations script v1.0.0 0 -i -p src/Infrastructure.Data.DataSetup.Release -o src/Infrastructure.Data.DataSetup.Release/Scripts/Down/v1.0.0-v0.0.0.sql