@echo off
setlocal
cd /d "%~dp0"
title C# runner
rem Use the .NET in this folder. Nothing is installed on the laptop.
set "DOTNET_ROOT=%~dp0dotnet"
set "PATH=%~dp0dotnet;%PATH%"
set "DOTNET_CLI_HOME=%~dp0home"
set "NUGET_PACKAGES=%~dp0home\nuget"
set "DOTNET_CLI_TELEMETRY_OPTOUT=1"
set "DOTNET_NOLOGO=1"
set "DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1"
set "DOTNET_MULTILEVEL_LOOKUP=0"

if not exist "dotnet\dotnet.exe" goto nodotnet

rem Drag a .cs file onto run.bat to run that file instead of code.cs.
set "FILE=%~1"
if "%FILE%"=="" set "FILE=%~dp0code.cs"
if not exist "%FILE%" copy /y "%~dp0template.cs" "%FILE%" >nul

for %%F in ("%FILE%") do set "NAME=%%~nxF"
start "" notepad "%FILE%"

:loop
echo.
echo  Paste your code into Notepad and save it with Ctrl+S.
echo  Then press any key here to run it. Close this window to stop.
pause >nul
echo.
echo ================ running %NAME% ================
"%~dp0dotnet\dotnet.exe" run "%FILE%"
echo ================ finished ================
goto loop

:nodotnet
echo .NET isn't next to this file. run.bat needs a folder called dotnet
echo in the same place, with dotnet.exe inside it:
echo   %~dp0dotnet\dotnet.exe
echo Double-click get-dotnet.bat in this folder to download it.
pause
exit /b 1
