@echo off
set /p version=<.files/.version

title YouTube Downloader Script %version% - By Xelofan

echo Paste the URL of the music you want to download! The script will download in the best quality available! (Right Click)
set /p videoURL="> "

echo.
echo Checking version..
call .files\update.bat
echo.
echo Version checking complete.
cls

echo Starting download, do not close the window!
.files\yt-dlp.exe "%videoURL%" --console-title -f "bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4" -o "VIDEO\%%(title)s.%%(ext)s" -i
echo Download complete!

echo Exiting in 3 seconds..
TIMEOUT /T 3
