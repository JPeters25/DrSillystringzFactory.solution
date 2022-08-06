# _Dr Sillystringz's Factory_

#### By _**Justin Peters**_

#### This Browser Application will allow the user to add Engineers they hired and assign Machines to the Engineers. Also allows user to Edit, Delete Engineers and Machines.

## Technologies Used

* CSHTML
* CSS
* Markdown
* Entity Framework
* C#
* dotnet
* SQL Database

## Description
### _Week 11 Code Review_
You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

## Setup/Installation Requirements

* Clone or download repository to local machine
* Run touch appsettings.json and add the following lines :

* _{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[first_last];uid=root;pwd=[password];" } }_

* _Note_: _[first_last] should be replaced with your own database name and [password] should be replaced with your password. Do not include the brackets._

*Navigate to Factory directory in your Console and run dotnet ef migratations add "{insert text here}" 

* Run dotnet restore, dotnet build, and dotnet run to run web application.

## Known Bugs

* Does not display Machine and Engineer on same Splash Page


## License

_MIT_

Copyright(c) July 2022 (c)Justin Peters

