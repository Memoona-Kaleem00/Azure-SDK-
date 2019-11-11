# ---------------------------------------------------------------------------------- 
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# ---------------------------------------------------------------------------------- 

<#

.SYNOPSIS
    Powershell script that generates the C# SDK code for Microsoft.Azure.Search.Service from a Swagger spec

.DESCRIPTION
    This script:
    - fetches the config file from user/branch provided
    - Generates code based off the config file provided

.PARAMETER SpecsRepoFork
    The Rest Spec repo fork which contains the config file; the default is Azure.

.PARAMETER SpecsRepoBranch
    The Branch which contains the config file; the default is master.

#>

Param(
    [string] $SpecsRepoFork = "Azure",
    [string] $SpecsRepoBranch = "master",
    [string] $Tag = ""
)

"$PSScriptRoot\..\..\Install-BuildTools.ps1"

$generateFolder = "$PSScriptRoot\Generated"
$sharedGenerateFolder = "$PSScriptRoot\..\..\Microsoft.Azure.Search.Common\src\Generated"

Start-AutoRestCodeGeneration -ResourceProvider "search/data-plane/Microsoft.Azure.Search.Service" -AutoRestVersion "latest" -SpecsRepoFork $SpecsRepoFork -SpecsRepoBranch $SpecsRepoBranch -ConfigFileTag $Tag

Write-Output "Deleting extra files and cleaning up..."

# Move any extra files generated for types that are shared between SearchServiceClient and SearchIndexClient to Common.
if (Test-Path -Path $sharedGenerateFolder)
{
    Remove-Item -Recurse -Force $sharedGenerateFolder
}

New-Item -ItemType Directory $sharedGenerateFolder
Move-Item "$generateFolder\Models\SearchRequestOptions.cs" $sharedGenerateFolder

# Delete files generated by AutoRest for enums that we want to be "extensible" and having x-ms-enum isn't suitable.
# This is because x-ms-enum generate static readonly types, which cannot be used in attributes.
Remove-Item -Force "$generateFolder\Models\AnalyzerName.cs"
Remove-Item -Force "$generateFolder\Models\AnalyzerNameConverter.cs"
Remove-Item -Force "$generateFolder\Models\DataType.cs"
Remove-Item -Force "$generateFolder\Models\DataTypeConverter.cs"

# For this enum type we have a customization that allows logical operations, which is not supported by x-ms-enum
Remove-Item -Force "$generateFolder\Models\RegexFlags.cs"
Remove-Item -Force "$generateFolder\Models\RegexFlagsConverter.cs"

Write-Output "Finished cleanup."
