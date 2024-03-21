// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_AvsPrivateCloudCollection
    {
        // PrivateClouds_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateCloudsList()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_List.json
            // this example is just showing the usage of "PrivateClouds_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation and iterate over the result
            await foreach (AvsPrivateCloudResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsPrivateCloudData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateClouds_List_Stretched
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateCloudsListStretched()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_List_Stretched.json
            // this example is just showing the usage of "PrivateClouds_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation and iterate over the result
            await foreach (AvsPrivateCloudResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsPrivateCloudData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateClouds_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateCloudsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_Get.json
            // this example is just showing the usage of "PrivateClouds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            AvsPrivateCloudResource result = await collection.GetAsync(privateCloudName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateClouds_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateCloudsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_Get.json
            // this example is just showing the usage of "PrivateClouds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            bool result = await collection.ExistsAsync(privateCloudName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateClouds_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateCloudsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_Get.json
            // this example is just showing the usage of "PrivateClouds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            NullableResponse<AvsPrivateCloudResource> response = await collection.GetIfExistsAsync(privateCloudName);
            AvsPrivateCloudResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsPrivateCloudData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateClouds_Get_Stretched
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateCloudsGetStretched()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_Get_Stretched.json
            // this example is just showing the usage of "PrivateClouds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            AvsPrivateCloudResource result = await collection.GetAsync(privateCloudName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateClouds_Get_Stretched
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateCloudsGetStretched()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_Get_Stretched.json
            // this example is just showing the usage of "PrivateClouds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            bool result = await collection.ExistsAsync(privateCloudName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateClouds_Get_Stretched
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateCloudsGetStretched()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_Get_Stretched.json
            // this example is just showing the usage of "PrivateClouds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            NullableResponse<AvsPrivateCloudResource> response = await collection.GetIfExistsAsync(privateCloudName);
            AvsPrivateCloudResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsPrivateCloudData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateClouds_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateCloudsCreateOrUpdate()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_CreateOrUpdate.json
            // this example is just showing the usage of "PrivateClouds_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            AvsPrivateCloudData data = new AvsPrivateCloudData(new AzureLocation("eastus2"), new AvsSku("AV36"))
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                ManagementCluster = new AvsManagementCluster()
                {
                    ClusterSize = 4,
                },
                NetworkBlock = "192.168.48.0/22",
                Tags =
{
},
            };
            ArmOperation<AvsPrivateCloudResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateCloudName, data);
            AvsPrivateCloudResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateClouds_CreateOrUpdate_Stretched
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateCloudsCreateOrUpdateStretched()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-03-01/examples/PrivateClouds_CreateOrUpdate_Stretched.json
            // this example is just showing the usage of "PrivateClouds_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AvsPrivateCloudResource
            AvsPrivateCloudCollection collection = resourceGroupResource.GetAvsPrivateClouds();

            // invoke the operation
            string privateCloudName = "cloud1";
            AvsPrivateCloudData data = new AvsPrivateCloudData(new AzureLocation("eastus2"), new AvsSku("AV36"))
            {
                ManagementCluster = new AvsManagementCluster()
                {
                    ClusterSize = 4,
                },
                Availability = new PrivateCloudAvailabilityProperties()
                {
                    Strategy = AvailabilityStrategy.DualZone,
                    Zone = 1,
                    SecondaryZone = 2,
                },
                NetworkBlock = "192.168.48.0/22",
                Tags =
{
},
            };
            ArmOperation<AvsPrivateCloudResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateCloudName, data);
            AvsPrivateCloudResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
