# Base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory
WORKDIR /app

# Copy the rest of the code
COPY . .

RUN dotnet run MassasoftApiTest/MassasoftApiTest.csproj
#
## Build the app
#RUN dotnet publish -c Release -o out
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:5.0
#
## Set the working directory
#WORKDIR /app/MassasoftApiTest
#
## Copy the published output from the previous build
#COPY --from=build-env /app/out .
#
## Install Flyway
#RUN apt-get update && \
    #apt-get install -y wget && \
    #wget -qO- https://repo1.maven.org/maven2/org/flywaydb/flyway-commandline/7.15.0/flyway-commandline-7.15.0-linux-x64.tar.gz | tar xvz && \
    #ln -s /app/flyway-7.15.0/flyway /usr/local/bin/flyway
#
## Copy the database migration scripts
##COPY ./MassasoftApi/db/migrations /migrations
#
## Set the entry point
#ENTRYPOINT ["dotnet", "MassasoftApiTest.csproj"]
#