@echo off

echo.
echo Checking for updates..
echo.

powershell -command "wget -O .files\.tempversion https://raw.githubusercontent.com/Xelofan/youtubedl-script/master/.files/.version"
set /p tempversion=<.files/.tempversion
IF "%version%" == "%tempversion%" (
	echo [script] You're using the latest version.
) ELSE (
	echo [script] Update is available, starting download..
	TIMEOUT 1
	powershell -command "wget -O %tempversion%.zip https://github.com/Xelofan/youtubedl-script/archive/%tempversion%.zip"
	echo [script] Unpacking update..
	powershell -command "Expand-Archive -Path %tempversion%.zip -DestinationPath . -Force"
	echo [script] Arranging files..
	TIMEOUT 1
	powershell -command "Copy-Item youtubedl-script-%tempversion%/* -Destination . -Force -Recurse"
	powershell -command "rmdir youtubedl-script-%tempversion% -Recurse"
	powershell -command "rm %tempversion%.zip"
	echo [script] Update complete.
	TIMEOUT 3
)
powershell -command "rm .files/.tempversion"
echo.
echo [youtubedl] Checking file..
echo.
IF EXIST ".files\youtube-dl.exe" (
	echo [youtubedl] File exists.
	echo.
) ELSE (
	echo [youtubedl] The file does not exists, starting download..
	powershell -command "wget -O .files\youtube-dl.exe https://yt-dl.org/latest/youtube-dl.exe"
	echo [youtubedl] File downloaded.
	TIMEOUT 1
)

echo [youtubedl] Checking for updates..
echo.
.files\youtube-dl.exe -U

IF EXIST ".files\youtube-dl.exe.new" (
	echo [youtubedl] Update downloaded.
	echo.
	powershell -command "rm .files\youtube-dl.exe"
	echo [youtubedl] Old version removed.
	echo.
	powershell -command "mv .files\youtube-dl.exe.new .files\youtube-dl.exe"
	echo [youtubedl] Update complete.
	TIMEOUT 2
) ELSE (
	echo.
	echo [youtubedl] You're using the latest version.
	TIMEOUT 2
)