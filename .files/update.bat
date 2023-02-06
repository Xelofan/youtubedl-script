@echo off


:: DO NOT CHANGE THESE SETTINGS
set branch=2023.1
set autoupdate=true
set audio_format=mp3
set video_format=mp4
:: CAN BE CONFIGURED IN THE FUTURE

echo.
echo Checking for updates..
echo.

IF "%autoupdate%" == "true" (
	powershell -command "wget -O .files\.tempversion https://raw.githubusercontent.com/Xelofan/youtubedl-script/%branch%/.files/.version"
	set /p tempversion=<.files/.tempversion

	IF "%version%" == "%tempversion%" (
		echo [script] You're using the latest version.
	) ELSE (
		echo [script] Update is available, starting download..
		powershell -command "(New-Object System.Net.WebClient).DownloadFile('https://github.com/Xelofan/youtubedl-script/archive/refs/heads/%branch%.zip', '%branch%.zip')"
		echo [script] Unpacking update..
		powershell -command "Expand-Archive -Path %branch%.zip -DestinationPath . -Force"
		echo [script] Arranging files..
		powershell -command "Copy-Item youtubedl-script-%branch%/* -Destination . -Force -Recurse"
		powershell -command "rmdir youtubedl-script-%branch% -Recurse"
		powershell -command "rm %branch%.zip"
		echo [script] Update complete.
	)
	powershell -command "rm .files/.tempversion"

)
echo.

IF EXIST ".files\ffmpeg.exe" (
	::echo [ffmpeg] File found.
) ELSE (
	echo [ffmpeg] File does not exist, starting download..
	powershell -command "(New-Object System.Net.WebClient).DownloadFile('https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip', '.files\ffmpeg-temp.zip')"
	powershell -command "Expand-Archive -Path .files\ffmpeg-temp.zip -DestinationPath .files\ -Force"
	powershell -command "mv .files\ffmpeg-master-latest-win64-gpl\bin\ffmpeg.exe .files\ffmpeg.exe"
	powershell -command "Remove-Item -Recurse -Force .files\ffmpeg-master-latest-win64-gpl"
	powershell -command "Remove-Item -Force .files\ffmpeg-temp.zip"
	echo [ffmpeg] File downloaded.
)

IF EXIST ".files\youtube-dl.exe" (
	echo [youtubedl] YouTube-DL file found, switching to YouTube-DLP..
	powershell -command "(New-Object System.Net.WebClient).DownloadFile('https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe', '.files\yt-dlp.exe')"
	echo [yt-dlp] Removing YouTube-DL..
	powershell -command "rm .files\youtube-dl.exe"
	echo.
)

IF EXIST ".files\yt-dlp.exe" (
	::echo [yt-dlp] File found.
	::echo.
) ELSE (
	echo [yt-dlp] The file does not exist, starting download..
	powershell -command "(New-Object System.Net.WebClient).DownloadFile('https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe', '.files\yt-dlp.exe')"
	echo [yt-dlp] File downloaded.
)

IF "%autoupdate%" == "true" (
	echo [yt-dlp] Checking for updates..
	echo.
	.files\yt-dlp.exe -U
)

IF EXIST ".files\yt-dlp.exe.new" (
	echo [yt-dlp] Update downloaded.
	echo.
	powershell -command "rm .files\yt-dlp.exe"
	echo [yt-dlp] Old version removed.
	echo.
	powershell -command "mv .files\yt-dlp.exe.new .files\yt-dlp.exe"
	echo [yt-dlp] Update complete.
) ELSE (
	echo.
	echo [yt-dlp] You're using the latest version.
)
