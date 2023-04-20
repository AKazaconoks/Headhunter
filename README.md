<h1>Headhunter API</h1>
<p>Headhunter is an ASP.NET Core Web API application designed to manage candidates, companies, positions, and skill sets in the context of job recruitment. The application provides a set of RESTful endpoints to create, read, update, and delete (CRUD) resources.</p>
<h2>Features</h2>
<ul>
  <li>Manage Candidates, Companies, Positions, and Skill Sets</li>
  <li>RESTful API design</li>
  <li>Entity Framework Core for database interactions</li>
  <li>Swagger UI for API documentation and testing</li>
</ul>
<h2>API Endpoints</h2>
<p>The API provides several controllers, each responsible for managing a specific resource:</p>
<ul>
  <li>CandidateController: Manages candidate resources, including related skill sets.</li>
  <li>CompanyController: Manages company resources, including related positions.</li>
  <li>PositionController: Manages position resources, including filtering by company.</li>
  <li>SkillSetController: Manages skill set resources, including filtering by candidate.</li>
</ul>
<h2>Swagger UI</h2>
<p>Headhunter API includes Swagger UI, an interactive documentation tool for testing and exploring the API. Once the API is running, navigate to the /swagger endpoint to access the Swagger UI. The Swagger UI will display a list of available API endpoints and allow you to test each one by providing the required input parameters and displaying the API's responses.</p>
