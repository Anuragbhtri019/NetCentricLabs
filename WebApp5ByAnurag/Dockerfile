# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy everything and restore dependencies
COPY . .
RUN dotnet restore "WebApp5ByAnurag.csproj"
RUN dotnet publish "WebApp5ByAnurag.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use a smaller runtime image for the final build
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "WebApp5ByAnurag.dll"]
