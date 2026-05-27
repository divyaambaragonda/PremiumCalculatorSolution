# Premium Calculator Application
## About The Project
The application calculates monthly insurance premiums based on user details such as age, occupation, and death sum insured. The solution is built using ASP.NET Core MVC and Web API following clean architecture principles and common enterprise development practices.
The goal of this project was not only to implement the premium calculation logic, but also to demonstrate:
- MVC architecture
- API integration
- Repository pattern
- Service layer implementation
- Dependency Injection
- Error handling
- Logging
- Unit testing
- Mocking
- Clean and maintainable code structure
# Technologies Used
- ASP.NET Core MVC (.NET 8)
- ASP.NET Core Web API
- C#
- HTML
- CSS
- JavaScript
- Bootstrap
- Swagger
- xUnit
- Moq
- Serilog
# Project Structure
```text
PremiumCalculatorSolution/
│
├── PremiumCalculator.Web/              # Frontend MVC application
│
├── PremiumCalculator.API/              # Backend Web API
│
├── PremiumCalculator.Core/             # Models, interfaces, DTOs
│
├── PremiumCalculator.Infrastructure/   # Repositories and services
│
└── PremiumCalculator.Tests/            # Unit test project
```

---

# Features Implemented
## Premium Calculation
The application calculates monthly premium based on the formula provided in the assessment.

Death Premium =
(Death Cover Amount × Occupation Rating Factor × Age)
/ 1000 × 12
## Occupation Based Rating Factor
Different occupations are mapped to different rating categories and factors.
| Occupation | Rating Category | Factor |
|---|---|---|
| Doctor | Professional | 1.5 |
| Author | White Collar | 2.25 |
| Cleaner | Light Manual | 11.50 |
| Florist | Light Manual | 11.50 |
| Farmer | Heavy Manual | 31.75 |
| Mechanic | Heavy Manual | 31.75 |
| Other | Heavy Manual | 31.75 |

# Application Workflow
1. User enters all required details.
2. User selects occupation.
3. Occupation change triggers premium calculation.
4. MVC frontend sends request to Web API.
5. API processes business logic using service layer.
6. Premium amount is returned and displayed on screen.

# Design Patterns Used
## Repository Pattern
Repository pattern was used to separate occupation factor retrieval logic from business logic.
## Service Layer Pattern
Business calculations are implemented inside service classes to keep controllers lightweight and maintainable.
## Dependency Injection
ASP.NET Core built-in dependency injection was used throughout the project for loose coupling and easier testing.
# Validation
The following validations are implemented:
- All fields are mandatory
- Numeric validation for age and death sum insured
- API model validation
- Frontend validation
# Exception Handling
Global exception handling middleware was added to manage unexpected application errors gracefully.
Try-catch blocks are also implemented where required.

# Logging
Serilog was used for logging application events and exceptions.
Logs are written into log files for troubleshooting and debugging purposes.

# API Details
## Endpoint

https
POST /api/premium/calculate
## Sample Request
json
{
  "name": "John",
  "ageNextBirthday": 30,
  "dateOfBirth": "01/1995",
  "occupation": "Doctor",
  "deathSumInsured": 100000
}
## Sample Response
json
54000
# Unit Testing
Unit tests were implemented using:
- xUnit
- Moq
- FluentAssertions
Test cases include:

- Premium calculation validation
- Repository mocking
- Service layer testing

# Sample Database Design
Added seperate text file for DB scripts inside the solution
## Members Table
| Column | Type |
|---|---|
| MemberId | INT (PK) |
| Name | VARCHAR(100) |
| AgeNextBirthday | INT |
| DateOfBirth | DATE |
| Occupation | VARCHAR(50) |
| DeathSumInsured | DECIMAL(18,2) |
| MonthlyPremium | DECIMAL(18,2) |
| CreatedDate | DATETIME |
## OccupationRatings Table

| Column | Type |
|---|---|
| OccupationId | INT (PK) |
| OccupationName | VARCHAR(50) |
| Rating | VARCHAR(50) |
| Factor | DECIMAL(10,2) |

# How To Run The Project
## Step 1
Clone the repository.
bash
git clone <repository-url>
## Step 2
Open the solution using Visual Studio 2022.

## Step 3
Set multiple startup projects:
- PremiumCalculator.Web
- PremiumCalculator.API
## Step 4
Run the application.
## Step 5
Swagger UI can be accessed using:
text
https://localhost:<port>/swagger

# Assumptions
- Occupation data is static for this project.
- Database integration is mocked as per assessment requirement.
- Focus was given to clean architecture and backend structure.
# Possible Improvements
If this project were extended further, the following enhancements could be added:
- Entity Framework Core integration
- SQL Server database
- Authentication and Authorization
- Docker support
- CI/CD pipeline
- Azure deployment
- API versioning
- React or Angular frontend

# Notes

The project was developed with focus on maintainability, readability, and scalability while following standard .NET development practices.
