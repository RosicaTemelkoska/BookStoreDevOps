# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Копирај го целиот изворен код
COPY . .

# Влези во Bookstore.Web и направи publish
WORKDIR /src/app/Bookstore.Web
RUN dotnet publish Bookstore.Web.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Bookstore.Web.dll"]
