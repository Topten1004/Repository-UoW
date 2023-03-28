FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["client/Sample.Blazor.Client/Sample.Blazor.Client.csproj", "Sample.Blazor.Client/"]
RUN dotnet restore "client/Sample.Blazor.Client/Sample.Blazor.Client.csproj"
COPY . .
WORKDIR "/src/Sample.Blazor.Client"
RUN dotnet build "Sample.Blazor.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sample.Blazor.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sample.Blazor.Client.dll"]
