// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudBareMetalMachineKeySetResource
    {
        // Get bare metal machine key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetBareMetalMachineKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/BareMetalMachineKeySets_Get.json
            // this example is just showing the usage of "BareMetalMachineKeySets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineKeySetResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineKeySetResource, please refer to the document of NetworkCloudBareMetalMachineKeySetResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            string bareMetalMachineKeySetName = "bareMetalMachineKeySetName";
            ResourceIdentifier networkCloudBareMetalMachineKeySetResourceId = NetworkCloudBareMetalMachineKeySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, bareMetalMachineKeySetName);
            NetworkCloudBareMetalMachineKeySetResource networkCloudBareMetalMachineKeySet = client.GetNetworkCloudBareMetalMachineKeySetResource(networkCloudBareMetalMachineKeySetResourceId);

            // invoke the operation
            NetworkCloudBareMetalMachineKeySetResource result = await networkCloudBareMetalMachineKeySet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudBareMetalMachineKeySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete bare metal machine key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteBareMetalMachineKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/BareMetalMachineKeySets_Delete.json
            // this example is just showing the usage of "BareMetalMachineKeySets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineKeySetResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineKeySetResource, please refer to the document of NetworkCloudBareMetalMachineKeySetResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            string bareMetalMachineKeySetName = "bareMetalMachineKeySetName";
            ResourceIdentifier networkCloudBareMetalMachineKeySetResourceId = NetworkCloudBareMetalMachineKeySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, bareMetalMachineKeySetName);
            NetworkCloudBareMetalMachineKeySetResource networkCloudBareMetalMachineKeySet = client.GetNetworkCloudBareMetalMachineKeySetResource(networkCloudBareMetalMachineKeySetResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachineKeySet.DeleteAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Patch bare metal machine key set of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchBareMetalMachineKeySetOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/BareMetalMachineKeySets_Patch.json
            // this example is just showing the usage of "BareMetalMachineKeySets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineKeySetResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineKeySetResource, please refer to the document of NetworkCloudBareMetalMachineKeySetResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            string bareMetalMachineKeySetName = "bareMetalMachineKeySetName";
            ResourceIdentifier networkCloudBareMetalMachineKeySetResourceId = NetworkCloudBareMetalMachineKeySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, bareMetalMachineKeySetName);
            NetworkCloudBareMetalMachineKeySetResource networkCloudBareMetalMachineKeySet = client.GetNetworkCloudBareMetalMachineKeySetResource(networkCloudBareMetalMachineKeySetResourceId);

            // invoke the operation
            NetworkCloudBareMetalMachineKeySetPatch patch = new NetworkCloudBareMetalMachineKeySetPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                ExpireOn = DateTimeOffset.Parse("2022-12-31T23:59:59.008Z"),
                JumpHostsAllowed =
{
IPAddress.Parse("192.0.2.1"),IPAddress.Parse("192.0.2.5")
},
                UserList =
{
new KeySetUser("userABC",new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm"))
{
Description = "Needs access for troubleshooting as a part of the support team",
UserPrincipalName = "userABC@contoso.com",
},new KeySetUser("userXYZ",new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm"))
{
Description = "Needs access for troubleshooting as a part of the support team",
UserPrincipalName = "userABC@contoso.com",
}
},
            };
            ArmOperation<NetworkCloudBareMetalMachineKeySetResource> lro = await networkCloudBareMetalMachineKeySet.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudBareMetalMachineKeySetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudBareMetalMachineKeySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
