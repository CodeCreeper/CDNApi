# CDN Developer Network API

CDN Developer Network is a platform to manage a directory of freelancers, allowing users to register, update, delete, and retrieve information about freelancers.

## Table of Contents
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [API Endpoints](#api-endpoints)
  - [Get All Users](#get-all-users)
  - [Get User by ID](#get-user-by-id)
  - [Create User](#create-user)
  - [Update User](#update-user)
  - [Delete User](#delete-user)
- [Technologies Used](#technologies-used)

## Getting Started
Before running the api please ensure that the relevant packages and files are installed to avoid any problems while running such as NuGAT and Entity Framework.

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or higher)
- [Visual Studio Code](https://code.visualstudio.com/) or any preferred code editor
- [Microsoft SQL Server](https://www.microsoft.com/en-my/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

### Installation
1. Clone the repository
   ```bash
   git clone https://github.com/CodeCreeper/CDNApi.git
2. Navigate to the project folder
   cd CDNApi
3. Run the application
   dotnet run
4. Click on the link that is provided in the terminal by using CTRL + Left Mouse Click

### API Endpoints
1. Get All Users
   Retrieve a list of all registered users.

   URL: /api/users
   Method: GET
   Get User by ID

2. Retrieve information about a specific user by providing their ID.

   URL: /api/users/{id}
   Method: GET
   Create User

3. Register a new user in the system.

   URL: /api/users
   Method: POST
   Request Body: JSON object with user details (username, mail, phone number, skillsets, hobby)

4. Update User
   Update information for an existing user based on their ID.
  
   URL: /api/users/{id}
   Method: PUT
   Request Body: JSON object with updated user details

5. Delete User
   Delete a user from the system based on their ID.

   URL: /api/users/{id}
   Method: DELETE

### Technologies Used
- ASP.NET Core
- Entity Framework Core
- Microsoft SQL Server
- Swagger for API documentation
- SQL Server Management Studio
