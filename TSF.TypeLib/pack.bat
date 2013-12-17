nuget pack TSF.TypeLib.csproj -Build -Properties Configuration=Release;
"C:\Program Files (x86)\Windows Kits\8.1\bin\x64\signtool.exe" sign /t http://timestamp.globalsign.com/scripts/timstamp.dll bin\Release\TSF.TypeLib.dll
nuget pack TSF.TypeLib.csproj -Properties Configuration=Release;
