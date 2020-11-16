@echo off
cls

:: -help
for /f "usebackq delims=" %%s in (`"iwm_FileDialog.exe -h"`) do echo.

:: -nameonly
:R0
	set rtn=

	for /f "usebackq delims=" %%s in (`"iwm_FileDialog.exe -no"`) do set rtn=%%s

	if "%rtn%"=="" goto :R9

	echo %rtn%
	echo.

	goto :R0
:R9

echo.
pause
exit
