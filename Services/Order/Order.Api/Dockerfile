#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Order/Order.Api/Order.Api.csproj", "Services/Order/Order.Api/"]
COPY ["Services/Order/Order.Api.Service/Order.Api.Service.csproj", "Services/Order/Order.Api.Service/"]
COPY ["Services/Order/Order.Api.Infrastructure/Order.Api.Infrastructure.csproj", "Services/Order/Order.Api.Infrastructure/"]
COPY ["Services/Order/Order.Api.Models/Order.Api.Models.csproj", "Services/Order/Order.Api.Models/"]
RUN dotnet restore "Services/Order/Order.Api/Order.Api.csproj"
COPY . .
WORKDIR "/src/Services/Order/Order.Api"
RUN dotnet build "Order.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Order.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Order.Api.dll"]