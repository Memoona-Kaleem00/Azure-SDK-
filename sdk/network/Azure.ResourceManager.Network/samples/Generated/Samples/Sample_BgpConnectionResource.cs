// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_BgpConnectionResource
    {
        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualHubBgpConnectionGet.json
            // this example is just showing the usage of "VirtualHubBgpConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BgpConnectionResource created on azure
            // for more information of creating BgpConnectionResource, please refer to the document of BgpConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            string connectionName = "conn1";
            ResourceIdentifier bgpConnectionResourceId = BgpConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, connectionName);
            BgpConnectionResource bgpConnection = client.GetBgpConnectionResource(bgpConnectionResourceId);

            // invoke the operation
            BgpConnectionResource result = await bgpConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BgpConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubRouteTableV2Put
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VirtualHubRouteTableV2Put()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualHubBgpConnectionPut.json
            // this example is just showing the usage of "VirtualHubBgpConnection_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BgpConnectionResource created on azure
            // for more information of creating BgpConnectionResource, please refer to the document of BgpConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            string connectionName = "conn1";
            ResourceIdentifier bgpConnectionResourceId = BgpConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, connectionName);
            BgpConnectionResource bgpConnection = client.GetBgpConnectionResource(bgpConnectionResourceId);

            // invoke the operation
            BgpConnectionData data = new BgpConnectionData()
            {
                PeerAsn = 20000,
                PeerIP = "192.168.1.5",
                HubVirtualNetworkConnectionId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1/hubVirtualNetworkConnections/hubVnetConn1"),
            };
            ArmOperation<BgpConnectionResource> lro = await bgpConnection.UpdateAsync(WaitUntil.Completed, data);
            BgpConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BgpConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubRouteTableV2Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VirtualHubRouteTableV2Delete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualHubBgpConnectionDelete.json
            // this example is just showing the usage of "VirtualHubBgpConnection_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BgpConnectionResource created on azure
            // for more information of creating BgpConnectionResource, please refer to the document of BgpConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            string connectionName = "conn1";
            ResourceIdentifier bgpConnectionResourceId = BgpConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, connectionName);
            BgpConnectionResource bgpConnection = client.GetBgpConnectionResource(bgpConnectionResourceId);

            // invoke the operation
            await bgpConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VirtualRouterPeerListLearnedRoutes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubBgpConnectionLearnedRoutes_VirtualRouterPeerListLearnedRoutes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualRouterPeerListLearnedRoute.json
            // this example is just showing the usage of "VirtualHubBgpConnections_ListLearnedRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BgpConnectionResource created on azure
            // for more information of creating BgpConnectionResource, please refer to the document of BgpConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string hubName = "virtualRouter1";
            string connectionName = "peer1";
            ResourceIdentifier bgpConnectionResourceId = BgpConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, connectionName);
            BgpConnectionResource bgpConnection = client.GetBgpConnectionResource(bgpConnectionResourceId);

            // invoke the operation
            ArmOperation<IDictionary<string, IList<PeerRoute>>> lro = await bgpConnection.GetVirtualHubBgpConnectionLearnedRoutesAsync(WaitUntil.Completed);
            IDictionary<string, IList<PeerRoute>> result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualRouterPeerListAdvertisedRoutes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubBgpConnectionAdvertisedRoutes_VirtualRouterPeerListAdvertisedRoutes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualRouterPeerListAdvertisedRoute.json
            // this example is just showing the usage of "VirtualHubBgpConnections_ListAdvertisedRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BgpConnectionResource created on azure
            // for more information of creating BgpConnectionResource, please refer to the document of BgpConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string hubName = "virtualRouter1";
            string connectionName = "peer1";
            ResourceIdentifier bgpConnectionResourceId = BgpConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, connectionName);
            BgpConnectionResource bgpConnection = client.GetBgpConnectionResource(bgpConnectionResourceId);

            // invoke the operation
            ArmOperation<IDictionary<string, IList<PeerRoute>>> lro = await bgpConnection.GetVirtualHubBgpConnectionAdvertisedRoutesAsync(WaitUntil.Completed);
            IDictionary<string, IList<PeerRoute>> result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
