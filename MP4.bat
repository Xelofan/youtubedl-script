@echo off

echo.
echo Verzio ellenorzese..
call _files\update.bat
echo.
echo Verzio ellenorzes kesz.
cls

echo Masold be a letolteni kivant video URL-jet! (Jobb klikk)
set /p videoURL="> "
echo Letoltes folyamataban, ne zard be az ablakot!
_files\youtube-dl.exe "%videoURL%" --console-title -f "bestvideo[ext=mp4]+bestaudio/best[ext=mp4]/best" -o "VIDEO\%%(title)s.%%(ext)s" -i
echo Letoltes kesz!
echo Kilepes 3 masodpercen belul..
TIMEOUT /T 3