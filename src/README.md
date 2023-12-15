# API Ben 10

This is a simple C# API project for managing Aliens inspired by the popular TV show Ben 10. The project includes several components for managing Aliens, such as adding, editing, and retrieving Alien data.

## Table of Contents
- [Introduction](#api-ben-10)
- [Project Components](#project-components)
- [Usage](#usage)
- [Getting Started](#getting-started)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Project Components

### 1. `AlienExtensions`
- This component contains extension methods for mapping between Alien DTOs and the Alien entity.

### 2. `AlienDTO`
- Contains Data Transfer Objects (DTOs) for Alien entities, including `AlienGetDTO` and `AlienPostDTO`.

### 3. `AlienPostValidacao`
- A class for validating Alien post requests using FluentValidation.

### 4. `ServicoDeResposta`
- A generic service response class for wrapping API responses with success status, data, and messages.

### 5. `AlienApplication`
- Implements the business logic for managing Aliens and interacts with the `AlienService`.

### 6. `AlienService`
- Handles data operations and interacts with the database using Entity Framework Core. It provides methods for adding, editing, retrieving, and removing Aliens.

### 7. `AlienController`
- The API's main controller responsible for handling HTTP requests. It exposes endpoints for managing Aliens, including adding, editing, retrieving, and removing them.

### 8. `Entity`
- A base class for all entities, containing a unique identifier.

### 9. `AppDbContext`
- The Entity Framework Core context for managing the database and interacting with the `Alien` entity.

## Usage

To use this API, you can follow the instructions in the "Getting Started" section. After setting up the project, you can make HTTP requests to the available endpoints.

## Getting Started

To run this API project, you'll need to follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# development environment.
3. Build the project to restore dependencies and compile the code.
4. Configure your database connection in the `appsettings.json` file.
5. Run database migrations to create the necessary database schema.
6. Start the application.

## Endpoints

The API provides the following endpoints:

- `GET /api/aliens`: Retrieve a list of Aliens.
- `GET /api/aliens/{id}`: Retrieve a specific Alien by ID.
- `POST /api/aliens`: Add a new Alien.
- `PUT /api/aliens/{id}`: Edit an existing Alien.
- `DELETE /api/aliens/{id}`: Remove an Alien.

For detailed usage of these endpoints, please refer to the code or API documentation.

## Contributing

If you'd like to contribute to this project, feel free to fork the repository and submit pull requests with your improvements. We welcome contributions to make this project even better!

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
