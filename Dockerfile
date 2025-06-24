FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EmployeeApi/EmployeeApi.csproj", "EmployeeApi/"]
RUN dotnet restore "./EmployeeApi/EmployeeApi.csproj"
COPY . .
WORKDIR "/src/EmployeeApi"
RUN dotnet publish "EmployeeApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "EmployeeApi.dll"]