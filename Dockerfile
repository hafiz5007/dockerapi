#Get base SDK Image from microsoft
From mcr.microsoft.com/dotnet/sdk:6.0 as build-env 
WORKDIR /app

#docker run --rm -v ${pwd}:c:\app -w c:\app mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -c Release -o out


#Copy the CSPROJ file and restore any dependencies 
COPY *.csproj ./
RUN dotnet restore

# Copy the project files and build our release 
COPY . ./
RUN dotnet publish -c Release -o out 
#--no-restore


# Generate runtime image 
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env  /app/out .
#COPY --from=build /app .
ENTRYPOINT ["dotnet", "DockerAPI.dll"]



