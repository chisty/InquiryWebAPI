# `InquiryWebAPI Service`
This is a very basic asp.net core project (using .Net Core 2.1, xUnit, Swagger, SQL Server). The goal is to build a .Net Core service with unit tests.

The API has these functionalities:
* There is two tables in database (`Customers`, `Transactions`). SQL script is included in `sql` folder.
* The CustomersController API facilitates a service to get the customer data.
* The API responses according to the request and also validates the request data.

There are 2 projects in this solution:
* `InquiryWebAPI`
* `InquiryWebAPI.Tests`

# `InquiryWebAPI`

The `CustomersController` uses a `CustomerService` which actually performs the business logic. This service is registered as a `Scoped` service in `Startup.cs` class. It is registered by the `ICustomerService` interface and exposes only 2 methods (`GetCustomerByEmail`, `GetCustomerById`). 

All the validation is handled by implementing a custom action filter named `CustomValidationFilter.cs`.  It validates the request payload criteria and set appropriate `Http.StatusCodes` with error messages.

Since the database tables have foreign key relationships I have added a `JsonOption` to ignore `ReferenceLoopHandling` in `Startup.cs` file's `ConfigureServices` method. Also, another `JsonOption` is added for displaying the `Datetime` value in a certain format. I have scaffold the DbModels from the SQL Server database to this project.

Additionally, `Swagger` is added to this project.

# `InquiryWebAPI.Tests`
There are 3 test files in this project:
*  **CustomValidationFilterTest**  (Tests the custom validation filter. All the exception case with proper `Http.StatusCodes` along with error messages)
*  **CustomerServiceTest** (Tests the scoped service. I have created a `Factory` class named `FakeDbContextFactory` who creates a `InMemory` database with seed data for test purpose)
*  **CustomersControllerTest** (Tests the API Controller class)

There are total `16` test cases in these files.

# `Tools`

Visual Studio 2017, SQL Server 2014, ASP.NET Core Web API 2.1, Swagger, xUnit.