How to use this: After you clone or download this project.
1. Go to folder 4.Data > WebBase.EntityFramework and delete folder Migrations.
2. Go to folder Core > WebBase.Configuration and change DbConnection to connect with your SQL Server.
3. Open Package Manager Console form Tools
4. At Default Project, make sure you choose the WebBase.EntityFramework
5. In the command lines: type add-migration <name>
6. then update-database
7. Build and run WebBase.Api
