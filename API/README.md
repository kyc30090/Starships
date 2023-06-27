# .NET 6 with Entity Framework 

## Summary
* Development was done in Mac. SQLite was used for cross-platform.
* Another connectionString is provided to connect to Azure SQL Server. Code to switch over from `UseSqlite` to `UseSqlServer` SQL server is commentted. Replace {Password} with correct value.
* Connection string to Azure storage is provided to store pictures of starships. Replace {AccountKey} with correct value.

## To run the .NET backend
* `dotnet ef database update`
* Update connectionString with correct values.
* Standard command line `dotnet run` or run in Visual Studio
* It uses port 5293. Swagger is located http://localhost:5293/swagger/index.html

## List of endpints
### Films
GET
/api/Films

### People

GET
/api/People

### Starships
GET
/api/Starships/list

GET
/api/Starships/{id}

DELETE
/api/Starships/{id}

GET
/api/Starships/random

POST
/api/Starships

PUT
/api/Starships

GET
/api/Starships/filters

POST
/api/Starships/addFilms

POST
/api/Starships/addPilots
