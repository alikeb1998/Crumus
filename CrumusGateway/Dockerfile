FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Crumus/Crumus.csproj", "Crumus/"]
RUN dotnet restore "Crumus/Crumus.csproj"
COPY . .
WORKDIR "/src/Crumus"
RUN dotnet build "Crumus.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crumus.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crumus.dll"]
