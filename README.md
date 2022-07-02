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

1. The database for this project is BIM_EDU
2. The databse is stored on amazon rds



<b>NOTE<b>
To get all database name in a sql server use: SELECT name FROM sys.databases

To add database migration use: DOTNET EF MIGRATIONS ADD INITIAL

To update database with Entity Framework Tables use: DOTNET EF DATABASE UPDATE

To publish the Bim-Edu Web App use: dotnet publish --configuration -release -o bin/bim-edu

A Default Certifcation And Programme Needs To Setup Before The Use Of The Application

//Access To Folder
1. chmod -R 777 [folderpath]

//copy table from one database to another
1. select * into [databasename].[schema].[tablename] from [tablename]
        default [schema] can be 'dbo';


//TO SERVE ENABLE A WEBSITE USE AND ADD LINK FOR NGINX TO DETECT
3. sudo ln -s /etc/nginx/sites-available/[websiteName] /etc/nginx/sites-enabled/


//RESTART SERVER AFTER ENABLING or EDITING A WEBSITE
4. sudo systemctl reload nginx

<b>NOTE<b>
You Can Find The System Service Running Bim-Edu at this location
/etc/systemd/system/kestrel-bim-edu.service

5. To Stop The Kestrel Service For bim-edu
    systemctl stop kestrel-bim-edu.service

6. To Start The Kestrel Service For bim-edu
    systemctl start kestrel-bim-edu.service


//PUBLISHING 
1. dotnet publish --configuration -release -o bin/bim-edu

//HTTPS
1. sudo certbot --nginx

//MAKING FOLDER ACCESSIBLE
1. sudo chmod -R 777 [foldername path]


