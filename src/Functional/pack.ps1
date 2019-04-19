param (
    [Parameter(Mandatory = $false)][AllowEmptyString()][string]$versionSuffix
)

$currentDir = $(get-location).Path;
$publishPath = $currentDir + "\publish"

Remove-Item $publishPath -Recurse -ErrorAction Ignore

$projectsToPack = @(
    "$currentDir\LanguageExtensions.Functional\LanguageExtensions.Functional.csproj"
)
$projectNamesArray = $projectsToPack -join ','

$ScriptLocation = "../../create_packages.ps1"
Invoke-Expression "$ScriptLocation $projectNamesArray"