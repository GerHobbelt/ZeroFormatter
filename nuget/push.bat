REM nuget push Alexinea.ZeroFormatter.Analyzer.1.1.1.0.nupkg -Source https://www.nuget.org/api/v2/package
REM nuget push Alexinea.ZeroFormatter.1.6.4.nupkg -Source https://api.nuget.org/api/v3/index.json
REM nuget push Alexinea.ZeroFormatter.Interfaces.1.6.4.nupkg -Source https://api.nuget.org/api/v3/index.json
REM nuget push Alexinea.ZeroFormatter.Unity.1.6.4.nupkg -Source https://www.nuget.org/api/v2/package

set /p key=input key:
set source=https://api.nuget.org/v3/index.json
dotnet nuget push "Alexinea.ZeroFormatter.1.6.4.nupkg" -k %key% -s %source%
dotnet nuget push "Alexinea.ZeroFormatter.Interfaces.1.6.4.nupkg" -k %key% -s %source%