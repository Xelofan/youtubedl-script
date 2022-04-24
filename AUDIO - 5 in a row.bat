@echo off
set /p version=<.files/.version

title YouTube Downloader Script %version% - By Xelofan

echo Paste the URL of the songs you want to download! The script will download in the best quality available! (Right Click)
set /p videoURL1="> "
set /p videoURL2="> "
set /p videoURL3="> "
set /p videoURL4="> "
set /p videoURL5="> "

echo.
echo Checking version..
call .files\update.bat
echo.
echo Version checking complete.
cls

echo Starting download, do not close the window!
.files\yt-dlp.exe "%videoURL1%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo [1] Download complete!
.files\yt-dlp.exe "%videoURL2%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo [2] Download complete!
.files\yt-dlp.exe "%videoURL3%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo [2] Download complete!
.files\yt-dlp.exe "%videoURL4%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo [4] Download complete!
.files\yt-dlp.exe "%videoURL5%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo [5] Download complete!
echo All downloads are complete.

echo Exiting in 3 seconds..
TIMEOUT /T 3
