# C# Development Course - Complete Workspace

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-0078D4?style=for-the-badge&logo=microsoft&logoColor=white)
![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-512BD4?style=for-the-badge&logo=microsoft&logoColor=white)

## 📋 Table of Contents

- [Overview](#overview)
- [Repository Structure](#repository-structure)
- [Technologies Used](#technologies-used)
- [Projects Overview](#projects-overview)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Key Learning Areas](#key-learning-areas)
- [Project Highlights](#project-highlights)
- [Documentation](#documentation)
- [Contributing](#contributing)
- [License](#license)

## 🎯 Overview

This repository contains a comprehensive collection of C# and .NET development projects, spanning from basic console applications to advanced web APIs and React frontends. The workspace demonstrates progressive learning through practical implementations of modern software development patterns and technologies.

## 📁 Repository Structure

```
CourseCSHARP/
├── 📚 Documentation/
│   ├── MuitosParaMuitos.docx          # Many-to-Many relationships guide
│   └── WebApi Essential.docx          # Web API essentials documentation
├── 🚀 Early Projects (20250703-04)/
│   ├── FirstMVC/                      # First MVC application
│   ├── Session01FirstSteps/           # Initial C# steps
│   └── MiniCaixaEletronico*/          # ATM simulation projects
├── 🏗️ Core Development (20250707-11)/
│   ├── ContaBancaria/                 # Banking system
│   ├── ClinicaApp/                    # Clinic management system
│   ├── SessionEntity/                 # Entity Framework sessions
│   ├── Challenge/                     # Programming challenges
│   └── MiniCatalogo/                  # Product catalog
├── 🌐 Web APIs (20250714-18)/
│   ├── ApiCatalogo/                   # Catalog API
│   ├── TesteApi/                      # API testing
│   ├── BookStore/                     # Book store management
│   └── GerenciadorDeProjetos/         # Project management system
├── 🎨 Frontend Development (20250721-24)/
│   ├── HTML/                          # William's Travels website
│   ├── MinhaApi/                      # API with React frontend
│   ├── REACTJS/                       # React learning projects
│   ├── app-react/                     # React task management
│   └── app-movie/                     # Movie browsing app
└── 📝 Notes/
    ├── notebook.txt                   # Development notes
    └── notebook.md                    # Markdown documentation
```

## 🛠️ Technologies Used

### Backend Technologies

- **C# 12** - Primary programming language
- **.NET 8** - Framework for application development
- **ASP.NET Core** - Web framework for APIs and MVC applications
- **Entity Framework Core** - ORM for database operations
- **SQL Server** - Database management system
- **Swagger/OpenAPI** - API documentation and testing

### Frontend Technologies

- **React 18** - JavaScript library for building user interfaces
- **HTML5 & CSS3** - Web markup and styling
- **JavaScript ES6+** - Modern JavaScript features
- **Vite** - Build tool for React applications
- **Axios** - HTTP client for API requests

### Development Tools & Patterns

- **Repository Pattern** - Data access abstraction
- **Unit of Work Pattern** - Transaction management
- **Dependency Injection** - Service container management
- **MVC Architecture** - Model-View-Controller pattern
- **RESTful APIs** - Web service architecture
- **Entity Relationships** - One-to-Many, Many-to-Many

## 📊 Projects Overview

### 🎯 Beginner Level Projects

#### Mini Caixa Eletrônico (ATM Simulation)

- **Location**: [`20250704/MiniCaixaEletronico*/`](20250704/)
- **Description**: Console-based ATM simulation with multiple variations
- **Features**: Account management, transactions, balance inquiry
- **Technologies**: C#, Console Application

#### Conta Bancária (Banking System)

- **Location**: [`20250707/ContaBancaria/`](20250707/ContaBancaria/)
- **Description**: Object-oriented banking system
- **Features**: Account creation, deposits, withdrawals, statements
- **Technologies**: C#, OOP principles

### 🏗️ Intermediate Level Projects

#### Clínica App (Clinic Management)

- **Location**: [`20250708/ClinicaApp/`](20250708/ClinicaApp/)
- **Description**: Web application for clinic appointment management
- **Features**: Patient management, appointment scheduling, MVC architecture
- **Technologies**: ASP.NET Core MVC, Entity Framework

#### API Catálogo (Catalog API)

- **Location**: [`20250714/ApiCatalogo/`](20250714/ApiCatalogo/)
- **Description**: RESTful API for product catalog management
- **Features**: CRUD operations, category management, Swagger documentation
- **Technologies**: ASP.NET Core Web API, Entity Framework, SQL Server

### 🚀 Advanced Level Projects

#### Gerenciador de Projetos (Project Manager)

- **Location**: [`20250718/GerenciadorDeProjetos/`](20250718/GerenciadorDeProjetos/)
- **Description**: Complete project management system with API and tests
- **Features**:
  - Repository and Unit of Work patterns
  - Product and category management
  - API controllers with async operations
  - Unit testing with xUnit
- **Technologies**: ASP.NET Core Web API, Entity Framework, xUnit, Repository Pattern

```csharp
// Example from ProdutosController
[HttpPost]
public async Task<IActionResult> CriarProduto([FromBody] CriarProdutoDto produtoDto)
{
    // Business logic implementation
    await _uow.ProdutoRepository.AddAsync(produto);
    await _uow.CommitAsync();
    return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produtoResultDto);
}
```

#### William's Travels Website

- **Location**: [`20250721/HTML/`](20250721/HTML/)
- **Description**: Modern travel booking website with responsive design
- **Features**: Package search, promotions, newsletter, interactive UI
- **Technologies**: HTML5, CSS3, Responsive Design

#### Movie Browser App

- **Location**: [`20250723/app-movie/`](20250723/app-movie/)
- **Description**: React application for browsing popular movies
- **Features**: TMDB API integration, movie cards, responsive layout
- **Technologies**: React, Vite, API integration

```jsx
// Example from App.jsx
const [filmes, setFilmes] = useState([]);

useEffect(() => {
  async function fetchFilmes() {
    const response = await fetch(API_URL_POPULARES);
    const data = await response.json();
    setFilmes(data.results);
  }
  fetchFilmes();
}, []);
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js 18+](https://nodejs.org/) (for React projects)
- [SQL Server](https://www.microsoft.com/sql-server) or SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**

   ```bash
   git clone <repository-url>
   cd CourseCSHARP
   ```

2. **For .NET Projects**

   ```bash
   cd <project-folder>
   dotnet restore
   dotnet build
   dotnet run
   ```

3. **For React Projects**

   ```bash
   cd <react-project-folder>
   npm install
   npm start
   ```

4. **Database Setup** (for projects using Entity Framework)
   ```bash
   dotnet ef database update
   ```

## 📚 Key Learning Areas

### 🎯 Object-Oriented Programming

- Classes and objects
- Inheritance and polymorphism
- Encapsulation and abstraction
- SOLID principles

### 🌐 Web Development

- **ASP.NET Core MVC**: Model-View-Controller architecture
- **Web APIs**: RESTful service development
- **Entity Framework**: ORM and database operations
- **Dependency Injection**: Service container patterns

### 🗄️ Data Access Patterns

- **Repository Pattern**: [`GerenciadorDeProjetos/Repositories/`](20250718/GerenciadorDeProjetos/GerenciadorDeProjetos/Repositories/)
- **Unit of Work**: Transaction management
- **Entity Relationships**: One-to-Many, Many-to-Many

### ⚛️ Frontend Development

- **React Fundamentals**: Components, hooks, state management
- **Modern JavaScript**: ES6+, async/await, modules
- **UI/UX**: Responsive design, CSS Grid/Flexbox

### 🧪 Testing

- **Unit Testing**: xUnit framework
- **API Testing**: Integration tests
- **Test-Driven Development**: TDD practices

## 🌟 Project Highlights

### 📊 API Development

The [`ApiCatalogo`](20250714/ApiCatalogo/) and [`GerenciadorDeProjetos`](20250718/GerenciadorDeProjetos/) projects showcase:

- Clean architecture principles
- Async/await patterns
- Repository and Unit of Work patterns
- Comprehensive API documentation with Swagger

### 🎨 Frontend Integration

The [`MinhaApi/frontend`](20250722/MinhaApi/frontend/) demonstrates:

- React consumption of .NET APIs
- Modern UI components
- Error handling and loading states
- Responsive design principles

### 🏗️ Enterprise Patterns

Advanced projects implement:

- Dependency injection
- Service layer architecture
- Data transfer objects (DTOs)
- Entity mapping strategies

## 📖 Documentation

### Key Documents

- [`MuitosParaMuitos.docx`](MuitosParaMuitos.docx) - Entity relationships guide
- [`WebApi Essential.docx`](WebApi%20Essential.docx) - Web API development essentials
- [`notebook.md`](20250715/notebook.md) - BookStore project requirements

### Code Examples

Each project includes comprehensive inline documentation and follows C# coding conventions.

## 🤝 Contributing

This is a learning repository. To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is for educational purposes. Individual components may have their own licenses as indicated in their respective directories.

## 📞 Contact

For questions or suggestions regarding this learning journey, please create an issue in the repository.

---

**Happy Coding! 🚀**

_This repository represents a comprehensive journey through modern C# and .NET development, from basic console applications to full-stack web applications._
