@echo off

echo Masold be a letolteni kivant video URL-jet! (Jobb klikk)
set /p videoURL="> "

echo.
echo Verzio ellenorzese..
call .files\update.bat
echo.
echo Verzio ellenorzes kesz.
cls

echo Letoltes folyamataban, ne zard be az ablakot!
.files\youtube-dl.exe "%videoURL%" --console-title -f "bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4" -o "VIDEO\%%(title)s.%%(ext)s" -i
echo Letoltes kesz!

echo Kilepes 3 masodpercen belul..
TIMEOUT /T 3