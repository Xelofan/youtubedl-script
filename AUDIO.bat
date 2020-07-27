@echo off
set /p version=<.files/.version

title YouTubeDL Script %version% - By Xelofan

echo Paste the URL of the song you want to download! The script will download in the best quality available! (Right Click)
set /p videoURL="> "

echo.
echo Checking version..
call .files\update.bat
echo.
echo Version checking complete.
cls

echo Starting download, do not close the window!
.files\youtube-dl.exe --no-cache-dir --console-title "%videoURL%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Download complete!

echo Exiting in 3 seconds..
TIMEOUT /T 3