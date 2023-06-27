# Starships
## App is deployed online
App is now dockerized and available for testing at https://starships.azurewebsites.net

## [Backend](API) is using .NET 6 Web API 
## [Frontend](client) is using React with Material UI (MUI) for base components and stylings.

This app is seeded with `starships` data obtained by calling the https://swapi.dev api. Basic `films` and `people` data are seeded to allow adding related ship-to-film and ship-to-pilot relations.

### Features Summary
* CRUD operations of starships are mostly implemented end-to-end. Endpoints are available for testing [Swagger](http://localhost:5293/swagger/index.html)
  * Search capabilities with starship name, dynamically filtered by starship class, alphabatically sorting.
  * List of search result is returned in pages. Details of ship included the appeared film and pilot lists if available.
  * Listing of all films and people.
  * API endpoints to update the related films and pilots.

## Bonus
* When creating and updating starship, user can upload picture to Azure storage.
* Deleting starship deletes the related picture.

## Features that are not available but would be nice to have
* User access to lock down modifying data to only admin user.
* User login with different roles for different permissions.
* Replace some TextField controls with other more user friendly components e.g. Select dropdown
* UI for managing related films and pilots.
* Unit tests!
