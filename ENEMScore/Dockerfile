# Usar a imagem oficial do .NET para construir a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Usar a imagem do SDK do .NET para compilar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ENEMScore/ENEMScore.csproj", "ENEMScore/"]
RUN dotnet restore "ENEMScore/ENEMScore.csproj"
COPY . .
WORKDIR "/src/ENEMScore"
RUN dotnet build "ENEMScore.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "ENEMScore.csproj" -c Release -o /app/publish

# Configurar o ambiente de runtime
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ENEMScore.dll"]

ENV LANG=pt_BR.UTF-8
ENV LC_ALL=pt_BR.UTF-8