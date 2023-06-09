# Eshop Project based on Clean architecture and Domain Driven Design

eShop project that follows Clean Architecture principles and incorporates Domain-Driven Design (DDD) patterns. The project is built on .NET 7.0 and utilizes Microsoft SQL Server for data storage. It incorporates Entity Framework Core migrations for seamless database schema evolution.

To ensure robustness and maintainability, the project employs the Command Query Responsibility Segregation (CQRS) pattern with segregated Commands and Queries. Fluent Validation is utilized within the Command classes to validate input data effectively. Additionally, the project includes authorization features through ASP.NET Core Identity, ensuring that only authorized users can access specific functionalities.

## Features

- [x] Follows Clean Architecture Principles
- [x] Follows Domain Driven Design Patterns 
- [x] Entity Framework Core migrations with Microsoft SQL Server
- [x] applies CQRS with segregated Commands and Queries
- [x] Fluent Validation of input inside the Command classes
- [x] Authorization with ASP.Net Core Identity 
- [x] Built on .NET 7.0

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on.

### WebUI

This layer is a WebAPI Application based on  ASP.NET Core 7. This layer depends on both the Application and Infrastructure layers
