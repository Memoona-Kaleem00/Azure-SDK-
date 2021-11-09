﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Tests.Scenario
{
    public class ManagedInstanceTests : SqlManagementClientBase
    {
        private ResourceGroup _resourceGroup;
        private ResourceIdentifier _resourceGroupIdentifier;
        private string SubnetId;

        public ManagedInstanceTests(bool isAsync)
            : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task GlobalSetUp()
        {
            var rgLro = await GlobalClient.GetDefaultSubscriptionAsync().Result.GetResourceGroups().CreateOrUpdateAsync(SessionRecording.GenerateAssetName("Sql-RG-"), new ResourceGroupData(Location.WestUS2));
            ResourceGroup resourceGroup = rgLro.Value;
            _resourceGroupIdentifier = resourceGroup.Id;

            //Prerequisites: 1. create NetworkSecurityGroup
            string networkSecurityGroupName = SessionRecording.GenerateAssetName("networkSecurityGroup-");
            NetworkSecurityGroupData networkSecurityGroupData = new NetworkSecurityGroupData()
            {
                Location = Location.WestUS2,
            };
            var networkSecurityGroup = await resourceGroup.GetNetworkSecurityGroups().CreateOrUpdateAsync(networkSecurityGroupName, networkSecurityGroupData);

            //2. create Route table
            string routeTableName = SessionRecording.GenerateAssetName("routeTable-");
            RouteTableData routeTableData = new RouteTableData()
            {
                Location = Location.WestUS2,
            };
            var routeTable = await resourceGroup.GetRouteTables().CreateOrUpdateAsync(routeTableName, routeTableData);

            //3. create Virtual network
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
                    new SubnetData()
                    {
                        Name = "ManagedInstance",
                        AddressPrefix = "10.10.2.0/24",
                        Delegations =
                        {
                            new Delegation() { ServiceName  = "Microsoft.Sql/managedInstances",Name="Microsoft.Sql/managedInstances" ,Type="Microsoft.Sql"}
                        },
                        RouteTable = new RouteTableData(){ Id = routeTable.Value.Data.Id.ToString() },
                        NetworkSecurityGroup = new NetworkSecurityGroupData(){ Id = networkSecurityGroup.Value.Data.Id.ToString() },
                    }
                },
            };
            var vnet = await resourceGroup.GetVirtualNetworks().CreateOrUpdateAsync(vnetName, vnetData);
            SubnetId = $"{vnet.Value.Data.Id.ToString()}/subnets/ManagedInstance";
            StopSessionRecording();
        }

        [SetUp]
        public async Task TestSetUp()
        {
            var client = GetArmClient();
            _resourceGroup = await client.GetResourceGroup(_resourceGroupIdentifier).GetAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            var list = await _resourceGroup.GetManagedInstances().GetAllAsync().ToEnumerableAsync();
            foreach (var item in list)
            {
                await item.DeleteAsync();
            }
        }

        private async Task<ManagedInstance> CreateOrUpdateManagedInstance(string managedInstanceName)
        {
            ManagedInstanceData data = new ManagedInstanceData(Location.WestUS2)
            {
                AdministratorLogin = $"admin-{managedInstanceName}",
                AdministratorLoginPassword = CreateGeneralPassword(),
                SubnetId = SubnetId,
                PublicDataEndpointEnabled = false,
                MaintenanceConfigurationId = "/subscriptions/db1ab6f0-4769-4b27-930e-01e2ef9c123c/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/SQL_Default",
                ProxyOverride = new ManagedInstanceProxyOverride("Proxy") { },
                TimezoneId = "UTC",
                StorageAccountType = new StorageAccountType("GRS"),
                ZoneRedundant = false,
            };
            var managedInstanceLro = await _resourceGroup.GetManagedInstances().CreateOrUpdateAsync(managedInstanceName, data);
            var managedInstance = managedInstanceLro.Value;
            return managedInstance;
        }

        [Test]
        [RecordedTest]
        public async Task CheckIfExist()
        {
            string managedInstanceName = Recording.GenerateAssetName("Managed-Instance-");
            await CreateOrUpdateManagedInstance(managedInstanceName);
            Assert.IsTrue(_resourceGroup.GetManagedInstances().CheckIfExists(managedInstanceName));
        }

        [Test]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            string managedInstanceName = Recording.GenerateAssetName("Managed-Instance-");
            var managedInstance = await CreateOrUpdateManagedInstance(managedInstanceName);
            Assert.IsNotNull(managedInstance.Data);
            Assert.AreEqual(managedInstanceName, managedInstance.Data.Name);
        }
        [Test]
        [RecordedTest]
        public async Task Delete()
        {
            string managedInstanceName = Recording.GenerateAssetName("Managed-Instance-");
            var managedInstance = await CreateOrUpdateManagedInstance(managedInstanceName);
            var list = await _resourceGroup.GetManagedInstances().GetAllAsync().ToEnumerableAsync();
            Assert.AreEqual(1,list.Count);

            await managedInstance.DeleteAsync();
            list = await _resourceGroup.GetManagedInstances().GetAllAsync().ToEnumerableAsync();
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        [RecordedTest]
        public async Task Get()
        {
            string managedInstanceName = Recording.GenerateAssetName("Managed-Instance-");
            await CreateOrUpdateManagedInstance(managedInstanceName);
            var managedInstance = await _resourceGroup.GetManagedInstances().GetAsync(managedInstanceName);
            Assert.IsNotNull(managedInstance.Value.Data);
            Assert.AreEqual(managedInstanceName, managedInstance.Value.Data.Name);
        }

        [Test]
        [RecordedTest]
        public async Task GetAll()
        {
            var list = await _resourceGroup.GetManagedInstances().GetAllAsync().ToEnumerableAsync();
            Assert.IsEmpty(list);
            string managedInstanceName = Recording.GenerateAssetName("Managed-Instance-");
            await CreateOrUpdateManagedInstance(managedInstanceName);
            list = await _resourceGroup.GetManagedInstances().GetAllAsync().ToEnumerableAsync();
            Assert.IsNotEmpty(list);
        }
    }
}
