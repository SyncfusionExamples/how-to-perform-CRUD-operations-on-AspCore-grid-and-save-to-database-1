# How to Perform CRUD Operations on ASP.NET Core Grid and Save to Database

## Repository Description

This repository contains an ASP.NET Core MVC sample that demonstrates CRUD operations using the Syncfusion EJ2 Grid with a SQL Server database.

## Project Overview

This sample shows how the Syncfusion EJ2 Data Grid integrates with an ASP.NET Core backend using the URL adaptor. Grid data is retrieved from and saved to a SQL Server database through MVC controller actions implemented with Entity Framework Core.

The application uses a local NORTHWND database and focuses on practical server-side data handling such as create, read, update, delete, paging, and sorting operations.

## Key Features

- ASP.NET Core MVC application
- Syncfusion EJ2 Grid with URL adaptor
- Full CRUD operations
- Entity Framework Core with SQL Server
- Server-side paging and sorting

## Prerequisites

- Visual Studio 2022
- Supported .NET SDK for ASP.NET Core
- SQL Server LocalDB or Express

## Running the Application

Follow the steps below to clone the repository, restore dependencies, and run the ASP.NET Core application using the .NET CLI.

1. Clone the repository and navigate to the project directory:

   ```bash
   git clone https://github.com/SyncfusionExamples/how-to-perform-CRUD-operations-on-AspCore-grid-and-save-to-database-1.git
   cd how-to-perform-CRUD-operations-on-AspCore-grid-and-save-to-database-1\WebApp
   ```

2. Restore the required NuGet packages:

   ```bash
   dotnet restore
   ```

3. Update the database connection string:
   - Open `appsettings.json`.
   - Ensure the SQL Server connection string points to a valid **NORTHWND** database instance.

4. Build the application:

   ```bash
   dotnet build
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Open a browser and navigate to the displayed application URL.

Once the application loads, the Syncfusion EJ2 Grid page allows performing create, read, update, and delete operations, with all changes persisted to the SQL Server database.

## Additional Resources

- [Syncfusion ASP.NET Core Grid Connecting to DataBase](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-database)
- [Syncfusion ASP.NET Core Grid Editing](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/)
- [Syncfusion ASP.NET Core Grid Documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid)
- [Syncfusion ASP.NET Core Demos](https://ej2.syncfusion.com/aspnetcore)
