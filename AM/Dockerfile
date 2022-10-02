FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AM/AM.csproj", "AM/"]
RUN dotnet restore "AM/AM.csproj"
COPY . .
WORKDIR "/src/AM"
RUN dotnet build "AM.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AM.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AM.dll"]
