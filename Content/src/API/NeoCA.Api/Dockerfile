#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/API/NeoCA.Api/NeoCA.Api.csproj", "src/API/NeoCA.Api/"]
COPY ["src/Infrastructure/NeoCA.Infrastructure/NeoCA.Infrastructure.csproj", "src/Infrastructure/NeoCA.Infrastructure/"]
COPY ["src/Core/NeoCA.Application/NeoCA.Application.csproj", "src/Core/NeoCA.Application/"]
COPY ["src/Core/NeoCA.Domain/NeoCA.Domain.csproj", "src/Core/NeoCA.Domain/"]
COPY ["src/Infrastructure/NeoCA.Identity/NeoCA.Identity.csproj", "src/Infrastructure/NeoCA.Identity/"]
COPY ["src/Infrastructure/NeoCA.Persistence/NeoCA.Persistence.csproj", "src/Infrastructure/NeoCA.Persistence/"]
RUN dotnet restore "src/API/NeoCA.Api/NeoCA.Api.csproj"
COPY . .
WORKDIR "/src/src/API/NeoCA.Api"
RUN dotnet build "NeoCA.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NeoCA.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NeoCA.Api.dll"]
