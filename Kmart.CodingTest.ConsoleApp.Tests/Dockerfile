#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build

WORKDIR /src
COPY ["Kmart.CodingTest.ConsoleApp.Tests/Kmart.CodingTest.ConsoleApp.Tests.csproj", "Kmart.CodingTest.ConsoleApp.Tests/"]
COPY ["Kmart.CodingTest.ConsoleApp/Kmart.CodingTest.ConsoleApp.csproj", "Kmart.CodingTest.ConsoleApp/"]
RUN dotnet restore "Kmart.CodingTest.ConsoleApp.Tests/Kmart.CodingTest.ConsoleApp.Tests.csproj"
COPY . .
WORKDIR "/src/Kmart.CodingTest.ConsoleApp.Tests"

ENTRYPOINT ["dotnet", "test"]
