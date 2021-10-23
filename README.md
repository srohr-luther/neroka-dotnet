# neroka-dotnet

## Basic setup

- `mkdir -p src test`
- `cd src && dotnet new console && cd ..`
- `cd test && dotnet new xunit && cd ..`
- `cd test && dotnet add reference ../src && cd ..`
- `mv src/src.csproj src/Com.Github.SRohrLuther.Neroka.csproj`
- `mv test/test.csproj src/Com.Github.SRohrLuther.Neroka.Test.csproj`
- `dotnet new tool-manifest --force`
- `dotnet tool install dotnet-outdated-tool`
  - `dotnet tool restore`
- `dotnet dotnet-outdated`
  - `dotnet dotnet-outdated -u`
- `dotnet tool install GitVersion.Tool`

## Dependencies

- `dotnet add package Discord.Net`

## Usage

- `BOT_TOKEN="<TOKEN>" dotnet run --project src`
