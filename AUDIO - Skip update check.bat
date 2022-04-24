@echo off
set /p version=<.files/.version

title YouTube Downloader Script %version% - By Xelofan

echo Paste the URL of the song you want to download! The script will download in the best quality available! (Right Click)
set /p videoURL="> "

echo Starting download, do not close the window!
.files\yt-dlp.exe --no-cache-dir --console-title "%videoURL%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Download complete!

echo Exiting in 3 seconds..
TIMEOUT /T 3
