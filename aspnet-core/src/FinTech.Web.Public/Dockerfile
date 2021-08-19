#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/FinTech.Web.Public/FinTech.Web.Public.csproj", "src/FinTech.Web.Public/"]
COPY ["src/FinTech.Web.Core/FinTech.Web.Core.csproj", "src/FinTech.Web.Core/"]
COPY ["src/FinTech.Application/FinTech.Application.csproj", "src/FinTech.Application/"]
COPY ["src/FinTech.Application.Shared/FinTech.Application.Shared.csproj", "src/FinTech.Application.Shared/"]
COPY ["src/FinTech.Core.Shared/FinTech.Core.Shared.csproj", "src/FinTech.Core.Shared/"]
COPY ["src/FinTech.Core/FinTech.Core.csproj", "src/FinTech.Core/"]
COPY ["src/FinTech.EntityFrameworkCore/FinTech.EntityFrameworkCore.csproj", "src/FinTech.EntityFrameworkCore/"]
COPY ["src/FinTech.GraphQL/FinTech.GraphQL.csproj", "src/FinTech.GraphQL/"]
RUN dotnet restore "src/FinTech.Web.Public/FinTech.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/FinTech.Web.Public"
RUN dotnet build "FinTech.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinTech.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinTech.Web.Public.dll"]
