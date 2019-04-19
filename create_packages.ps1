param (
    [Parameter(Position = 0)][string[]]$projectsToPack,
    [Parameter(Mandatory = $false)][AllowEmptyString()][string]$versionSuffix
)

foreach ($project in $projectsToPack) {
    $project
}

$currentDir = $(get-location).Path;
$publishPath = $currentDir + "\publish"
Remove-Item $publishPath -Recurse -ErrorAction Ignore

foreach ($project in $projectsToPack) {
    if ($versionSuffix) {
        dotnet pack $project -o $publishPath --version-suffix $versionSuffix
    }
    else {
        dotnet pack $project -o $publishPath
    }
}