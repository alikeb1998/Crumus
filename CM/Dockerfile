FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CM/CM.csproj", "CM/"]
RUN dotnet restore "CM/CM.csproj"
COPY . .
WORKDIR "/src/CM"
RUN dotnet build "CM.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CM.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CM.dll"]
