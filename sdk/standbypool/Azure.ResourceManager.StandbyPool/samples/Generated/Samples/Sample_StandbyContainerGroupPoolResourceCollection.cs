// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StandbyPool.Models;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyContainerGroupPoolResourceCollection
    {
        // StandbyContainerGroupPools_ListByResourceGroup - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StandbyContainerGroupPoolsListByResourceGroupGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation and iterate over the result
            await foreach (StandbyContainerGroupPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // StandbyContainerGroupPools_ListByResourceGroup - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StandbyContainerGroupPoolsListByResourceGroupGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_ListByResourceGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation and iterate over the result
            await foreach (StandbyContainerGroupPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // StandbyContainerGroupPools_Get - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StandbyContainerGroupPoolsGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            StandbyContainerGroupPoolResource result = await collection.GetAsync(standbyContainerGroupPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyContainerGroupPools_Get - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StandbyContainerGroupPoolsGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            bool result = await collection.ExistsAsync(standbyContainerGroupPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // StandbyContainerGroupPools_Get - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_StandbyContainerGroupPoolsGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            NullableResponse<StandbyContainerGroupPoolResource> response = await collection.GetIfExistsAsync(standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // StandbyContainerGroupPools_Get - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StandbyContainerGroupPoolsGetGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            StandbyContainerGroupPoolResource result = await collection.GetAsync(standbyContainerGroupPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyContainerGroupPools_Get - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StandbyContainerGroupPoolsGetGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            bool result = await collection.ExistsAsync(standbyContainerGroupPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // StandbyContainerGroupPools_Get - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_StandbyContainerGroupPoolsGetGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            NullableResponse<StandbyContainerGroupPoolResource> response = await collection.GetIfExistsAsync(standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // StandbyContainerGroupPools_CreateOrUpdate - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StandbyContainerGroupPoolsCreateOrUpdateGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            StandbyContainerGroupPoolResourceData data = new StandbyContainerGroupPoolResourceData(new AzureLocation("West US"))
            {
                ElasticityProfile = new StandbyContainerGroupPoolElasticityProfile(688)
                {
                    RefillPolicy = RefillPolicy.Always,
                },
                ContainerGroupProperties = new ContainerGroupProperties(new ContainerGroupProfile(new ResourceIdentifier("/subscriptions/8CC31D61-82D7-4B2B-B9DC-6B924DE7D229/resourceGroups/rgstandbypool/providers/Microsoft.ContainerInstance/containerGroupProfiles/cgProfile"))
                {
                    Revision = 1,
                })
                {
                    SubnetIds =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/8cf6c1b6-c80f-437c-87ad-45fbaff54f73/resourceGroups/rgstandbypool/providers/Microsoft.Network/virtualNetworks/cgSubnet/subnets/cgSubnet"),
}
},
                },
                Tags =
{
},
            };
            ArmOperation<StandbyContainerGroupPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, standbyContainerGroupPoolName, data);
            StandbyContainerGroupPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyContainerGroupPools_CreateOrUpdate - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StandbyContainerGroupPoolsCreateOrUpdateGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyContainerGroupPools_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyContainerGroupPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolResourceCollection collection = resourceGroupResource.GetStandbyContainerGroupPoolResources();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            StandbyContainerGroupPoolResourceData data = new StandbyContainerGroupPoolResourceData(new AzureLocation("West US"));
            ArmOperation<StandbyContainerGroupPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, standbyContainerGroupPoolName, data);
            StandbyContainerGroupPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
