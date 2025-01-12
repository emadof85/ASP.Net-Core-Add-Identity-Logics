# ASP.Net Core Add Identity Logics

This project demonstrates how to add identity logic to an ASP.Net Core application. It includes user authentication, authorization, and user management features.

## Features

- User Registration
- User Login
- Password Recovery
- Role-based Authorization

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/emadof85/ASP.Net-Core-Add-Identity-Logics.git
   ```
2. Navigate to the project directory:
   ```bash
   cd ASP.Net-Core-Add-Identity-Logics
   ```
3. Restore the dependencies:
   ```bash
   dotnet restore
   ```

### Running the Application

1. Build the project:
   ```bash
   dotnet build
   ```
2. Run the project:
   ```bash
   dotnet run
   ```

### Running Migrations

1. Edit your connection string in the `appsettings.json` file:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Your_Connection_String_Here"
     }
   }
   ```
2. Edit your connection string in the `DataAccess/Models/StudentDbContext.cs` file in the `OnConfiguring` function:
   ```csharp
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       optionsBuilder.UseSqlServer("Your_Connection_String_Here");
   }
   ```
3. Update the database with the project migration:
   ```bash
   dotnet ef database update
   ```


### Usage

- Open your browser and navigate to `https://localhost:5001` to access the application.
- Register a new user or log in with an existing account.
- Explore the features such as user profile management and role-based authorization.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.
