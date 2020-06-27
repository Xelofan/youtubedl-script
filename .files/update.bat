@echo off
echo.
echo Ffmpeg fajl ellenorzese.
echo.
IF EXIST ".files\ffmpeg.exe" (
	echo Ffmpeg fajl letezik.
	echo.
) ELSE (
	echo Nem talalhato az ffmpeg.exe fajl, letoltes megkezdese..
	powershell -command "wget -O .files\ffmpeg.exe https://filehost.xelofan.hu/megtekintes/xa513fcy.exe"
	echo Ffmpeg fajl letoltve.
)
echo YouTubeDL fajl ellenorzese.
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