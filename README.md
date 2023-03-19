# The Factory

#### By John Lenz

## Technologies Used

* C#
* MySQL/MySQL Workbench
* EFCore
* CSS
* Razor HTML
* Git


## Description/Objectives
 *  An application to track machines and their engineers for a fictional factory. It gives the user the ability to assign engineers to work specific machines and add and delete them.



## Setup/Installation Requirements

* Clone the repo & in the terminal naviagte to the Factory directiory
* run these commands to install necessary dependencies:
     * $dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`
     * $dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0`
     * dotnet tool install --global dotnet-ef --version 6.0.0`


* Open MySQLWorkbench & navigate to the administration tab
* Select "Import from Self Contained File"
* Select the .sql file in the top level directory named `john_lenz_Factory` and import as a new schema with the same name 
* Select start import
* Confirm the installation was successful by reviewing any errors

## Configuration
* In the `Factory` directory, create a file called `appsettings.json`
* Enter the following code, updating the placeholders to your information:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=john_lenz;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
    }
}
```

* save and close the file.
* to run navigate to the Factory directory and in the terminal type dotnet watch run.
* open the browser in https://Localhost:5000 or https://Localhost:5001 

## Known Bugs

* _There are no known issues_

## License

 Copyright (C) 2007 Free Software Foundation, Inc. <https://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.
 
Copyright (c) _2023_ _John Lenz_