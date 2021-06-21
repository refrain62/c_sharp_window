REM CSCのファイルは次のコマンドで場所を探してください  [dir /B /S C:\*csc.exe]
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /t:winexe main.cs /r:system.dll,system.drawing.dll,system.windows.forms.dll
pause
