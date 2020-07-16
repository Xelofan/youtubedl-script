@echo off

set /p version=<.files/.version


title YouTubeDL Script %version% - By Xelofan

echo.
echo Frissitesek keresese..
echo.

powershell -command "wget -O .files\.tempversion https://raw.githubusercontent.com/Xelofan/youtubedl-script/master/.files/.version"
set /p tempversion=<.files/.tempversion
IF "%version%" == "%tempversion%" (
	echo [SCRIPT] Legfrissebb verziot hasznalod.
) ELSE (
	echo [SCRIPT] Frissites talalhato, letoltes megkezdese..
	TIMEOUT 1
	powershell -command "wget -O %tempversion%.zip https://github.com/Xelofan/youtubedl-script/archive/%tempversion%.zip"
	echo [SCRIPT] Frissites kicsomagolasa..
	powershell -command "Expand-Archive -Path %tempversion%.zip -DestinationPath . -Force"
	echo [SCRIPT] Fajlok rendberakasa..
	TIMEOUT 1
	powershell -command "Copy-Item youtubedl-script-%tempversion%/* -Destination . -Force -Recurse"
	powershell -command "rmdir youtubedl-script-%tempversion% -Recurse"
	powershell -command "rm %tempversion%.zip"
	echo [SCRIPT] Sikeres frissites!
	echo [SCRIPT] Ajanlott ujrainditani a scriptet, hogy ervenybe lepjenek a valtoztatasok.
	TIMEOUT 3
)
powershell -command "rm .files/.tempversion"
echo.
echo [YTDL] Fajl ellenorzese..
echo.
IF EXIST ".files\youtube-dl.exe" (
	echo [YTDL] Fajl letezik.
	echo.
) ELSE (
	echo [YTDL] Nem talalhato a youtube-dl.exe fajl, letoltes megkezdese..
	powershell -command "wget -O .files\youtube-dl.exe https://yt-dl.org/latest/youtube-dl.exe"
	echo [YTDL] Fajl letoltve.
	TIMEOUT 1
)

echo [YTDL] Frissitesek keresese..
echo.
.files\youtube-dl.exe -U

IF EXIST ".files\youtube-dl.exe.new" (
	echo [YTDL] Uj verzio letoltve. 
	echo.
	powershell -command "rm .files\youtube-dl.exe"
	echo Regi [YTDL] verzio eltavolitva.
	echo.
	powershell -command "mv .files\youtube-dl.exe.new .files\youtube-dl.exe"
	echo [YTDL] Frissites kesz.
	TIMEOUT 2
) ELSE (
	echo.
	echo [YTDL] A legfrissebb verziot hasznalod.
	TIMEOUT 2
)