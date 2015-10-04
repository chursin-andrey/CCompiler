@echo off

%~d0
cd "%~dp0"

set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319

if exist .\_props.bat call .\_props.bat

rem set ANTLR_JAR=.\antlr\java\antlr-3.4-completejar
set MSBUILD="%NET_HOME%\msbuild"

rem set ANTLR=%JAVA% -classpath .;%CLASSPATH%;%ANTLR_JAR% org.antlr.Tool



%MSBUILD% /target:rebuild .\MathLang.csproj
