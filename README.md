# ContactsAppAPI

Used .NET libraries: 
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.AspNetCore.Identity.EntityFrameworkCore
* Microsoft.AspNetCore.Identity
* Microsoft.AspNetCore.Authentication.JwtBearer

## Description

Controllers work as gateways to the application. <br> The flow goes this way: `Controller -> Service -> Repository -> DB` <br>
Endpoints are designed in RESTful manner, so  `GET, POST, PUT, DELETE` http methods are used. <br>
Dependency Injection is used in most cases. <br>
Register/Login is based on Json Web Token. It is necessary to pass the JWT token (received from login response) sending other requests; otherwise they are rejected. <br>
`CORS` is configured to pass `http://localhost:4200` requests (port used for angular app).
