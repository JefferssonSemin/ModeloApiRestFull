FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["ModeloApiRestFull/ModeloApiRestFull.csproj", "ModeloApiRestFull/"]
RUN dotnet restore "ModeloApiRestFull/ModeloApiRestFull.csproj"
COPY . .
WORKDIR "/src/ModeloApiRestFull"
RUN dotnet build "ModeloApiRestFull.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ModeloApiRestFull.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ModeloApiRestFull.dll"]