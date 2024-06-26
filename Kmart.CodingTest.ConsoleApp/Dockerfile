#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Kmart.CodingTest.ConsoleApp/Kmart.CodingTest.ConsoleApp.csproj", "Kmart.CodingTest.ConsoleApp/"]
RUN dotnet restore "Kmart.CodingTest.ConsoleApp/Kmart.CodingTest.ConsoleApp.csproj"
COPY . .
WORKDIR "/src/Kmart.CodingTest.ConsoleApp"
RUN dotnet tool install -g dotnet-format
ENV PATH="${PATH}:/root/.dotnet/tools"
RUN dotnet format --check --verbosity diagnostic
RUN dotnet build "Kmart.CodingTest.ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kmart.CodingTest.ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kmart.CodingTest.ConsoleApp.dll"]
