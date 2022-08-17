FROM mcr.microsoft.com/dotnet/sdk:6.0 as build

WORKDIR /build

COPY . /build

RUN dotnet restore
RUN dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as run

WORKDIR /app

COPY --from=build /build/flerwin-api/bin/Release/net6.0/publish .

CMD ["./flerwin-api"]
