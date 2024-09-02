// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningCodeVersionResource
    {
        // Delete Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/CodeVersion/delete.json
            // this example is just showing the usage of "CodeVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeVersionResource created on azure
            // for more information of creating MachineLearningCodeVersionResource, please refer to the document of MachineLearningCodeVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningCodeVersionResourceId = MachineLearningCodeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningCodeVersionResource machineLearningCodeVersion = client.GetMachineLearningCodeVersionResource(machineLearningCodeVersionResourceId);

            // invoke the operation
            await machineLearningCodeVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/CodeVersion/get.json
            // this example is just showing the usage of "CodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeVersionResource created on azure
            // for more information of creating MachineLearningCodeVersionResource, please refer to the document of MachineLearningCodeVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningCodeVersionResourceId = MachineLearningCodeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningCodeVersionResource machineLearningCodeVersion = client.GetMachineLearningCodeVersionResource(machineLearningCodeVersionResourceId);

            // invoke the operation
            MachineLearningCodeVersionResource result = await machineLearningCodeVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/CodeVersion/createOrUpdate.json
            // this example is just showing the usage of "CodeVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeVersionResource created on azure
            // for more information of creating MachineLearningCodeVersionResource, please refer to the document of MachineLearningCodeVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningCodeVersionResourceId = MachineLearningCodeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningCodeVersionResource machineLearningCodeVersion = client.GetMachineLearningCodeVersionResource(machineLearningCodeVersionResourceId);

            // invoke the operation
            MachineLearningCodeVersionData data = new MachineLearningCodeVersionData(new MachineLearningCodeVersionProperties()
            {
                CodeUri = new Uri("https://blobStorage/folderName"),
                IsAnonymous = false,
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearningCodeVersionResource> lro = await machineLearningCodeVersion.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningCodeVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Publish Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Publish_PublishWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/CodeVersion/publish.json
            // this example is just showing the usage of "CodeVersions_Publish" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeVersionResource created on azure
            // for more information of creating MachineLearningCodeVersionResource, please refer to the document of MachineLearningCodeVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningCodeVersionResourceId = MachineLearningCodeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningCodeVersionResource machineLearningCodeVersion = client.GetMachineLearningCodeVersionResource(machineLearningCodeVersionResourceId);

            // invoke the operation
            DestinationAsset body = new DestinationAsset()
            {
                RegistryName = "string",
                DestinationName = "string",
                DestinationVersion = "string",
            };
            await machineLearningCodeVersion.PublishAsync(WaitUntil.Completed, body);

            Console.WriteLine($"Succeeded");
        }

        // CreateOrGetStartPendingUpload Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrGetStartPendingUpload_CreateOrGetStartPendingUploadWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/CodeVersion/createOrGetStartPendingUpload.json
            // this example is just showing the usage of "CodeVersions_CreateOrGetStartPendingUpload" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeVersionResource created on azure
            // for more information of creating MachineLearningCodeVersionResource, please refer to the document of MachineLearningCodeVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningCodeVersionResourceId = MachineLearningCodeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningCodeVersionResource machineLearningCodeVersion = client.GetMachineLearningCodeVersionResource(machineLearningCodeVersionResourceId);

            // invoke the operation
            PendingUploadRequestDto body = new PendingUploadRequestDto()
            {
                PendingUploadId = "string",
                PendingUploadType = PendingUploadType.None,
            };
            PendingUploadResponseDto result = await machineLearningCodeVersion.CreateOrGetStartPendingUploadAsync(body);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
