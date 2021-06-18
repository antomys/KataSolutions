FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BuyingCar/BuyingCar.csproj", "BuyingCar/"]
RUN dotnet restore "BuyingCar/BuyingCar.csproj"
COPY . .
WORKDIR "/src/BuyingCar"
RUN dotnet build "BuyingCar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuyingCar.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuyingCar.dll"]
