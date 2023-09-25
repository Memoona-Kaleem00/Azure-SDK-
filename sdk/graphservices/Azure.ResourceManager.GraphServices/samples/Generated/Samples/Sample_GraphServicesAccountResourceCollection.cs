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
using Azure.ResourceManager.GraphServices;
using Azure.ResourceManager.GraphServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GraphServices.Samples
{
    public partial class Sample_GraphServicesAccountResourceCollection
    {
        // Create or update account resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CreateOrUpdateAccountResource()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_List.json
            // this example is just showing the usage of "Accounts_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this GraphServicesAccountResource
            GraphServicesAccountResourceCollection collection = resourceGroupResource.GetGraphServicesAccountResources();

            // invoke the operation and iterate over the result
            await foreach (GraphServicesAccountResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GraphServicesAccountResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get accounts
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAccounts()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this GraphServicesAccountResource
            GraphServicesAccountResourceCollection collection = resourceGroupResource.GetGraphServicesAccountResources();

            // invoke the operation
            string resourceName = "11111111-aaaa-1111-bbbb-111111111111";
            GraphServicesAccountResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GraphServicesAccountResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get accounts
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAccounts()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this GraphServicesAccountResource
            GraphServicesAccountResourceCollection collection = resourceGroupResource.GetGraphServicesAccountResources();

            // invoke the operation
            string resourceName = "11111111-aaaa-1111-bbbb-111111111111";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get accounts
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAccounts()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this GraphServicesAccountResource
            GraphServicesAccountResourceCollection collection = resourceGroupResource.GetGraphServicesAccountResources();

            // invoke the operation
            string resourceName = "11111111-aaaa-1111-bbbb-111111111111";
            NullableResponse<GraphServicesAccountResource> response = await collection.GetIfExistsAsync(resourceName);
            GraphServicesAccountResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GraphServicesAccountResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create Account resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAccountResource()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Create.json
            // this example is just showing the usage of "Accounts_CreateAndUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this GraphServicesAccountResource
            GraphServicesAccountResourceCollection collection = resourceGroupResource.GetGraphServicesAccountResources();

            // invoke the operation
            string resourceName = "11111111-aaaa-1111-bbbb-1111111111111";
            GraphServicesAccountResourceData data = new GraphServicesAccountResourceData(new AzureLocation("placeholder"), new GraphServicesAccountResourceProperties("11111111-aaaa-1111-bbbb-111111111111"));
            ArmOperation<GraphServicesAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            GraphServicesAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GraphServicesAccountResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
