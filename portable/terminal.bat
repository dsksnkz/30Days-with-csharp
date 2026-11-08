@echo off
cd /d "%~dp0"
rem Use the .NET in this folder. Nothing is installed on the laptop.
set "DOTNET_ROOT=%~dp0dotnet"
set "PATH=%~dp0dotnet;%PATH%"
set "DOTNET_CLI_HOME=%~dp0home"
set "NUGET_PACKAGES=%~dp0home\nuget"
set "DOTNET_CLI_TELEMETRY_OPTOUT=1"
set "DOTNET_NOLOGO=1"
set "DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1"
set "DOTNET_MULTILEVEL_LOOKUP=0"
if not exist "dotnet\dotnet.exe" (
    echo .NET isn't in this folder yet. Double-click get-dotnet.bat first.
    pause
    exit /b 1
)
echo This window uses the portable .NET, so the course commands work here:
echo.
echo   dotnet new console -o Day04
echo   cd Day04
echo   dotnet run
echo.
cmd /k
