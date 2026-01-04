# NetCentric Labs

A comprehensive collection of .NET web development laboratory projects demonstrating various technologies, frameworks, and architectural patterns for net-centric computing.

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Laboratory Activities](#laboratory-activities)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Running the Applications](#running-the-applications)
- [Database Configuration](#database-configuration)

## 🎯 Project Overview

This repository contains multiple .NET-based web applications created as part of net-centric computing laboratory coursework. Each project demonstrates different aspects of modern web development, including MVC patterns, RESTful APIs, SPA frameworks, database operations, and authentication systems.

## 📁 Project Structure

```
NetCentricLabs/
├── AngularAppByAnurag/          # ASP.NET Core + Angular SPA
├── ReactAppByAnurag/            # ASP.NET Core + React SPA
├── JQueryAppByAnurag/           # ASP.NET Core MVC with jQuery
├── WebApiByAnurag/              # ASP.NET Core Web API with EF Core
├── CRUDConsolebyAnurag/         # Console-based CRUD application
├── WebApp1ByAnurag/             # ASP.NET Core MVC - Student Management
├── WebApp2ByAnurag/             # ASP.NET Core MVC - Services Pattern
├── WebApp3ByAnurag/             # ASP.NET Core MVC - Student CRUD
├── WebApp4ByAnurag/             # ASP.NET Core MVC - Repository Pattern
├── WebApp5ByAnurag/             # ASP.NET Core MVC - Docker Support
├── WebApp6ByAnurag/             # ASP.NET Core MVC - State Management
└── WebApp7ByAnurag/             # ASP.NET Core MVC - Identity & Authentication
```

## 🛠 Technologies Used

### Backend Technologies
- **ASP.NET Core 8.0** - Modern web framework for building web apps and APIs
- **C# .NET** - Primary programming language
- **Entity Framework Core** - Object-Relational Mapping (ORM) framework
- **ASP.NET Core Identity** - Authentication and authorization framework
- **SQL Server / LocalDB** - Database management system
- **ADO.NET** - Data access for console application

### Frontend Technologies
- **Angular 15** - TypeScript-based SPA framework
- **React 18** - JavaScript library for building user interfaces
- **jQuery 3.6** - JavaScript library for DOM manipulation
- **Bootstrap 5.2** - CSS framework for responsive design
- **Razor Views** - Server-side view engine
- **HTML5, CSS3, JavaScript** - Core web technologies

### Development Tools & Patterns
- **MVC (Model-View-Controller)** - Architectural pattern
- **Repository Pattern** - Data access abstraction
- **Dependency Injection** - Service container pattern
- **RESTful API** - API architectural style
- **Swagger/OpenAPI** - API documentation
- **Docker** - Containerization support

## 🧪 Laboratory Activities

### 1. **AngularAppByAnurag** - Angular Single Page Application
- Integration of Angular 15 with ASP.NET Core
- SPA routing and component architecture
- Frontend-backend communication
- Modern TypeScript development

### 2. **ReactAppByAnurag** - React Single Page Application
- React 18 with ASP.NET Core backend
- Component-based UI development
- React Router for navigation
- Bootstrap integration with Reactstrap

### 3. **JQueryAppByAnurag** - jQuery Web Application
- Traditional MVC architecture with jQuery
- Client-side interactivity
- AJAX operations
- Form validation

### 4. **WebApiByAnurag** - RESTful Web API
- ASP.NET Core Web API development
- Entity Framework Core for data access
- Product management CRUD operations
- Swagger UI for API testing
- SQL Server database integration

### 5. **CRUDConsolebyAnurag** - Console CRUD Application
- Console-based database operations
- ADO.NET for data access
- Direct SQL command execution
- Product management system
- LocalDB integration

### 6. **WebApp1ByAnurag** - Student Management System
- Basic MVC application
- Student data management
- Controller and View integration
- Bootstrap UI

### 7. **WebApp2ByAnurag** - Services Pattern Implementation
- Service layer architecture
- Separation of concerns
- Business logic abstraction
- Dependency injection pattern

### 8. **WebApp3ByAnurag** - Student CRUD Operations
- Complete CRUD functionality
- Form handling and validation
- Data persistence
- MVC best practices

### 9. **WebApp4ByAnurag** - Repository Pattern
- Repository pattern implementation
- Generic repository interface
- Entity Framework Core integration
- Database-first approach
- Student management with migrations

### 10. **WebApp5ByAnurag** - Dockerized Application
- Docker containerization
- Dockerfile configuration
- Repository pattern continuation
- Production-ready deployment

### 11. **WebApp6ByAnurag** - State Management
- Session and state management
- TempData and ViewBag usage
- State controller implementation
- Data persistence across requests

### 12. **WebApp7ByAnurag** - Authentication & Authorization
- ASP.NET Core Identity implementation
- User registration and login
- Role-based authorization (Admin, User roles)
- Cookie-based authentication
- Database seeding for roles and admin user
- Secure password handling

## 📋 Prerequisites

Before running these applications, ensure you have the following installed:

- **.NET 8.0 SDK** or later - [Download](https://dotnet.microsoft.com/download)
- **Visual Studio 2022** or **Visual Studio Code**
- **SQL Server** or **SQL Server LocalDB**
- **Node.js and npm** (for Angular and React apps)
- **Docker** (optional, for WebApp5ByAnurag)

## 🚀 Getting Started

### Clone the Repository

```bash
git clone https://github.com/Anuragbhtri019/NetCentricLabs.git
cd NetCentricLabs
```

### Build the Projects

Navigate to any project directory and restore dependencies:

```bash
cd <ProjectName>
dotnet restore
dotnet build
```

## ▶️ Running the Applications

### ASP.NET Core MVC Applications (WebApp1-7, JQueryApp)

```bash
cd <ProjectDirectory>
dotnet run
```

The application will start on `https://localhost:5001` or `http://localhost:5000` by default.

### Angular Application

```bash
cd AngularAppByAnurag
dotnet run
```

Or for frontend development:

```bash
cd AngularAppByAnurag/ClientApp
npm install
npm start
```

### React Application

```bash
cd ReactAppByAnurag
dotnet run
```

Or for frontend development:

```bash
cd ReactAppByAnurag/ClientApp
npm install
npm start
```

### Web API

```bash
cd WebApiByAnurag
dotnet run
```

Access Swagger UI at: `https://localhost:<port>/swagger`

### Console Application

```bash
cd CRUDConsolebyAnurag
dotnet run
```

Follow the on-screen menu to perform CRUD operations.

### Docker (WebApp5ByAnurag)

```bash
cd WebApp5ByAnurag
docker build -t webapp5 .
docker run -p 8080:80 webapp5
```

## 🗄️ Database Configuration

### Update Connection Strings

Most applications use SQL Server LocalDB. Update the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=<DatabaseName>;TrustServerCertificate=True;"
  }
}
```

### Apply Migrations (for EF Core projects)

```bash
dotnet ef database update
```

### Manual Database Setup (for Console App)

Execute the following SQL to create the Products table:

```sql
CREATE DATABASE CRUDConsole;
USE CRUDConsole;

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Quantity INT NOT NULL
);
```

## 👨‍💻 Author

**Anurag Bhatri**

## 📝 Notes

- Each application is self-contained and can be run independently
- Some applications share similar concepts but demonstrate different implementation approaches
- Projects are designed for educational purposes to demonstrate various .NET web development patterns
- Database migrations may need to be applied before running applications that use Entity Framework Core

## 🤝 Contributing

This is an educational repository. Feel free to fork and experiment with the code for learning purposes.

## 📄 License

This project is created for educational purposes as part of coursework.
