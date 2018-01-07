@echo off
set name=CmdHere
set net=C:\Windows\Microsoft.NET\Framework\v4.0.30319
set csc=%net%\csc.exe
%csc% /debug+ %name%.cs
if errorlevel 1 exit 1
"%name%.exe"
