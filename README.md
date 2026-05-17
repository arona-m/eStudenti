# eStudenti

A web application built with ASP.NET Core for managing academic data — students, professors, and courses — in an educational institution.

## About

eStudenti provides a clean and user-friendly platform for administering academic processes. The system supports full CRUD operations (create, read, update, delete) for all entities, and is designed with a modular architecture that can be easily extended for additional requirements.

### Relationships

The core of the application revolves around three entities and their relationships:

- A **student** can enroll in one or more courses
- A **professor** can teach one or more courses
- A **course** is taught by exactly one professor

## Features

- Student, professor, and course management
- User authentication and authorization via ASP.NET Identity
- Full CRUD operations for all entities
- Relational data structure with Entity Framework Core
- Responsive UI with Bootstrap

## Tech Stack

| Technology | Purpose |
|---|---|
| ASP.NET Core 6+ | Main web framework |
| Entity Framework Core | ORM for database communication |
| Microsoft SQL Server Express | Database |
| ASP.NET Identity | User authentication & management |
| Razor Pages / MVC | Dynamic UI rendering |
| Bootstrap | Frontend styling |
| Dependency Injection | Architecture pattern |

## Project Structure

```
eStudenti/
├── Controllers/        # Application logic and routing
├── Models/             # Core entities (Student, Professor, Course)
├── Views/              # Razor UI templates
├── Data/
│   ├── Migrations/     # EF Core database migrations
│   └── ApplicationDbContext.cs
├── Areas/Identity/     # Authentication pages
├── wwwroot/            # Static files (CSS, JS, libs)
├── Program.cs          # App entry point and configuration
└── appsettings.json    # App configuration
```

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended)

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/arona-m/eStudenti.git
   cd eStudenti
   ```

2. **Configure the database connection**

   Open `appsettings.json` and update the connection string to match your SQL Server instance:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=YOUR_SERVER;Database=eStudenti;Integrated Security=True;..."
   }
   ```

3. **Apply migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```
   Or press **F5** in Visual Studio.

## License

This project is for educational purposes.
