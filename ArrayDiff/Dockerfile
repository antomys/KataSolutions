FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ArrayDiff/ArrayDiff.csproj", "ArrayDiff/"]
RUN dotnet restore "ArrayDiff/ArrayDiff.csproj"
COPY . .
WORKDIR "/src/ArrayDiff"
RUN dotnet build "ArrayDiff.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArrayDiff.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ArrayDiff.dll"]
