@echo off

echo Masold be a letolteni kivant zene URL-jet! A script a leheto legjobb minosegben fog letolteni! (Jobb klikk)
set /p videoURL="> "

echo.
echo Verzio ellenorzese..
call .files\update.bat
echo.
echo Verzio ellenorzes kesz.
cls

echo Letoltes folyamataban, ne zard be az ablakot!
.files\youtube-dl.exe --no-cache-dir --console-title "%videoURL%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!

echo Kilepes 3 masodpercen belul..
TIMEOUT /T 3