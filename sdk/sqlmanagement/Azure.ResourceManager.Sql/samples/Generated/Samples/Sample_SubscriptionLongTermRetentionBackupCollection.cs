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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SubscriptionLongTermRetentionBackupCollection
    {
        // Get the long term retention backup.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-05-01-preview/examples/LongTermRetentionBackupGet.json
            // this example is just showing the usage of "LongTermRetentionBackups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionLongTermRetentionBackupResource
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            SubscriptionLongTermRetentionBackupCollection collection = subscriptionResource.GetSubscriptionLongTermRetentionBackups(locationName, longTermRetentionServerName, longTermRetentionDatabaseName);

            // invoke the operation
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            SubscriptionLongTermRetentionBackupResource result = await collection.GetAsync(backupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LongTermRetentionBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the long term retention backup.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-05-01-preview/examples/LongTermRetentionBackupGet.json
            // this example is just showing the usage of "LongTermRetentionBackups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionLongTermRetentionBackupResource
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            SubscriptionLongTermRetentionBackupCollection collection = subscriptionResource.GetSubscriptionLongTermRetentionBackups(locationName, longTermRetentionServerName, longTermRetentionDatabaseName);

            // invoke the operation
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            bool result = await collection.ExistsAsync(backupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the long term retention backup.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-05-01-preview/examples/LongTermRetentionBackupGet.json
            // this example is just showing the usage of "LongTermRetentionBackups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionLongTermRetentionBackupResource
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            SubscriptionLongTermRetentionBackupCollection collection = subscriptionResource.GetSubscriptionLongTermRetentionBackups(locationName, longTermRetentionServerName, longTermRetentionDatabaseName);

            // invoke the operation
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            NullableResponse<SubscriptionLongTermRetentionBackupResource> response = await collection.GetIfExistsAsync(backupName);
            SubscriptionLongTermRetentionBackupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LongTermRetentionBackupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get all long term retention backups under the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllLongTermRetentionBackupsUnderTheDatabase()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-05-01-preview/examples/LongTermRetentionBackupListByDatabase.json
            // this example is just showing the usage of "LongTermRetentionBackups_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionLongTermRetentionBackupResource
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            SubscriptionLongTermRetentionBackupCollection collection = subscriptionResource.GetSubscriptionLongTermRetentionBackups(locationName, longTermRetentionServerName, longTermRetentionDatabaseName);

            // invoke the operation and iterate over the result
            await foreach (SubscriptionLongTermRetentionBackupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LongTermRetentionBackupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
