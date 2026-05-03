# CSharp DotNetCore Middleware Static Files

## Overview

This project demonstrates the use of middleware in an ASP.NET Core application along with static file handling and basic security practices.

The application shows how HTTP requests and responses are processed through the middleware pipeline.

---

## Features

* Custom middleware for logging HTTP requests and responses
* Global error handling using exception middleware
* Static file serving from the wwwroot directory
* HTTPS redirection 
* Content Security Policy (CSP) for security

---

## Technologies Used

* C#
* .NET Core
* ASP.NET Core

---

## Project Structure

CSharp_DotNetCore_Middleware_StaticFiles/

* Program.cs
* *.csproj
* appsettings.json

wwwroot/

* index.html
* style.css
* script.js

Properties/

* launchSettings.json

---

## How to Run

1. Clone the repository
   git clone https://github.com/your-username/CSharp_DotNetCore_Middleware_StaticFiles.git

2. Navigate to the project
   cd CSharp_DotNetCore_Middleware_StaticFiles

3. Run the application
   dotnet run

4. Open in browser
   [http://localhost:xxxx/index.html](http://localhost:xxxx/index.html)

---

## Key Concepts

* Middleware pipeline in ASP.NET Core
* HTTP request and response handling
* Static file hosting using wwwroot
* Basic web security practices
* Exception handling

---

## Output

* Static page loads successfully
* Console logs request and response details
* Errors handled with a custom response
* Security headers applied



