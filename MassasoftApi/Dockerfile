# Base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory
WORKDIR /app


# Copy the rest of the code
COPY . .

RUN dotnet dev-certs https

RUN dotnet run DevOpsExamApi/DevOpsExamApi.csproj




# Set the entry point
ENTRYPOINT ["dotnet", "DevOpsExamApi.dll"]
