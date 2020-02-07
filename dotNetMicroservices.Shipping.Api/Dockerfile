FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["dotNetMicroservices.Shipping.Api/dotNetMicroservices.Shipping.Api.csproj", "dotNetMicroservices.Shipping.Api/"]
RUN dotnet restore "dotNetMicroservices.Shipping.Api/dotNetMicroservices.Shipping.Api.csproj"
COPY . .
WORKDIR "/src/dotNetMicroservices.Shipping.Api"
RUN dotnet build "dotNetMicroservices.Shipping.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dotNetMicroservices.Shipping.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dotNetMicroservices.Shipping.Api.dll"]