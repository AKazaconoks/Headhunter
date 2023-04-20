#Headhunter API
Headhunter is an ASP.NET Core Web API application designed to manage candidates, companies, positions, and skill sets in the context of job recruitment. The application provides a set of RESTful endpoints to create, read, update, and delete (CRUD) resources.

#Features
Manage Candidates, Companies, Positions, and Skill Sets
RESTful API design
Entity Framework Core for database interactions
Swagger UI for API documentation and testing
API Endpoints
The API provides several controllers, each responsible for managing a specific resource:

CandidateController: Manages candidate resources, including related skill sets.
CompanyController: Manages company resources, including related positions.
PositionController: Manages position resources, including filtering by company.
SkillSetController: Manages skill set resources, including filtering by candidate.
#Swagger UI
Headhunter API includes Swagger UI, an interactive documentation tool for testing and exploring the API. Once the API is running, navigate to the /swagger endpoint to access the Swagger UI. The Swagger UI will display a list of available API endpoints and allow you to test each one by providing the required input parameters and displaying the API's responses.
