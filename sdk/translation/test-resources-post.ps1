# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

# It is invoked by the https://github.com/Azure/azure-sdk-for-net/blob/main/eng/New-TestResources.ps1
# script after the ARM template, defined in https://github.com/hamshavathimunibyraiah/azure-sdk-for-net/blob/main/sdk/translation/test-resources.json,
# is finished being deployed. The ARM template is responsible for creating the Storage accounts needed for live tests.

param (
    [hashtable] $DeploymentOutputs,
	[string] $ResourceGroupName, # this is the resourceGroup name where the Translator resource is created
	[string] $BaseName, # this is the Translator resource name
	[string] $TestApplicationId, # this is the TestApplicationId
	[string] $TenantId, # this is the TenantId
)

if($DeploymentOutputs.ContainsKey('DOCUMENT_TRANSLATION_STORAGE_NAME')){
  Write-Host "DOCUMENT_TRANSLATION_STORAGE_NAME exists, proceeding."
}else{
  Write-Host "DOCUMENT_TRANSLATION_STORAGE_NAME does not exist, ending."
exit
}
$storageAccountName = $DeploymentOutputs["DOCUMENT_TRANSLATION_STORAGE_NAME"]

function Log($Message) {
  Write-Host ('{0} - {1}' -f [DateTime]::Now.ToLongTimeString(), $Message)
}

Log 'Starting sdk\translation\test-resources-post.ps1'

Log 'Login to azure'
# PowerShell cmd : az login --service-principal -u $TestApplicationId --tenant $TenantId --allow-no-subscriptions --federated-token $env:ARM_OIDC_TOKEN
az login --service-principal -u $TestApplicationId --tenant $TenantId --allow-no-subscriptions # --federated-token $env:ARM_OIDC_TOKEN

Log 'Enable Managed identity on the Translator resource'
# PowerShell cmd : az cognitiveservices account identity assign --name <TranslatorResourceName> --resource-group <ResourceGroupName>
az cognitiveservices account identity assign --name $BaseName --resource-group $ResourceGroupName

Log 'In the storage account, assign Storage-Blob-Data-Contributor role access to translator resource'
Log 'Step 1: Identify the Storage Account resource ID'
# PoweShell cmd: $resourceID = az storage account show --name <StorageAccountName> --resource-group <ResourceGroupName> --query "id" -o tsv
$resourceID = az storage account show --name $storageAccountName --resource-group $ResourceGroupName --query "id" -o tsv
Log "Resource ID is $($resourceID)"

Log 'Step 2: Get the objectId or the principalId of the translator resource that needs to be added'
# PowerShell cmd : $objectID = (Get-AzADServicePrincipal -DisplayName "<TranslatorResourceName>").Id'
$objectID = (Get-AzADServicePrincipal -DisplayName "$BaseName").Id
Log "Object ID or the principalId is $($objectID)"

Log 'Step 3: Assign Storage-Blob-Data-Contributor role' 
# PowerShell cmd : az role assignment create --assignee <PrincipalId/ObjectId> --role "Storage Blob Data Contributor" --scope <ResourceID>
az role assignment create --assignee $objectID --role "Storage Blob Data Contributor" --scope $resourceID

Log 'Finishing sdk\translation\test-resources-post.ps1'