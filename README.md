# RestApiDemo2-WebApi
A .NET console application, written in C#.

### Task

Modify "homework 6" to save app's data to the database.

Requirements:
1. Use the Mssql database.
2. SqlConnection, Dapper, Entity framework Core can be used.
3. At startup, program should check for the existence of tables in the database and the creation if none exist.
4. ConnectionString must be set in `appsettings.json`.
5. After restarting the program, the information must not change (taken from the database).

