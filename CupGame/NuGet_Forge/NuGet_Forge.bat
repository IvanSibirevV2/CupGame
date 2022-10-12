Rem V0.0.2
@echo off
cd %~dp0
if "%cd%" EQU "C:\Program Files\Notepad++" (
	cd C:\D\Git_Hub\HowTo_NuGet\NuGet_Forge
)
echo %cd%
call :menu.run

PAUSE
CLS
EXIT

rem s - doun
:menu.Choice2
	set /a menu.id= %menu.id%-1
exit /b 0
rem e - DO
:menu.Choice3
	set /a menu.id= %menu.id%+1
exit /b 0
rem Show Menu
:menu.run
	set menu.id=1
	:menu.run.m_cajhgushfkjdagskjsagj
		echo ##################################
		call :menu.Choice1
		echo ##################################
		choice /c ews
		call :menu.Choice%ErrorLevel% do
	goto :menu.run.m_cajhgushfkjdagskjsagj
exit /b 0
rem w - upp
rem Пункты меню вписывать сюда.
:menu.Choice1
	set menu.counter=-1
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% (echo * 0. Exit)
		if %menu.id% NEQ %menu.counter% (echo 0. Exit)
	)else (if %menu.id% EQU %menu.counter% Exit)
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% (echo * nuget spec)
		if %menu.id% NEQ %menu.counter% (echo nuget spec)
	)else (if %menu.id% EQU %menu.counter% nuget spec)
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% (echo * notepad Package.nuspec)
		if %menu.id% NEQ %menu.counter% (echo notepad Package.nuspec)
	)else (if %menu.id% EQU %menu.counter% (notepad Package.nuspec)&&(nuget pack))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% (echo * notepad NuGet_Forge_ReadMe.txt)
		if %menu.id% NEQ %menu.counter% (echo notepad NuGet_Forge_ReadMe.txt)
	)else (if %menu.id% EQU %menu.counter% notepad NuGet_Forge_ReadMe.txt)
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% (echo * nuget pack)
		if %menu.id% NEQ %menu.counter% (echo nuget pack)
	)else (if %menu.id% EQU %menu.counter% nuget pack)
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% (echo * nuget delete /?)
		if %menu.id% NEQ %menu.counter% (echo nuget delete /?)
	)else (if %menu.id% EQU %menu.counter% nuget delete /?)
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu.counter= %menu.counter%+1
	if "%1" NEQ "" (
		if %menu.id% EQU %menu.counter% (
			Set /p packageID= .packageID=
			Set /p packageVersion= .packageVersion=
		)
	)
	if "%1" EQU "" (
		if %menu.id% EQU %menu.counter% echo * nuget delete ^<packageID^> ^<packageVersion^> -apikey [...] -Source [...]
		if %menu.id% NEQ %menu.counter% echo nuget delete ^<packageID^> ^<packageVersion^> -apikey [...] -Source [...]
	)else (if %menu.id% EQU %menu.counter% nuget delete %PackageID% %packageVersion% -Source https://www.nuget.org/ -apikey %menu.APIKey%)
	::)else (if %menu.id% EQU 5 nuget delete -apikey oy2a42l6o4oyrf2onb5agpcnybjdndmevkqootw2luis4q)
	::-apikey
exit /b 0