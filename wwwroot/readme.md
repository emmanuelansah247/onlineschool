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


