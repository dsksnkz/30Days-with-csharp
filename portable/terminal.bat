@echo off
cd /d "%~dp0"
call "%~dp0env.bat"
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
