$NuGetExe = Join-Path $PSScriptRoot '.nuget\nuget.exe'

# Download NuGet.exe if missing
if (-not (Test-Path $NuGetExe)) {
    Write-Host 'Downloading nuget.exe'
    New-Item  -ItemType directory  (Join-Path $PSScriptRoot '.nuget') | Out-Null
	(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', $NuGetExe)
}

# Pack will copy all files in this folder into the nupkg
# The contentFiles section of the nuspec is used by the consuming client, not during pack.
& $NuGetExe pack ScheduledParameterJob.nuspec -Exclude pack.ps1