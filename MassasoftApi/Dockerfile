# Base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory
WORKDIR /app

# Install k6
RUN apt-get update && apt-get install -y \
    ca-certificates \
    && apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 379CE192D401AB61 \
    && echo "deb https://dl.bintray.com/loadimpact/deb stable main" | tee -a /etc/apt/sources.list \
    && apt-get update && apt-get install -y k6


# Copy the rest of the code
COPY . .

RUN dotnet dev-certs https

RUN dotnet run DevOpsExamApi/DevOpsExamApi.csproj




# Set the entry point
ENTRYPOINT ["dotnet", "DevOpsExamApi.dll"]
