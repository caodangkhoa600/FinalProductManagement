FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/AgentWeb/AgentWeb.csproj", "AgentWeb/"]
RUN dotnet restore "src/AgentWeb/AgentWeb.csproj"
COPY . .
WORKDIR "/src/AgentWeb"
RUN dotnet build "AgentWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AgentWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AgentWeb.dll"]
