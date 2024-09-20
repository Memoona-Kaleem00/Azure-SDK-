// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudBmcKeySetCollection
    {
        // List baseboard management controller key sets of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListBaseboardManagementControllerKeySetsOfTheCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BmcKeySets_ListByCluster.json
            // this example is just showing the usage of "BmcKeySets_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // get the collection of this NetworkCloudBmcKeySetResource
            NetworkCloudBmcKeySetCollection collection = networkCloudCluster.GetNetworkCloudBmcKeySets();

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudBmcKeySetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudBmcKeySetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get baseboard management controller key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetBaseboardManagementControllerKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BmcKeySets_Get.json
            // this example is just showing the usage of "BmcKeySets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // get the collection of this NetworkCloudBmcKeySetResource
            NetworkCloudBmcKeySetCollection collection = networkCloudCluster.GetNetworkCloudBmcKeySets();

            // invoke the operation
            string bmcKeySetName = "bmcKeySetName";
            NetworkCloudBmcKeySetResource result = await collection.GetAsync(bmcKeySetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudBmcKeySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get baseboard management controller key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetBaseboardManagementControllerKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BmcKeySets_Get.json
            // this example is just showing the usage of "BmcKeySets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // get the collection of this NetworkCloudBmcKeySetResource
            NetworkCloudBmcKeySetCollection collection = networkCloudCluster.GetNetworkCloudBmcKeySets();

            // invoke the operation
            string bmcKeySetName = "bmcKeySetName";
            bool result = await collection.ExistsAsync(bmcKeySetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get baseboard management controller key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetBaseboardManagementControllerKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BmcKeySets_Get.json
            // this example is just showing the usage of "BmcKeySets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // get the collection of this NetworkCloudBmcKeySetResource
            NetworkCloudBmcKeySetCollection collection = networkCloudCluster.GetNetworkCloudBmcKeySets();

            // invoke the operation
            string bmcKeySetName = "bmcKeySetName";
            NullableResponse<NetworkCloudBmcKeySetResource> response = await collection.GetIfExistsAsync(bmcKeySetName);
            NetworkCloudBmcKeySetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudBmcKeySetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update baseboard management controller key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateBaseboardManagementControllerKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BmcKeySets_Create.json
            // this example is just showing the usage of "BmcKeySets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // get the collection of this NetworkCloudBmcKeySetResource
            NetworkCloudBmcKeySetCollection collection = networkCloudCluster.GetNetworkCloudBmcKeySets();

            // invoke the operation
            string bmcKeySetName = "bmcKeySetName";
            NetworkCloudBmcKeySetData data = new NetworkCloudBmcKeySetData(new AzureLocation("location"), new ExtendedLocation("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ExtendedLocation/customLocations/clusterExtendedLocationName", "CustomLocation"), "f110271b-XXXX-4163-9b99-214d91660f0e", DateTimeOffset.Parse("2022-12-31T23:59:59.008Z"), BmcKeySetPrivilegeLevel.Administrator, new KeySetUser[]
            {
new KeySetUser("userABC",new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm"))
{
Description = "Needs access for troubleshooting as a part of the support team",
},new KeySetUser("userXYZ",new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm"))
{
Description = "Needs access for troubleshooting as a part of the support team",
}
            })
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
            };
            ArmOperation<NetworkCloudBmcKeySetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, bmcKeySetName, data);
            NetworkCloudBmcKeySetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudBmcKeySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
