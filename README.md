# EF Core - Sample

## Introduction

## Commands

- dotnet ef migrations add dev.1.0.0 -p src/Infrastructure.Data.DataSetup.Development
- dotnet ef migrations script -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Up/dev.0.0.0-dev.1.0.0.sql
- dotnet ef migrations script 0 -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Down/dev.1.0.0-dev.0.0.0.sql
- dotnet ef migrations add dev.1.0.1 -p src/Infrastructure.Data.DataSetup.Development
- dotnet ef migrations script dev.1.0.0 dev.1.0.1 -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Up/dev.1.0.0-dev.1.0.1.sql
- dotnet ef migrations script dev.1.0.1 dev.1.0.0 -i -p src/Infrastructure.Data.DataSetup.Development -o src/Infrastructure.Data.DataSetup.Development/Scripts/Down/dev.1.0.1-dev.1.0.0.sql
- dotnet ef migrations add v1.0.0 -p src/Infrastructure.Data.DataSetup.Release
- dotnet ef migrations script -i -p src/Infrastructure.Data.DataSetup.Release -o src/Infrastructure.Data.DataSetup.Release/Scripts/Up/v0.0.0-v1.0.0.sql
- dotnet ef migrations script 0 -i -p src/Infrastructure.Data.DataSetup.Release -o src/Infrastructure.Data.DataSetup.Release/Scripts/Down/v1.0.0-v0.0.0.sql