# dockerapi
1. Download or clone the project 
2. Use visual studio code latest version and dotnet core 6.0
3. Run the project from terminal by comman dotnet build and then dotnet run 
4. or you can debug by visual studio 
5. Should docker install to your device and login to docker destop , actually we will need docker id for deploy to docker , otherwise you will need to login during docker run from terminal 
6. run the command to your terminal => docker run --rm -v ${pwd}:c:\app -w c:\app mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -c Release -o out
7. run the command to your terminal =>    docker build -t yourdockerid/dockerapi
8. run the command to your terminal =>  docker run -p 8080:80 yourdockerid/dockerapi
9. if you want to push to your docker repository, then run the command to your terminal => docker push smhafizurrahman/dockerapi

 
