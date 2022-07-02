## Online School Website

#### Description
This project can be used as a website for school. This project is in two languages: English and French.
Student can register , select a program and make online payment. After registration is complete, student 
can login to the website dashboard where they can access their program materials. They have a section too that 
allows students to interact with each like a chatbox. The application also have a section for lecturers to upload 
documents and teaching materials. A super admin can approve student for a program or not. A super admin can also register 
both students and lecturers. A super admin can assign lecturers to a program as well. A super admin can also manage fees for students as well. 
The application works as an online school system.


#### Stack
1. C#
2. .net core (2.1) and entity framework (2.1 )
3. Microsoft Sequel Server
4. Html
5. Css
6. Javascript
7. Css

#### Pre requisite for the project (Windows)

1. Download and install .net core 3.5 

2. Download and install .net core 

you can download the .net core sdk and runtime from this link
https://download.microsoft.com/download/f/c/1/fc16c864-b374-4668-83a2-f9f880928b2d/dotnet-sdk-2.1.202-win-x64.exe

You need to install the following from the windows package manager
1. Microsoft.AspNetCore.Razor.Design (2.1.2)
2. Microsoft.EntityframeworkCore.Design (2.1.2)
3. Microsoft.EntityframeworkCore.Sqlserver (2.1.2)


#### Setting up the database for the application
You need to have microsoft sql server installed. Create a database [name_of_database]. When you are done creating the database, you need to update the connectionstring in the
the appsettings.json file
]Server=[name_of_server];User Id=[user_id[;Initial Catalog=[database_name]; Password=[password_to_the_server];

Running The Application
You can run the application using microsoft visual studio (By clicking run )

or if you are using visual studio code, you can type following the command prompt or console

    dotnet run
    
#### Setting up the email service
I created a node service for the email. You can create your own email and implement it in the application. But the application can still run without the 
email service
