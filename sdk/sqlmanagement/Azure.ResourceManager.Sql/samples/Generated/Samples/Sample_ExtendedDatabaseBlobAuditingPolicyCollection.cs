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
    public partial class Sample_ExtendedDatabaseBlobAuditingPolicyCollection
    {
        // List extended auditing settings of a database
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListExtendedAuditingSettingsOfADatabase()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseExtendedAuditingSettingsList.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-6852";
            string serverName = "blobauditingtest-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation and iterate over the result
            await foreach (ExtendedDatabaseBlobAuditingPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExtendedDatabaseBlobAuditingPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get an extended database's blob auditing policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnExtendedDatabaseSBlobAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedDatabaseBlobAuditingGet.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-6852";
            string serverName = "blobauditingtest-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedDatabaseBlobAuditingPolicyResource result = await collection.GetAsync(blobAuditingPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedDatabaseBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an extended database's blob auditing policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnExtendedDatabaseSBlobAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedDatabaseBlobAuditingGet.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-6852";
            string serverName = "blobauditingtest-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            bool result = await collection.ExistsAsync(blobAuditingPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an extended database's blob auditing policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnExtendedDatabaseSBlobAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedDatabaseBlobAuditingGet.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-6852";
            string serverName = "blobauditingtest-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            NullableResponse<ExtendedDatabaseBlobAuditingPolicyResource> response = await collection.GetIfExistsAsync(blobAuditingPolicyName);
            ExtendedDatabaseBlobAuditingPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExtendedDatabaseBlobAuditingPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update an extended database's azure monitor auditing policy with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAnExtendedDatabaseSAzureMonitorAuditingPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedDatabaseAzureMonitorAuditingCreateMin.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedDatabaseBlobAuditingPolicyData data = new ExtendedDatabaseBlobAuditingPolicyData()
            {
                IsAzureMonitorTargetEnabled = true,
                State = BlobAuditingPolicyState.Enabled,
            };
            ArmOperation<ExtendedDatabaseBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            ExtendedDatabaseBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedDatabaseBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update an extended database's blob auditing policy with all parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAnExtendedDatabaseSBlobAuditingPolicyWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedDatabaseBlobAuditingCreateMax.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedDatabaseBlobAuditingPolicyData data = new ExtendedDatabaseBlobAuditingPolicyData()
            {
                PredicateExpression = "statement = 'select 1'",
                RetentionDays = 6,
                AuditActionsAndGroups =
{
"DATABASE_LOGOUT_GROUP","DATABASE_ROLE_MEMBER_CHANGE_GROUP","UPDATE on database::TestDatabaseName by public"
},
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
                QueueDelayMs = 4000,
                State = BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
            };
            ArmOperation<ExtendedDatabaseBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            ExtendedDatabaseBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedDatabaseBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update an extended database's blob auditing policy with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAnExtendedDatabaseSBlobAuditingPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedDatabaseBlobAuditingCreateMin.json
            // this example is just showing the usage of "ExtendedDatabaseBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this ExtendedDatabaseBlobAuditingPolicyResource
            ExtendedDatabaseBlobAuditingPolicyCollection collection = sqlDatabase.GetExtendedDatabaseBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedDatabaseBlobAuditingPolicyData data = new ExtendedDatabaseBlobAuditingPolicyData()
            {
                State = BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };
            ArmOperation<ExtendedDatabaseBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            ExtendedDatabaseBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedDatabaseBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
