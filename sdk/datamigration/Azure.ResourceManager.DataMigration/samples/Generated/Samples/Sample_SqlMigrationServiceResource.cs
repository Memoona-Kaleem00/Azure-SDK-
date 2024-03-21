// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_SqlMigrationServiceResource
    {
        // Get Migration Service.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMigrationService()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/GetMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            SqlMigrationServiceResource result = await sqlMigrationService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlMigrationServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete SQL Migration Service.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteSQLMigrationService()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/DeleteMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            await sqlMigrationService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update SQL Migration Service.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateSQLMigrationService()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/UpdateMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "testagent";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            SqlMigrationServicePatch patch = new SqlMigrationServicePatch()
            {
                Tags =
{
["mytag"] = "myval",
},
            };
            ArmOperation<SqlMigrationServiceResource> lro = await sqlMigrationService.UpdateAsync(WaitUntil.Completed, patch);
            SqlMigrationServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlMigrationServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Retrieve the List of Authentication Keys.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAuthKeys_RetrieveTheListOfAuthenticationKeys()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ListAuthKeysMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_listAuthKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            AuthenticationKeys result = await sqlMigrationService.GetAuthKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Regenerate the of Authentication Keys.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateAuthKeys_RegenerateTheOfAuthenticationKeys()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/RegenAuthKeysMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_regenerateAuthKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            RegenAuthKeys regenAuthKeys = new RegenAuthKeys()
            {
                KeyName = "authKey1",
            };
            RegenAuthKeys result = await sqlMigrationService.RegenerateAuthKeysAsync(regenAuthKeys);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Delete the integration runtime node.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteNode_DeleteTheIntegrationRuntimeNode()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/DeleteIntegrationRuntimeNode.json
            // this example is just showing the usage of "SqlMigrationServices_deleteNode" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            DeleteNode deleteNode = new DeleteNode()
            {
                NodeName = "nodeName",
                IntegrationRuntimeName = "IRName",
            };
            DeleteNode result = await sqlMigrationService.DeleteNodeAsync(deleteNode);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List database migrations attached to the service.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMigrations_ListDatabaseMigrationsAttachedToTheService()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ListMigrationsByMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_listMigrations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation and iterate over the result
            await foreach (DatabaseMigration item in sqlMigrationService.GetMigrationsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Retrieve the Monitoring Data.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMonitoringData_RetrieveTheMonitoringData()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/GetMonitorDataMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_listMonitoringData" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlMigrationServiceResource created on azure
            // for more information of creating SqlMigrationServiceResource, please refer to the document of SqlMigrationServiceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlMigrationServiceName = "service1";
            ResourceIdentifier sqlMigrationServiceResourceId = SqlMigrationServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlMigrationServiceName);
            SqlMigrationServiceResource sqlMigrationService = client.GetSqlMigrationServiceResource(sqlMigrationServiceResourceId);

            // invoke the operation
            IntegrationRuntimeMonitoringData result = await sqlMigrationService.GetMonitoringDataAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Services in the Subscriptions.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSqlMigrationServices_GetServicesInTheSubscriptions()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ListBySubscriptionMigrationService.json
            // this example is just showing the usage of "SqlMigrationServices_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Sql/managedInstances/managedInstance1";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SqlMigrationServiceResource item in subscriptionResource.GetSqlMigrationServicesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlMigrationServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
