::set PATH=%WINDIR%\Microsoft.Net\Framework64\v3.5;%PATH%
dotnet restore
dotnet msbuild Recognize.sln  -t:Rebuild -p:Configuration=Release -v:n
pause()