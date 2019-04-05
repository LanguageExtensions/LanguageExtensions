param (
    [Parameter(Mandatory = $true)][AllowEmptyString()][string]$versionSuffix
)

$currentDir = $(get-location).Path;
$publishPath = $currentDir + "\publish"

Remove-Item $publishPath -Recurse -ErrorAction Ignore

$suffixParam = ""
if ($versionSuffix) {
    $suffixParam = "--version-suffix $versionSuffix"
}

$projectsToPack = @(
    "$currentDir\src\DataAccess\LanguageExtensions.DataAccess.Extensions\LanguageExtensions.DataAccess.Extensions.csproj"
)

foreach ($project in $projectsToPack) {
    dotnet pack $project -o $publishPath $suffixParam
}