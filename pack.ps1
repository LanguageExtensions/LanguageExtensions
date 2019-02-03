param (
    [Parameter(Mandatory = $true)][AllowEmptyString()][string]$versionSuffix
)

$currentDir = $(get-location).Path;
$publishPath = $currentDir + "\publish"

$suffixParam = ""
if ($versionSuffix) {
    $suffixParam = "--version-suffix $versionSuffix"
}

$projectsToPack = @(
    $currentDir + "\src\LanguageExtensions.Specification\LanguageExtensions.Specification.csproj",
    $currentDir + "\src\DataAccess\LanguageExtensions.DataAccess.Abstractions\LanguageExtensions.DataAccess.Abstractions.csproj",
    $currentDir + "\src\DataAccess\LanguageExtensions.DataAccess.EntityFramework\LanguageExtensions.DataAccess.EntityFramework.csproj",
    $currentDir + "\src\DataAccess\LanguageExtensions.DataAccess.InMemory\LanguageExtensions.DataAccess.InMemory.csproj",
    $currentDir + "\src\DataAccess\LanguageExtensions.DataAccess.MongoDb\LanguageExtensions.DataAccess.MongoDb.csproj"
)

foreach ($project in $projectsToPack) {
    "dotnet pack $project -o $publishPath $suffixParam"
}