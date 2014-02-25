Param (
	$variables = @{},
	$tempFolder
)

.\.nuget\NuGet.exe setApiKey $variables["NuGetApiKeySecure"]

$tempFolder + "\NuGet.Core.Contracts" | Get-ChildItem -Filter "*.nupkg" | % {
	.\.nuget\NuGet.exe push $_.FullName
}
