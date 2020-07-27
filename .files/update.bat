@echo off

echo.
echo Checking for updates..
echo.

powershell -command "wget -O .files\.tempversion https://raw.githubusercontent.com/Xelofan/youtubedl-script/master/.files/.version"
set /p tempversion=<.files/.tempversion
IF "%version%" == "%tempversion%" (
	echo [SCRIPT] You're using the latest version.
) ELSE (
	echo [SCRIPT] Update is available, starting download..
	TIMEOUT 1
	powershell -command "wget -O %tempversion%.zip https://github.com/Xelofan/youtubedl-script/archive/%tempversion%.zip"
	echo [SCRIPT] Unpacking update..
	powershell -command "Expand-Archive -Path %tempversion%.zip -DestinationPath . -Force"
	echo [SCRIPT] Arranging files..
	TIMEOUT 1
	powershell -command "Copy-Item youtubedl-script-%tempversion%/* -Destination . -Force -Recurse"
	powershell -command "rmdir youtubedl-script-%tempversion% -Recurse"
	powershell -command "rm %tempversion%.zip"
	echo [SCRIPT] Update complete!
	TIMEOUT 3
)
powershell -command "rm .files/.tempversion"
echo.
echo [YTDL] Checking file..
echo.
IF EXIST ".files\youtube-dl.exe" (
	echo [YTDL] File exists.
	echo.
) ELSE (
	echo [YTDL] The file does not exists, starting download..
	powershell -command "wget -O .files\youtube-dl.exe https://yt-dl.org/latest/youtube-dl.exe"
	echo [YTDL] File downloaded.
	TIMEOUT 1
)

echo [YTDL] Checking for updates..
echo.
.files\youtube-dl.exe -U

IF EXIST ".files\youtube-dl.exe.new" (
	echo [YTDL] Update downloaded. 
	echo.
	powershell -command "rm .files\youtube-dl.exe"
	echo [YTDL] Removing old version..
	echo.
	powershell -command "mv .files\youtube-dl.exe.new .files\youtube-dl.exe"
	echo [YTDL] Update complete!!
	TIMEOUT 2
) ELSE (
	echo.
	echo [YTDL] You're using the latest version.
	TIMEOUT 2
)