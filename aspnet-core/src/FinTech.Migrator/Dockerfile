#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/FinTech.Migrator/FinTech.Migrator.csproj", "src/FinTech.Migrator/"]
COPY ["src/FinTech.EntityFrameworkCore/FinTech.EntityFrameworkCore.csproj", "src/FinTech.EntityFrameworkCore/"]
COPY ["src/FinTech.Core/FinTech.Core.csproj", "src/FinTech.Core/"]
COPY ["src/FinTech.Core.Shared/FinTech.Core.Shared.csproj", "src/FinTech.Core.Shared/"]
RUN dotnet restore "src/FinTech.Migrator/FinTech.Migrator.csproj"
COPY . .
WORKDIR "/src/src/FinTech.Migrator"
RUN dotnet build "FinTech.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinTech.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinTech.Migrator.dll"]
