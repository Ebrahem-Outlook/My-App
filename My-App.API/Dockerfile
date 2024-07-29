#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["My-App.API/My-App.API.csproj", "My-App.API/"]
COPY ["My-App.Infrastructure/My-App.Infrastructure.csproj", "My-App.Infrastructure/"]
COPY ["My-App.Application/My-App.Application.csproj", "My-App.Application/"]
COPY ["My-App.Domain/My-App.Domain.csproj", "My-App.Domain/"]
RUN dotnet restore "./My-App.API/My-App.API.csproj"
COPY . .
WORKDIR "/src/My-App.API"
RUN dotnet build "./My-App.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./My-App.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "My-App.API.dll"]