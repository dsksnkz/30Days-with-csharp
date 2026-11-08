@echo off
setlocal
cd /d "%~dp0"
title C# runner
call "%~dp0env.bat"

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
dotnet run "%FILE%"
echo ================ finished ================
goto loop

:nodotnet
echo .NET isn't in this folder yet. Double-click get-dotnet.bat first.
pause
exit /b 1
