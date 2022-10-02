FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AAA/AAA.csproj", "AAA/"]
RUN dotnet restore "AAA/AAA.csproj"
COPY . .
WORKDIR "/src/AAA"
RUN dotnet build "AAA.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AAA.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AAA.dll"]
