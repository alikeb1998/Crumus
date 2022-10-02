FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OnBoarding/OnBoarding.csproj", "OnBoarding/"]
RUN dotnet restore "OnBoarding/OnBoarding.csproj"
COPY . .
WORKDIR "/src/OnBoarding"
RUN dotnet build "OnBoarding.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnBoarding.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnBoarding.dll"]
