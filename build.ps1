if (test-path .\build) { ri -r -fo .\build }
mkdir .\build | out-null
.\tools\psake\psake.ps1 default.ps1 default 3.5
.\tools\psake\psake.ps1 default.ps1 default 4.0
.\Tools\nuget\NuGet.exe pack .\Amazon.WebServices.MechanicalTurk.nuspec -BasePath .\build -OutputDirectory .\build
copy .\build\*.nupkg "\\fileserv\DistSW\Clean Water Services\Packages"
