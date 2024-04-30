FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
# EXPOSE 443

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

# Copiar certificado SSL generado en Digital Ocean
# COPY ./cert/apache-selfsigned.crt /app/apache-selfsigned.crt
# COPY ./cert/apache-selfsigned.key /app/apache-selfsigned.key

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="password"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/app/apache-selfsigned.pfx"


# Crear archivo PFX a partir del certificado y la clave
# RUN openssl pkcs12 -export -out /app/apache-selfsigned.pfx -inkey /app/apache-selfsigned.key -in /app/apache-selfsigned.crt -password pass:password

# EXPOSE 443

ENTRYPOINT ["dotnet", "Netcore.Web.Api.dll"]
ENV ASPNETCORE_ENVIRONMENT=Development