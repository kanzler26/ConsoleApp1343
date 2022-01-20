#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ConsoleApp1343/ConsoleApp1343.csproj", "ConsoleApp1343/"]
RUN dotnet restore "ConsoleApp1343/ConsoleApp1343.csproj"
COPY . .
WORKDIR "/src/ConsoleApp1343"
RUN dotnet build "ConsoleApp1343.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp1343.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp1343.dll"]