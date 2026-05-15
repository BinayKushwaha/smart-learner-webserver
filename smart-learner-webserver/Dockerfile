# Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy all project files first (for layer caching)
COPY ["smart-learner-webserver/smart-learner-webserver.csproj", "smart-learner-webserver/"]
COPY ["smart-learner.Application/smart-learner.Application.csproj", "smart-learner.Application/"]
COPY ["smart-learner.infrastructure/smart-learner.infrastructure.csproj", "smart-learner.infrastructure/"]

RUN dotnet restore "smart-learner-webserver/smart-learner-webserver.csproj"

# Copy all source code
COPY . .

RUN dotnet build "smart-learner-webserver/smart-learner-webserver.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "smart-learner-webserver/smart-learner-webserver.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "smart-learner-webserver.dll"]