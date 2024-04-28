#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Development
WORKDIR /src
COPY Netcore.Abstraction/*.csproj ./Netcore.Abstraction/
COPY Netcore.ActivoFijo/*.csproj ./Netcore.ActivoFijo/
COPY Netcore.Web.Api/*.csproj ./Netcore.Web.Api/

RUN dotnet restore ./Netcore.Web.Api/Netcore.Web.Api.csproj

COPY . .
WORKDIR "/src/Netcore.Web.Api"
RUN dotnet build "./Netcore.Web.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Development
RUN dotnet publish "./Netcore.Web.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Netcore.Web.Api.dll"]
ENV ASPNETCORE_ENVIRONMENT=Development
