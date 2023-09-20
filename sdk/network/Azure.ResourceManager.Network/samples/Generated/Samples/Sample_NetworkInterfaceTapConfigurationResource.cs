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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkInterfaceTapConfigurationResource
    {
        // Delete tap configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteTapConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkInterfaceTapConfigurationDelete.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceTapConfigurationResource created on azure
            // for more information of creating NetworkInterfaceTapConfigurationResource, please refer to the document of NetworkInterfaceTapConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkInterfaceName = "test-networkinterface";
            string tapConfigurationName = "test-tapconfiguration";
            ResourceIdentifier networkInterfaceTapConfigurationResourceId = NetworkInterfaceTapConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName, tapConfigurationName);
            NetworkInterfaceTapConfigurationResource networkInterfaceTapConfiguration = client.GetNetworkInterfaceTapConfigurationResource(networkInterfaceTapConfigurationResourceId);

            // invoke the operation
            await networkInterfaceTapConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Network Interface Tap Configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkInterfaceTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkInterfaceTapConfigurationGet.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceTapConfigurationResource created on azure
            // for more information of creating NetworkInterfaceTapConfigurationResource, please refer to the document of NetworkInterfaceTapConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            string tapConfigurationName = "tapconfiguration1";
            ResourceIdentifier networkInterfaceTapConfigurationResourceId = NetworkInterfaceTapConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName, tapConfigurationName);
            NetworkInterfaceTapConfigurationResource networkInterfaceTapConfiguration = client.GetNetworkInterfaceTapConfigurationResource(networkInterfaceTapConfigurationResourceId);

            // invoke the operation
            NetworkInterfaceTapConfigurationResource result = await networkInterfaceTapConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceTapConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create Network Interface Tap Configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateNetworkInterfaceTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkInterfaceTapConfigurationCreate.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceTapConfigurationResource created on azure
            // for more information of creating NetworkInterfaceTapConfigurationResource, please refer to the document of NetworkInterfaceTapConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            string tapConfigurationName = "tapconfiguration1";
            ResourceIdentifier networkInterfaceTapConfigurationResourceId = NetworkInterfaceTapConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName, tapConfigurationName);
            NetworkInterfaceTapConfigurationResource networkInterfaceTapConfiguration = client.GetNetworkInterfaceTapConfigurationResource(networkInterfaceTapConfigurationResourceId);

            // invoke the operation
            NetworkInterfaceTapConfigurationData data = new NetworkInterfaceTapConfigurationData()
            {
                VirtualNetworkTap = new VirtualNetworkTapData()
                {
                    Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworkTaps/testvtap"),
                },
            };
            ArmOperation<NetworkInterfaceTapConfigurationResource> lro = await networkInterfaceTapConfiguration.UpdateAsync(WaitUntil.Completed, data);
            NetworkInterfaceTapConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceTapConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
