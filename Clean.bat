@echo off
SET TAR=Release_Build
rmdir /Q /S %TAR%
Attrib *.suo -H
del /Q /S *.suo
del /Q /S *.bak 
del /Q /S *.thumb
REM for /f %%f in ('dir /s /b /a:d') do rmdir /Q /S %%f\bin %%f\obj
for /f %%f in ('dir /s /b /a:d obj') do call:CleanProject %%f
for /f %%f in ('dir /s /b /a:d bin') do call:CleanProject %%f

::--------------------------------------------------------
::-- Function to Build
::--------------------------------------------------------

:CleanProject    - here starts my function identified by it's label
echo.
echo. Cleaning %~1 
IF EXIST %~1  (rmdir /Q /S %~1)
goto:eof