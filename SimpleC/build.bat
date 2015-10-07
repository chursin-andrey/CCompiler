@echo off

%~d0
cd "%~dp0"

set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319

if exist .\_props.bat call .\_props.bat

set MSBUILD="%NET_HOME%\msbuild"

%MSBUILD% /target:rebuild .\SimpleC.csproj
pause
