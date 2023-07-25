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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ElasticPoolCollection
    {
        // Get all elastic pools in a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllElasticPoolsInAServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolListByServer.json
            // this example is just showing the usage of "ElasticPools_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation and iterate over the result
            await foreach (ElasticPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a Hyperscale elastic pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAHyperscaleElasticPool()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/HyperscaleElasticPoolGet.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolResource result = await collection.GetAsync(elasticPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a Hyperscale elastic pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAHyperscaleElasticPool()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/HyperscaleElasticPoolGet.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            bool result = await collection.ExistsAsync(elasticPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an elastic pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnElasticPool()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolGet.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolResource result = await collection.GetAsync(elasticPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an elastic pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnElasticPool()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolGet.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            bool result = await collection.ExistsAsync(elasticPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an elastic pool with Availability Zone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnElasticPoolWithAvailabilityZone()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/GetElasticPoolWithAvailabilityZone.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolResource result = await collection.GetAsync(elasticPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an elastic pool with Availability Zone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnElasticPoolWithAvailabilityZone()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/GetElasticPoolWithAvailabilityZone.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            bool result = await collection.ExistsAsync(elasticPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an elastic pool with preferred enclave type parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnElasticPoolWithPreferredEnclaveTypeParameter()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolGetWithPreferredEnclaveType.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolResource result = await collection.GetAsync(elasticPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an elastic pool with preferred enclave type parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnElasticPoolWithPreferredEnclaveTypeParameter()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolGetWithPreferredEnclaveType.json
            // this example is just showing the usage of "ElasticPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            bool result = await collection.ExistsAsync(elasticPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or Update an elastic pool with Availability Zone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAnElasticPoolWithAvailabilityZone()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/CreateElasticPoolWithAvailabilityZone.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"))
            {
                Sku = new SqlSku("HS_Gen5_4"),
                PerDatabaseSettings = new ElasticPoolPerDatabaseSettings()
                {
                    MinCapacity = 0.25,
                    MaxCapacity = 2,
                },
                IsZoneRedundant = true,
                AvailabilityZone = SqlAvailabilityZoneType.One,
            };
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update Hyperscale elastic pool with high availability replica count parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateHyperscaleElasticPoolWithHighAvailabilityReplicaCountParameter()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/HyperscaleElasticPoolCreateOrUpdateSetHighAvailabilityReplicaCount.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"))
            {
                Sku = new SqlSku("HS_Gen5_4"),
                HighAvailabilityReplicaCount = 2,
            };
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update elastic pool with all parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateElasticPoolWithAllParameter()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolCreateOrUpdateMax.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"))
            {
                Sku = new SqlSku("GP_Gen4_2")
                {
                    Tier = "GeneralPurpose",
                    Capacity = 2,
                },
                PerDatabaseSettings = new ElasticPoolPerDatabaseSettings()
                {
                    MinCapacity = 0.25,
                    MaxCapacity = 2,
                },
            };
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update elastic pool with maintenance configuration parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateElasticPoolWithMaintenanceConfigurationParameter()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolCreateOrUpdateSetMaintenanceConfiguration.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"))
            {
                MaintenanceConfigurationId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/SQL_JapanEast_1"),
            };
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update elastic pool with minimum parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateElasticPoolWithMinimumParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolCreateOrUpdateMin.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"));
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update elastic pool with preferred enclave type parameter as Default
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateElasticPoolWithPreferredEnclaveTypeParameterAsDefault()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolCreateWithDefaultPreferredEnclaveType.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"))
            {
                Sku = new SqlSku("GP_Gen5_4"),
                PreferredEnclaveType = SqlAlwaysEncryptedEnclaveType.Default,
            };
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update elastic pool with preferred enclave type parameter as VBS
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateElasticPoolWithPreferredEnclaveTypeParameterAsVBS()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/ElasticPoolCreateWithVBSPreferredEnclaveType.json
            // this example is just showing the usage of "ElasticPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-2369";
            string serverName = "sqlcrudtest-8069";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ElasticPoolResource
            ElasticPoolCollection collection = sqlServer.GetElasticPools();

            // invoke the operation
            string elasticPoolName = "sqlcrudtest-8102";
            ElasticPoolData data = new ElasticPoolData(new AzureLocation("Japan East"))
            {
                Sku = new SqlSku("GP_Gen5_4"),
                PreferredEnclaveType = SqlAlwaysEncryptedEnclaveType.Vbs,
            };
            ArmOperation<ElasticPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, elasticPoolName, data);
            ElasticPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
