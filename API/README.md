# .NET 6 with Entity Framework 

## Summary
* Azure SQL Server is used for cross-platform. 
* Azure storage is used to store pictures of starships. 

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
