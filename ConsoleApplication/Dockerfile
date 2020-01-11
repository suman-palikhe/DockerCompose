#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ConsoleApplication.csproj", "ConsoleApplication/"]

WORKDIR /src/ConsoleApplication
COPY . .

#RUN dotnet restore "ConsoleApplication/ConsoleApplication.csproj"

#RUN dotnet build "ConsoleApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApplication.csproj" -c Release -o out

FROM base AS final
WORKDIR /app
COPY --from=publish src/ConsoleApplication/out .
ENTRYPOINT ["dotnet", "ConsoleApplication.dll"]