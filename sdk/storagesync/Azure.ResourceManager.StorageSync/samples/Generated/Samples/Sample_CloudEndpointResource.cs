// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync.Samples
{
    public partial class Sample_CloudEndpointResource
    {
        // CloudEndpoints_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CloudEndpointsCreate()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_Create.json
            // this example is just showing the usage of "CloudEndpoints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            CloudEndpointCreateOrUpdateContent content = new CloudEndpointCreateOrUpdateContent()
            {
                StorageAccountResourceId = new ResourceIdentifier("/subscriptions/744f4d70-6d17-4921-8970-a765d14f763f/resourceGroups/tminienv59svc/providers/Microsoft.Storage/storageAccounts/tminienv59storage"),
                AzureFileShareName = "cvcloud-afscv-0719-058-a94a1354-a1fd-4e9a-9a50-919fad8c4ba4",
                StorageAccountTenantId = Guid.Parse("\"72f988bf-86f1-41af-91ab-2d7cd011db47\""),
                FriendlyName = "ankushbsubscriptionmgmtmab",
            };
            ArmOperation<CloudEndpointResource> lro = await cloudEndpoint.UpdateAsync(WaitUntil.Completed, content);
            CloudEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CloudEndpoints_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CloudEndpointsGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_Get.json
            // this example is just showing the usage of "CloudEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            CloudEndpointResource result = await cloudEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CloudEndpoints_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CloudEndpointsDelete()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_Delete.json
            // this example is just showing the usage of "CloudEndpoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            await cloudEndpoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CloudEndpoints_PreBackup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PreBackup_CloudEndpointsPreBackup()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_PreBackup.json
            // this example is just showing the usage of "CloudEndpoints_PreBackup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            CloudEndpointBackupContent content = new CloudEndpointBackupContent()
            {
                AzureFileShare = "https://sampleserver.file.core.test-cint.azure-test.net/sampleFileShare",
            };
            await cloudEndpoint.PreBackupAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // CloudEndpoints_PostBackup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PostBackup_CloudEndpointsPostBackup()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_PostBackup.json
            // this example is just showing the usage of "CloudEndpoints_PostBackup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            CloudEndpointBackupContent content = new CloudEndpointBackupContent()
            {
                AzureFileShare = "https://sampleserver.file.core.test-cint.azure-test.net/sampleFileShare",
            };
            ArmOperation<CloudEndpointPostBackupResult> lro = await cloudEndpoint.PostBackupAsync(WaitUntil.Completed, content);
            CloudEndpointPostBackupResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // CloudEndpoints_PreRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PreRestore_CloudEndpointsPreRestore()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_PreRestore.json
            // this example is just showing the usage of "CloudEndpoints_PreRestore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            PreRestoreContent content = new PreRestoreContent()
            {
                AzureFileShareUri = new Uri("https://hfsazbackupdevintncus2.file.core.test-cint.azure-test.net/sampleFileShare"),
                RestoreFileSpec =
{
new RestoreFileSpec()
{
Path = "text1.txt",
IsDirectory = false,
},new RestoreFileSpec()
{
Path = "MyDir",
IsDirectory = true,
},new RestoreFileSpec()
{
Path = "MyDir/SubDir",
IsDirectory = false,
},new RestoreFileSpec()
{
Path = "MyDir/SubDir/File1.pdf",
IsDirectory = false,
}
},
            };
            await cloudEndpoint.PreRestoreAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // CloudEndpoints_restoreheartbeat
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RestoreHeartbeat_CloudEndpointsRestoreheartbeat()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_RestoreHeatbeat.json
            // this example is just showing the usage of "CloudEndpoints_restoreheartbeat" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            await cloudEndpoint.RestoreHeartbeatAsync();

            Console.WriteLine($"Succeeded");
        }

        // CloudEndpoints_PostRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PostRestore_CloudEndpointsPostRestore()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_PostRestore.json
            // this example is just showing the usage of "CloudEndpoints_PostRestore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            PostRestoreContent content = new PostRestoreContent()
            {
                AzureFileShareUri = new Uri("https://hfsazbackupdevintncus2.file.core.test-cint.azure-test.net/sampleFileShare"),
                Status = "Succeeded",
                SourceAzureFileShareUri = new Uri("https://hfsazbackupdevintncus2.file.core.test-cint.azure-test.net/sampleFileShare"),
                RestoreFileSpec =
{
new RestoreFileSpec()
{
Path = "text1.txt",
IsDirectory = false,
},new RestoreFileSpec()
{
Path = "MyDir",
IsDirectory = true,
},new RestoreFileSpec()
{
Path = "MyDir/SubDir",
IsDirectory = false,
},new RestoreFileSpec()
{
Path = "MyDir/SubDir/File1.pdf",
IsDirectory = false,
}
},
            };
            await cloudEndpoint.PostRestoreAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // CloudEndpoints_TriggerChangeDetection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TriggerChangeDetection_CloudEndpointsTriggerChangeDetection()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_TriggerChangeDetection.json
            // this example is just showing the usage of "CloudEndpoints_TriggerChangeDetection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            TriggerChangeDetectionContent content = new TriggerChangeDetectionContent()
            {
                DirectoryPath = "NewDirectory",
                ChangeDetectionMode = ChangeDetectionMode.Recursive,
            };
            await cloudEndpoint.TriggerChangeDetectionAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // CloudEndpoints_AfsShareMetadataCertificatePublicKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task AfsShareMetadataCertificatePublicKeys_CloudEndpointsAfsShareMetadataCertificatePublicKeys()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/CloudEndpoints_AfsShareMetadataCertificatePublicKeys.json
            // this example is just showing the usage of "CloudEndpoints_AfsShareMetadataCertificatePublicKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudEndpointResource created on azure
            // for more information of creating CloudEndpointResource, please refer to the document of CloudEndpointResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            string syncGroupName = "SampleSyncGroup_1";
            string cloudEndpointName = "SampleCloudEndpoint_1";
            ResourceIdentifier cloudEndpointResourceId = CloudEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName, syncGroupName, cloudEndpointName);
            CloudEndpointResource cloudEndpoint = client.GetCloudEndpointResource(cloudEndpointResourceId);

            // invoke the operation
            CloudEndpointAfsShareMetadataCertificatePublicKeys result = await cloudEndpoint.AfsShareMetadataCertificatePublicKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
