
## Docker va a obtener esta imagen
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

## Nombre de la aplicacion
WORKDIR TestApp


EXPOSE 80
EXPOSE 5024

# COPY PROJECT FILES
COPY ./*.csproj ./
RUN dotnet restore

# COPY EVERTHING ELSE
COPY . .
RUN dotnet publish -c Release -o out

# Build Image
FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /webapp
COPY --from=build /webapp/out .
ENTRYPOINT ["dotnet", "DockerDotNetApp.dll"]







