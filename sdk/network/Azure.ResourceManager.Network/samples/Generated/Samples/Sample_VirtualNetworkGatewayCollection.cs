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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualNetworkGatewayCollection
    {
        // UpdateVirtualNetworkGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateVirtualNetworkGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkGatewayUpdate.json
            // this example is just showing the usage of "VirtualNetworkGateways_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "vpngw";
            VirtualNetworkGatewayData data = new VirtualNetworkGatewayData()
            {
                IPConfigurations =
{
new VirtualNetworkGatewayIPConfiguration()
{
PrivateIPAllocationMethod = NetworkIPAllocationMethod.Dynamic,
SubnetId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/GatewaySubnet"),
PublicIPAddressId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/gwpip"),
Name = "gwipconfig1",
}
},
                GatewayType = VirtualNetworkGatewayType.Vpn,
                VpnType = VpnType.RouteBased,
                EnableBgp = false,
                Active = false,
                DisableIPSecReplayProtection = false,
                Sku = new VirtualNetworkGatewaySku()
                {
                    Name = VirtualNetworkGatewaySkuName.VpnGw1,
                    Tier = VirtualNetworkGatewaySkuTier.VpnGw1,
                },
                VpnClientConfiguration = new VpnClientConfiguration()
                {
                    VpnClientRootCertificates =
{
},
                    VpnClientRevokedCertificates =
{
},
                    VpnClientProtocols =
{
VpnClientProtocol.OpenVpn
},
                    RadiusServers =
{
new RadiusServer("10.2.0.0")
{
RadiusServerScore = 20,
RadiusServerSecret = "radiusServerSecret",
}
},
                },
                BgpSettings = new BgpSettings()
                {
                    Asn = 65515,
                    BgpPeeringAddress = "10.0.1.30",
                    PeerWeight = 0,
                },
                CustomRoutesAddressPrefixes =
{
"101.168.0.6/32"
},
                EnableDnsForwarding = true,
                NatRules =
{
new VirtualNetworkGatewayNatRuleData()
{
VpnNatRuleType = VpnNatRuleType.Static,
Mode = VpnNatRuleMode.EgressSnat,
InternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "10.10.0.0/24",
}
},
ExternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "50.0.0.0/24",
}
},
IPConfigurationId = "",
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/natRules/natRule1"),
Name = "natRule1",
},new VirtualNetworkGatewayNatRuleData()
{
VpnNatRuleType = VpnNatRuleType.Static,
Mode = VpnNatRuleMode.IngressSnat,
InternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "20.10.0.0/24",
}
},
ExternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "30.0.0.0/24",
}
},
IPConfigurationId = "",
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/natRules/natRule2"),
Name = "natRule2",
}
},
                EnableBgpRouteTranslationForNat = false,
                AllowVirtualWanTraffic = false,
                AllowRemoteVnetTraffic = false,
                Location = new AzureLocation("centralus"),
            };
            ArmOperation<VirtualNetworkGatewayResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkGatewayName, data);
            VirtualNetworkGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdateVirtualNetworkScalableGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateVirtualNetworkScalableGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkScalableGatewayUpdate.json
            // this example is just showing the usage of "VirtualNetworkGateways_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "ergw";
            VirtualNetworkGatewayData data = new VirtualNetworkGatewayData()
            {
                IPConfigurations =
{
new VirtualNetworkGatewayIPConfiguration()
{
PrivateIPAllocationMethod = NetworkIPAllocationMethod.Static,
SubnetId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/GatewaySubnet"),
PublicIPAddressId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/gwpip"),
Name = "gwipconfig1",
}
},
                GatewayType = VirtualNetworkGatewayType.ExpressRoute,
                VpnType = VpnType.PolicyBased,
                EnableBgp = false,
                Active = false,
                DisableIPSecReplayProtection = false,
                Sku = new VirtualNetworkGatewaySku()
                {
                    Name = new VirtualNetworkGatewaySkuName("ErGwScale"),
                    Tier = new VirtualNetworkGatewaySkuTier("ErGwScale"),
                },
                VpnClientConfiguration = null,
                BgpSettings = null,
                NatRules =
{
new VirtualNetworkGatewayNatRuleData()
{
VpnNatRuleType = VpnNatRuleType.Static,
Mode = VpnNatRuleMode.EgressSnat,
InternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "10.10.0.0/24",
}
},
ExternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "50.0.0.0/24",
}
},
IPConfigurationId = "",
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/ergw/natRules/natRule1"),
Name = "natRule1",
},new VirtualNetworkGatewayNatRuleData()
{
VpnNatRuleType = VpnNatRuleType.Static,
Mode = VpnNatRuleMode.IngressSnat,
InternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "20.10.0.0/24",
}
},
ExternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "30.0.0.0/24",
}
},
IPConfigurationId = "",
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/ergw/natRules/natRule2"),
Name = "natRule2",
}
},
                EnableBgpRouteTranslationForNat = false,
                AllowVirtualWanTraffic = false,
                AllowRemoteVnetTraffic = false,
                Location = new AzureLocation("centralus"),
            };
            ArmOperation<VirtualNetworkGatewayResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkGatewayName, data);
            VirtualNetworkGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualNetworkGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualNetworkGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkGatewayGet.json
            // this example is just showing the usage of "VirtualNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "vpngw";
            VirtualNetworkGatewayResource result = await collection.GetAsync(virtualNetworkGatewayName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualNetworkGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualNetworkGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkGatewayGet.json
            // this example is just showing the usage of "VirtualNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "vpngw";
            bool result = await collection.ExistsAsync(virtualNetworkGatewayName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetVirtualNetworkGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetVirtualNetworkGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkGatewayGet.json
            // this example is just showing the usage of "VirtualNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "vpngw";
            NullableResponse<VirtualNetworkGatewayResource> response = await collection.GetIfExistsAsync(virtualNetworkGatewayName);
            VirtualNetworkGatewayResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkGatewayData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // GetVirtualNetworkScalableGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualNetworkScalableGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkScalableGatewayGet.json
            // this example is just showing the usage of "VirtualNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "ergw";
            VirtualNetworkGatewayResource result = await collection.GetAsync(virtualNetworkGatewayName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualNetworkScalableGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualNetworkScalableGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkScalableGatewayGet.json
            // this example is just showing the usage of "VirtualNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "ergw";
            bool result = await collection.ExistsAsync(virtualNetworkGatewayName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetVirtualNetworkScalableGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetVirtualNetworkScalableGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkScalableGatewayGet.json
            // this example is just showing the usage of "VirtualNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation
            string virtualNetworkGatewayName = "ergw";
            NullableResponse<VirtualNetworkGatewayResource> response = await collection.GetIfExistsAsync(virtualNetworkGatewayName);
            VirtualNetworkGatewayResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkGatewayData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ListVirtualNetworkGatewaysinResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVirtualNetworkGatewaysinResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualNetworkGatewayList.json
            // this example is just showing the usage of "VirtualNetworkGateways_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualNetworkGatewayResource
            VirtualNetworkGatewayCollection collection = resourceGroupResource.GetVirtualNetworkGateways();

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkGatewayResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkGatewayData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
