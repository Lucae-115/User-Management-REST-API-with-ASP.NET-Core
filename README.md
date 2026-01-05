# User Management REST API with ASP.NET Core

A simple and extensible REST API for managing user data, built with ASP.NET Core.  
This project was developed as part of a learning assignment and includes full CRUD functionality, validation, and custom middleware. GitHub Copilot was used throughout the development process for code generation, debugging, and improvements.

---

## Features

- **CRUD Endpoints for Users**
  - `GET /users` – Retrieve all users
  - `GET /users/{id}` – Retrieve a user by ID
  - `POST /users` – Create a new user
  - `PUT /users/{id}` – Update an existing user
  - `DELETE /users/{id}` – Delete a user

- **Validation**
  - Required fields (e.g., name, email)
  - Email format validation (`[EmailAddress]`)
  - Automatic error responses for invalid data

- **Middleware**
  - Request logging
  - Error handling
  - (Optional) Authentication / JWT support

- **Copilot Integration**
  - Assisted code generation
  - Debugging suggestions
  - Improvements for validation and middleware

---

## Technologies Used

- ASP.NET Core 8 (or your version)
- C#
- GitHub Copilot
- JSON-based REST communication

---

## Installation & Running the Project

### 1. Clone the repository
```bash
git clone https://github.com/Lucae-115/User-Management-REST-API-with-ASP.NET-Core.git
