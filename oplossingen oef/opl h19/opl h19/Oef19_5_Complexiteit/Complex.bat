echo off
REM %1 is eerste argument van het commando
REM voorbeeld van oproep: Complex.bat Form1.cs

Pick.exe %1 if > if.txt
echo aantal if opdrachten:
RegelsTellen.exe if.txt

Pick.exe %1 while > while.txt
echo aantal while opdrachten:
RegelsTellen.exe while.txt

Pick.exe %1 for > for.txt
echo aantal for opdrachten:
RegelsTellen.exe for.txt

Pick.exe %1 switch > switch.txt
echo aantal switch opdrachten:
RegelsTellen.exe switch.txt

del if.txt
del while.txt
del for.txt
del switch.txt

echo on