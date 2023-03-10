# _Eau Claire Hair Salon_

#### By Eliot Gronstal

#### _An MVC web application to help a salon manage employees (stylists) and clients. Independent Project for Week 3 of C# at Epicodus Coding School._

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _MVC_
* _SQL Workbench_
* _Entity Framework_
* _HTML_

## Description

The owner of a hair salon called Eau Claire's Salon contracted out the creation of an MVC web application to help manage  employees (stylists) and clients. The owner can add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see a single stylist.

__App Features:__
* _The owner can see a list of all stylists._
* _The owner can select a stylist, see their details, and see a list of all clients that belong to that stylist._
* _The owner can add new stylists to the system when they are hired._
* _The owner can add new clients to a specific stylist. It is not possible to add a client if no stylists have been added._

__Project Schema:__
[project_schema]<imgsrc=/Users/eliotgronstal/Desktop/Epicodus/EauClaireSalon.Solution/HairSalon/wwwroot/images/HairSalon_Schema.png>

## Setup/Installation Requirements

* _Clone this repo._
* _Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "ProjectName"._
* _In the command line, run the command ``dotnet run`` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal._
* _Optionally, you can run ``dotnet build`` to compile this console app without running it._
* _This program was built using `Microsoft .NET SDK 6.0`, and may not be compatible with other versions._

* _If you want to run the project in production mode with a watcher, you can use a command line flag to specify that you want to run the "production" profile. ``dotnet watch run --launch-profile "production"``_
*  _Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)_

## SQL Workbench Configuration
* _Create an `appsetting.json` file in the "ProjectName" directory of the project._
* _Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL._ 
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[PROJECT-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* _If you'd like to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore first._
* _Once "appsettings.json" file has been created, navigate back to SQL Workbench._ 
* _Import the database named ``"project_name.sql"`` from the root directory of the project._ 

## Database Import Instructions

* _Open SQL workbench._
* _Navigate to the "Administration" tab in SQL Workbench._
* _Click ``"Data Import/Restore"``_
* _Select the radio button "Import from Self-Contained File" and include file path to the sql file of this project that has been cloned to your machine._
* _In "Default Schema to be Imported to" click "New"._
* _Name the schema ``"project_name"`` then click "OK"._
* _Once named, switch to ``"Import Progress"`` tab and click ``"Start Import"``._


## Test Instructions

* _Using a shell program, navigate from the root directory, "ClassName.Solution," to the "ClassName.Tests" directory._
* _Once in the "ClassName.Tests" directory, type ``dotnet restore`` into the console._
* _After the restore process is complete, type ``dotnet test`` into the console. This will run all written tests and display the test results into the console to review._

## Known Bugs

* _Any known issues_

* _Please reach out with any questions or concerns to [eliot.lauren@gmail.com](eliot.lauren@gmail.com)_

## License

_[MIT](https://opensource.org/license/mit/)_

Copyright (c) _2023_ _Eliot Gronstal_