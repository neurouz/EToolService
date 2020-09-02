##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY ["eToolService.WebAPI/eToolService.WebAPI.csproj", "eToolService.WebAPI/"]
#RUN dotnet restore "eToolService.WebAPI/eToolService.WebAPI.csproj"
#COPY . .
#WORKDIR "/src/eToolService.WebAPI"
#RUN dotnet build "eToolService.WebAPI.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "eToolService.WebAPI.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "eToolService.WebAPI.dll"]