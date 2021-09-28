﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network.Tests.Helpers;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.WebPubSub.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.WebPubSub.Tests
{
    public class PrivateEndpointConnectionTests : WebPubHubServiceClientTestBase
    {
        private ResourceGroup _resourceGroup;
        private WebPubSubResource _webPubSub;
        private string _webPubSubName;

        private ResourceIdentifier _resourceGroupIdentifier;

        public PrivateEndpointConnectionTests(bool isAsync) : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task GlobalSetUp()
        {
            var rgLro = await GlobalClient.DefaultSubscription.GetResourceGroups().CreateOrUpdateAsync(SessionRecording.GenerateAssetName("WebPubSubRG-"), new ResourceGroupData(Location.WestUS2));
            ResourceGroup rg = rgLro.Value;
            _resourceGroupIdentifier = rg.Id;
            _webPubSubName = SessionRecording.GenerateAssetName("WebPubSub-");

            // Create WebPubSub ConfigData
            IList<LiveTraceCategory> categories = new List<LiveTraceCategory>();
            categories.Add(new LiveTraceCategory("category-01", "true"));

            IDictionary<string, IList<EventHandlerTemplate>> items = new Dictionary<string, IList<EventHandlerTemplate>>();
            List<EventHandlerTemplate> eventHandlerTemplates = new List<EventHandlerTemplate>();
            //eventHandlerTemplates.Add(new EventHandlerTemplate("xn--0zwm56d.com"));
            eventHandlerTemplates.Add(new EventHandlerTemplate("http://directreach.com/domain/xn--0zwm56d.com/") { SystemEventPattern = "&quot;connect&quot;" });
            items.Add("key", eventHandlerTemplates);

            ACLAction aCLAction = new ACLAction("Deny");
            IList<WebPubSubRequestType> allow = new List<WebPubSubRequestType>();
            IList<WebPubSubRequestType> deny = new List<WebPubSubRequestType>();
            //allow.Add(new WebPubSubRequestType("ClientConnectionValue"));
            deny.Add(new WebPubSubRequestType("RESTAPI"));
            NetworkACL publicNetwork = new NetworkACL(allow, deny);
            IList<PrivateEndpointACL> privateEndpoints = new List<PrivateEndpointACL>();

            WebPubSubResourceData data = new WebPubSubResourceData(Location.WestUS2)
            {
                Sku = new ResourceSku("Standard_S1"),
                LiveTraceConfiguration = new LiveTraceConfiguration("true", categories),
                EventHandler = new EventHandlerSettings(items),
                NetworkACLs = new WebPubSubNetworkACLs(aCLAction, publicNetwork, privateEndpoints),
            };

            // Create WebPubSub
            _webPubSub = await (await rg.GetWebPubSubResources().CreateOrUpdateAsync(_webPubSubName, data)).WaitForCompletionAsync();
            StopSessionRecording();
        }

        [SetUp]
        public async Task TestSetUp()
        {
            var client = GetArmClient();
            _resourceGroup = await client.GetResourceGroup(_resourceGroupIdentifier).GetAsync();
        }

        [TearDown]
        public async Task TestTearDown()
        {
            var privateEndpointConnectionlist = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            foreach (var item in privateEndpointConnectionlist)
            {
                await item.DeleteAsync();
            }
        }

        public async Task CreatePrivateEndpointConnection(string privateEndPointName)
        {
            //create vnet
            string vnetName = SessionRecording.GenerateAssetName("vnet-");
            var vnetData = new VirtualNetworkData()
            {
                Location = "westus2",
                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.10.0.0/16", }
                },
                Subnets =
                {
                    new SubnetData() { Name = "subnet01", AddressPrefix = "10.10.1.0/24", },
                    new SubnetData() { Name = "subnet02", AddressPrefix = "10.10.2.0/24", PrivateEndpointNetworkPolicies = "Disabled", }
                },
            };
            var vnetContainer = _resourceGroup.GetVirtualNetworks();
            var vnet = await vnetContainer.CreateOrUpdateAsync(vnetName, vnetData);

            //create private endpoint (privateEndpoint of WebPubSUb will be generated automatically)
            var privateEndPointData = new PrivateEndpointData()
            {
                Subnet = new SubnetData() { Id = $"{vnet.Value.Id}" + "/subnets/subnet02" },
                Location = "westus2",
                PrivateLinkServiceConnections =
                {
                    new PrivateLinkServiceConnection()
                    {
                        Name = privateEndPointName,
                        PrivateLinkServiceId = _webPubSub.Data.Id.ToString(),
                        GroupIds = { "webpubsub" },
                    }
                },
            };
            var privateEndPointContainer = _resourceGroup.GetPrivateEndpoints();
            var privateEndPointLro = await (await privateEndPointContainer.CreateOrUpdateAsync(privateEndPointName, privateEndPointData)).WaitForCompletionAsync();
        }

        [Test]
        [RecordedTest]
        public async Task Get()
        {
            string privateEndPointName = SessionRecording.GenerateAssetName("privateEndPoint-");
            await CreatePrivateEndpointConnection(privateEndPointName);
            var list = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            var PrivateEndpointConnection = await _webPubSub.GetPrivateEndpointConnections().GetAsync(list[0].Data.Name);
            Assert.NotNull(PrivateEndpointConnection.Value.Data);
            Assert.AreEqual("Approved", PrivateEndpointConnection.Value.Data.PrivateLinkServiceConnectionState.Status.ToString());
        }

        [Test]
        [RecordedTest]
        public async Task GetAll()
        {
            var list = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            Assert.AreEqual(0, list.Count);
            string privateEndPointName = SessionRecording.GenerateAssetName("privateEndPoint-");
            await CreatePrivateEndpointConnection(privateEndPointName);
            list = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        [RecordedTest]
        public async Task CheckIfExist()
        {
            string privateEndPointName = SessionRecording.GenerateAssetName("privateEndPoint-");
            await CreatePrivateEndpointConnection(privateEndPointName);
            var list = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            Assert.True(_webPubSub.GetPrivateEndpointConnections().CheckIfExists(list[0].Data.Name));
            Assert.False(_webPubSub.GetPrivateEndpointConnections().CheckIfExists(list[0].Data.Name + "01"));
        }

        [Test]
        [RecordedTest]
        public async Task Delete()
        {
            string privateEndPointName = SessionRecording.GenerateAssetName("privateEndPoint-");
            await CreatePrivateEndpointConnection(privateEndPointName);
            var list = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            Assert.AreEqual(1, list.Count);
            foreach (var item in list)
            {
                await item.DeleteAsync();
            }
            list = await _webPubSub.GetPrivateEndpointConnections().GetAllAsync().ToEnumerableAsync();
            Assert.AreEqual(0, list.Count);
        }
    }
}
