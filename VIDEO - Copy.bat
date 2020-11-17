@echo off
set /p version=<.files/.version

title YouTubeDL Script %version% - By Xelofan

echo Paste the URL of the music you want to download! The script will download in the best quality available! (Right Click)
set /p videoURL="> "

echo Starting download, do not close the window!
.files\youtube-dl.exe "%videoURL%" --console-title -f "bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4" -o "VIDEO\%%(title)s.%%(ext)s" -i
echo Download complete!

echo Exiting in 3 seconds..
TIMEOUT /T 3