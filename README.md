# Project Information

### ASP. NET 5 with GraphQL

- MSSQL (Entity Framework Core)
- HotChocolate (For GraphQL integration)
- GraphQL Voyager

## To Do

- Documentation (Abstracted)
- Add Resolvers
- Add Payloads and Inputs (using records)
- Add Mutations
- Add Subscriptions

## Done

- Create App
- Created empty new web application ASP. NET 5 (dotnet new web)
- Installed packages (dotnet add package)
  - Entity Framework Core (Microsoft.EntityFrameworkCore.Design, Microsoft.EntityFrameworkCore.SQLServer)
  - Hot Chocolate (HotChocolate.AspNetCore, HotChocolate.Data.Entityframework)
  - GraphQL Voyager (GraphQL.Server.UI.Voyager)
- Install Dependencies
- Created Models
- Create DB Context instance
- Migrations (using Entity Framework Core)
  - dotnet ef migrations add (name of migration)
  - dotnet ef database update
- Querying GraphQL
  - Created Query.cs to query using GraphQL
    - Updating DbContext to AddPooledDbContextFactory for multiple calls for the GraphQL
    - Added Annotations for a scoped service and to use DbContext (Scoped: Creating one instance per client request)
