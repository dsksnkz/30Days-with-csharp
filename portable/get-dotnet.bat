@echo off
setlocal
cd /d "%~dp0"
title Get .NET (portable)

if exist "dotnet\dotnet.exe" goto already

set "ARCH=x64"
if /i "%PROCESSOR_ARCHITECTURE%"=="ARM64" set "ARCH=arm64"
if /i "%PROCESSOR_ARCHITEW6432%"=="ARM64" set "ARCH=arm64"
set "URL=https://aka.ms/dotnet/10.0/dotnet-sdk-win-%ARCH%.zip"

echo Downloading the .NET 10 SDK for %ARCH%. It is about 250 MB, so this can take a while.
echo.
del dotnet-sdk.zip 2>nul
curl.exe -L --fail -o dotnet-sdk.zip "%URL%"
if errorlevel 1 (
    del dotnet-sdk.zip 2>nul
    echo curl did not work, trying PowerShell instead...
    powershell -NoProfile -Command "$ProgressPreference='SilentlyContinue'; Invoke-WebRequest '%URL%' -OutFile 'dotnet-sdk.zip'"
)
if not exist dotnet-sdk.zip goto failed

echo.
echo Unpacking...
mkdir dotnet 2>nul
tar -xf dotnet-sdk.zip -C dotnet 2>nul
if not exist "dotnet\dotnet.exe" powershell -NoProfile -Command "Expand-Archive -Force 'dotnet-sdk.zip' 'dotnet'"
if not exist "dotnet\dotnet.exe" goto failed
del dotnet-sdk.zip

echo.
call "%~dp0env.bat"
dotnet --version
echo.
echo Done. Double-click run.bat to start coding.
pause
exit /b 0

:already
echo .NET is already in this folder. Double-click run.bat to start coding.
pause
exit /b 0

:failed
echo.
echo The download or unpacking failed.
echo Get the zip by hand instead. The steps are in PORTABLE.md, under "If get-dotnet.bat fails".
pause
exit /b 1
