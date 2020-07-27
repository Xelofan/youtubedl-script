@echo off

echo Masold be a letolteni kivant zenek URL-jet! A script a leheto legjobb minosegben fog letolteni! (Jobb klikk)
set /p videoURL1="> "
set /p videoURL2="> "
set /p videoURL3="> "
set /p videoURL4="> "
set /p videoURL5="> "

echo.
echo Verzio ellenorzese..
call .files\update.bat
echo.
echo Verzio ellenorzes kesz.
cls

echo Letoltes folyamataban, ne zard be az ablakot!
.files\youtube-dl.exe "%videoURL1%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!
.files\youtube-dl.exe "%videoURL2%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!
.files\youtube-dl.exe "%videoURL3%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!
.files\youtube-dl.exe "%videoURL4%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!
.files\youtube-dl.exe "%videoURL5%" -x --audio-format "mp3" -o "AUDIO\%%(title)s.%%(ext)s" -i -f bestaudio
echo Letoltes kesz!

echo Kilepes 3 masodpercen belul..
TIMEOUT /T 3
