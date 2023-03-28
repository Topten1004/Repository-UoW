FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/presentation/Sample.WebApi/Sample.WebApi.csproj", "Sample.WebApi/"]
RUN dotnet restore "src/presentation/Sample.WebApi/Sample.WebApi.csproj"
COPY . .
WORKDIR "/src/Sample.WebApi"
RUN dotnet build "Sample.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sample.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sample.WebApi.dll"]
