#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["test/NeoCA.API.IntegrationTests/NeoCA.API.IntegrationTests.csproj", "test/NeoCA.API.IntegrationTests/"]
COPY ["src/Infrastructure/NeoCA.Persistence/NeoCA.Persistence.csproj", "src/Infrastructure/NeoCA.Persistence/"]
COPY ["src/Core/NeoCA.Application/NeoCA.Application.csproj", "src/Core/NeoCA.Application/"]
COPY ["src/Core/NeoCA.Domain/NeoCA.Domain.csproj", "src/Core/NeoCA.Domain/"]
COPY ["src/API/NeoCA.Api/NeoCA.Api.csproj", "src/API/NeoCA.Api/"]
COPY ["src/Infrastructure/NeoCA.Infrastructure/NeoCA.Infrastructure.csproj", "src/Infrastructure/NeoCA.Infrastructure/"]
COPY ["src/Infrastructure/NeoCA.Identity/NeoCA.Identity.csproj", "src/Infrastructure/NeoCA.Identity/"]
RUN dotnet restore "test/NeoCA.API.IntegrationTests/NeoCA.API.IntegrationTests.csproj"
COPY . .
WORKDIR "/src/test/NeoCA.API.IntegrationTests"
RUN dotnet build "NeoCA.API.IntegrationTests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NeoCA.API.IntegrationTests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NeoCA.API.IntegrationTests.dll"]
