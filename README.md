Device Management System
This project is a web application developed to manage device assignments to personnel. Using SQL Server and .NET Core MVC technologies, you can track device and personnel records and easily view which personnel are assigned to which devices. Basic CRUD operations in the project are implemented using Entity Framework Core.

Project Summary
Device Management: Registering, updating, and deleting device records.

Personnel Management: Managing personnel information and organizing them by departments.

Device Assignment: Assigning available devices to personnel and obtaining information about assigned devices.

Device Status: Checking whether devices are assigned or unassigned.

Technologies Used
Back-end: ASP.NET Core MVC

ORM: Entity Framework Core

Database: SQL Server

Front-end: Razor View

Diagrams & Charts: Charts are used to visualize the distribution of personnel and devices.

This project works with a SQL Server .bacpac file. To run the project properly, you need to restore the database backup into SQL Server.
Once the database is successfully restored, update the ConnectionStrings section in the appsettings.json file with your database connection information.

Only users with admin privileges can log in to the system. A pre-created admin user is available in the database. You can use these credentials for the first login.

