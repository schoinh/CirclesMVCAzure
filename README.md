# Circles - https://circlesapp.azurewebsites.net

#### _Discover new friends and build social circles - August 16, 2019_

#### _By **Na Hyung Choi, Kelar Crisp, Erik Irgens, and Emerson Jordan**_

## Description

This Web site allows users to discover new friends and add them to private groups called circles.

The user can:
* Register a new account and log in
* Edit the user profile associated with the user's account
* Create "circles," which are private categories for grouping existing and potential friends (e.g. "Hiking")
* Browse other users' profiles and add them to circles

A user can only edit their own profile, and only view and edit their own circles.

#### Related GitHub Repositories

* Circles Web API (Azure hosted version): https://github.com/ejordan1/CirclesApiAzure
* Circles MVC app (local database version): https://github.com/erik-t-irgens/CIRCLES_MVC
* Circles Web API (local database version): https://github.com/schoinh/circles-api

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/schoinh/CirclesMVCAzure.git
    ```
2. Navigate to the production folder (CIRCLES_MVC)
3. Restore dependencies, update your local database, and run the application
    ```
    $ dotnet restore
    $ dotnet ef database update
    $ dotnet run
    ```
4. On a Web browser (Chrome recommended), navigate to http://localhost:5002

## Known Bugs
None at this time.

## Technologies Used
* C# / .NET Core
* ASP.NET Core MVC
* ASP.NET Identity
* Entity Framework Core
* LINQ

## Support and contact details

_Please feel free to submit contributions._

## License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi, Kelar Crisp, Erik Irgens, and Emerson Jordan_**
