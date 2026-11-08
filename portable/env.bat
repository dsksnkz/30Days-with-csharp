@echo off
rem Points this window at the .NET in this folder. Nothing is installed on the laptop.
set "DOTNET_ROOT=%~dp0dotnet"
set "PATH=%~dp0dotnet;%PATH%"
set "DOTNET_CLI_HOME=%~dp0home"
set "NUGET_PACKAGES=%~dp0home\nuget"
set "DOTNET_CLI_TELEMETRY_OPTOUT=1"
set "DOTNET_NOLOGO=1"
set "DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1"
set "DOTNET_MULTILEVEL_LOOKUP=0"
