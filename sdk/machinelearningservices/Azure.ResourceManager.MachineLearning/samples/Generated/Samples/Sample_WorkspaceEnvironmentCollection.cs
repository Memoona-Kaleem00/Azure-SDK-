// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_WorkspaceEnvironmentCollection
    {
        // List Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/list.json
            // this example is just showing the usage of "EnvironmentContainers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this WorkspaceEnvironmentResource
            WorkspaceEnvironmentCollection collection = machineLearningWorkspace.GetWorkspaceEnvironments();

            // invoke the operation and iterate over the result
            await foreach (WorkspaceEnvironmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningEnvironmentContainerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/get.json
            // this example is just showing the usage of "EnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this WorkspaceEnvironmentResource
            WorkspaceEnvironmentCollection collection = machineLearningWorkspace.GetWorkspaceEnvironments();

            // invoke the operation
            string name = "testEnvironment";
            WorkspaceEnvironmentResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/get.json
            // this example is just showing the usage of "EnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this WorkspaceEnvironmentResource
            WorkspaceEnvironmentCollection collection = machineLearningWorkspace.GetWorkspaceEnvironments();

            // invoke the operation
            string name = "testEnvironment";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/get.json
            // this example is just showing the usage of "EnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this WorkspaceEnvironmentResource
            WorkspaceEnvironmentCollection collection = machineLearningWorkspace.GetWorkspaceEnvironments();

            // invoke the operation
            string name = "testEnvironment";
            NullableResponse<WorkspaceEnvironmentResource> response = await collection.GetIfExistsAsync(name);
            WorkspaceEnvironmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningEnvironmentContainerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/createOrUpdate.json
            // this example is just showing the usage of "EnvironmentContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this WorkspaceEnvironmentResource
            WorkspaceEnvironmentCollection collection = machineLearningWorkspace.GetWorkspaceEnvironments();

            // invoke the operation
            string name = "testEnvironment";
            MachineLearningEnvironmentContainerData data = new MachineLearningEnvironmentContainerData(new MachineLearningEnvironmentContainerProperties()
            {
                Description = "string",
                Properties =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
                Tags =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
            });
            ArmOperation<WorkspaceEnvironmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            WorkspaceEnvironmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
