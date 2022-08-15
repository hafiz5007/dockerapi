# dockerapi
1. Download or clone the project 
2. Use visual studio code latest version and dotnet core 6.0
3. Run the project from terminal by command 'dotnet build' and then 'dotnet run' 
4. or you can debug by visual studio 
5. Should docker install to your device and login to docker destop , actually we will need docker id for deploy to docker , otherwise you will need to login during docker run from terminal 
6. run the command to your terminal => docker run --rm -v ${pwd}:c:\app -w c:\app mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -c Release -o out
7. run the command to your terminal =>    docker build -t yourdockerid/dockerapi .
8. run the command to your terminal =>  docker run -p 8080:80 yourdockerid/dockerapi
9. if you want to push to your docker repository, then run the command to your terminal => docker push smhafizurrahman/dockerapi
10. After adding model and update Customer model and context
 11. Execute dotnet ef migrations add CustomerModel  
 12. run for download MS SQL server to Docker =>   docker run -e 'Accept_EULA=Y' -e "SA_PASSWORD=yourpassword" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
13. Then execute =>  dotnet build , check your MS SQL server, the database and customer table will create automatically and check the demo data in the table 
14. Then Exxecute for the docker run =>  docker build -t yourdockerid/dockerapi .
15. docker run -p 8080:80 yourdockerid/dockerapi
16.  docker-compose up 
