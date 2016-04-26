@ECHO OFF

IF "%CONFIGURATION%"=="" SET CONFIGURATION=Debug

star --resourcedir="%~dp0src\HelloWorld\wwwroot" "%~dp0src/HelloWorld/bin/%CONFIGURATION%/HelloWorld.exe"