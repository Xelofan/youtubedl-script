@echo off
set /p version=<.files/.version

:: Creator stuffs -- angolul jobban néz ki
title YouTubeDL Script %version% - By Xelofan

echo.
echo Script verzio ellenorzese..
echo.
IF 
echo.
echo YouTubeDL fajl ellenorzese..
echo.
IF EXIST ".files\youtube-dl.exe" (
	echo YouTubeDL fajl letezik.
	echo.
) ELSE (
	echo Nem talalhato a youtube-dl.exe fajl, letoltes megkezdese..
	powershell -command "wget -O .files\youtube-dl.exe https://yt-dl.org/latest/youtube-dl.exe"
	echo YouTubeDL fajl letoltve.
	TIMEOUT 1
)

echo Frissitesek keresese..
echo.
.files\youtube-dl.exe -U

IF EXIST ".files\youtube-dl.exe.new" (
	echo Uj Youtube-DL verzio letoltve. 
	echo.
	powershell -command "rm .files\youtube-dl.exe"
	echo Regi verzio eltavolitva.
	echo.
	powershell -command "mv .files\youtube-dl.exe.new .files\youtube-dl.exe"
	echo Frissites kesz.
	TIMEOUT 2
) ELSE (
	echo.
	echo Legfrissebb verzio van feltelepitve.
	TIMEOUT 2
)