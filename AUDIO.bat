@echo off

echo Masold be a letolteni kivant zene URL-jet! (Jobb klikk)
set /p videoURL="> "

echo.
echo Verzio ellenorzese..
call _files\update.bat
echo.
echo Verzio ellenorzes kesz.
cls

echo Letoltes folyamataban, ne zard be az ablakot!
_files\youtube-dl.exe "%videoURL%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!

echo Kilepes 3 masodpercen belul..
TIMEOUT /T 3