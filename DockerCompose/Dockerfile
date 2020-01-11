#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DockerCompose.csproj", "DockerCompose/"]
#RUN dotnet restore "DockerCompose/DockerCompose.csproj"

WORKDIR /app/src/DockerCompose

COPY . .

RUN dotnet build "DockerCompose.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerCompose.csproj" -c Release -o out -r linux-x64 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/src/DockerCompose/out .

ENV ASPNETCORE_URLS http://*:6500
EXPOSE 6500

ENTRYPOINT ["dotnet", "DockerCompose.dll"]