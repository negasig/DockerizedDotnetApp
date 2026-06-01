FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:latest AS runtime
WORKDIR /app
COPY --from=build /app/out ./
EXPOSE 8058
CMD ["dotnet", "DockerizedApp.dll"]