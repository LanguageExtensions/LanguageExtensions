param (
    [Parameter(Mandatory = $false)][AllowEmptyString()][string]$versionSuffix
)

$currentDir = $(get-location).Path;
$publishPath = $currentDir + "\publish"

Remove-Item $publishPath -Recurse -ErrorAction Ignore

$suffixParam = ""
if ($versionSuffix) {
    $suffixParam = "--version-suffix '$versionSuffix'"
}

$projectsToPack = @(
    "$currentDir\src\LanguageExtensions.Specifications\LanguageExtensions.Specifications.csproj",
    "$currentDir\src\DataAccess\LanguageExtensions.DataAccess.Abstractions\LanguageExtensions.DataAccess.Abstractions.csproj",
    "$currentDir\src\DataAccess\LanguageExtensions.DataAccess.Extensions\LanguageExtensions.DataAccess.Extensions.csproj",
    "$currentDir\src\DataAccess\LanguageExtensions.DataAccess.EntityFramework\LanguageExtensions.DataAccess.EntityFramework.csproj",
    "$currentDir\src\DataAccess\LanguageExtensions.DataAccess.InMemory\LanguageExtensions.DataAccess.InMemory.csproj",
    "$currentDir\src\DataAccess\LanguageExtensions.DataAccess.MongoDb\LanguageExtensions.DataAccess.MongoDb.csproj"
)

foreach ($project in $projectsToPack) {
    if ($versionSuffix) {
        dotnet pack $project -o $publishPath --version-suffix $versionSuffix
    }
    else {
        dotnet pack $project -o $publishPath
    }
}