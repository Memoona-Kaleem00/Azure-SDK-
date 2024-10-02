// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlTriggerResource
    {
        // CosmosDBSqlTriggerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBSqlTriggerGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBSqlTriggerGet.json
            // this example is just showing the usage of "SqlResources_GetSqlTrigger" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlTriggerResource created on azure
            // for more information of creating CosmosDBSqlTriggerResource, please refer to the document of CosmosDBSqlTriggerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            string triggerName = "triggerName";
            ResourceIdentifier cosmosDBSqlTriggerResourceId = CosmosDBSqlTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName, triggerName);
            CosmosDBSqlTriggerResource cosmosDBSqlTrigger = client.GetCosmosDBSqlTriggerResource(cosmosDBSqlTriggerResourceId);

            // invoke the operation
            CosmosDBSqlTriggerResource result = await cosmosDBSqlTrigger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlTriggerCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBSqlTriggerCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBSqlTriggerCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlTrigger" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlTriggerResource created on azure
            // for more information of creating CosmosDBSqlTriggerResource, please refer to the document of CosmosDBSqlTriggerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            string triggerName = "triggerName";
            ResourceIdentifier cosmosDBSqlTriggerResourceId = CosmosDBSqlTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName, triggerName);
            CosmosDBSqlTriggerResource cosmosDBSqlTrigger = client.GetCosmosDBSqlTriggerResource(cosmosDBSqlTriggerResourceId);

            // invoke the operation
            CosmosDBSqlTriggerCreateOrUpdateContent content = new CosmosDBSqlTriggerCreateOrUpdateContent(new AzureLocation("placeholder"), new CosmosDBSqlTriggerResourceInfo("triggerName")
            {
                Body = "body",
                TriggerType = new CosmosDBSqlTriggerType("triggerType"),
                TriggerOperation = new CosmosDBSqlTriggerOperation("triggerOperation"),
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
            };
            ArmOperation<CosmosDBSqlTriggerResource> lro = await cosmosDBSqlTrigger.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBSqlTriggerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlTriggerDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBSqlTriggerDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBSqlTriggerDelete.json
            // this example is just showing the usage of "SqlResources_DeleteSqlTrigger" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlTriggerResource created on azure
            // for more information of creating CosmosDBSqlTriggerResource, please refer to the document of CosmosDBSqlTriggerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            string triggerName = "triggerName";
            ResourceIdentifier cosmosDBSqlTriggerResourceId = CosmosDBSqlTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName, triggerName);
            CosmosDBSqlTriggerResource cosmosDBSqlTrigger = client.GetCosmosDBSqlTriggerResource(cosmosDBSqlTriggerResourceId);

            // invoke the operation
            await cosmosDBSqlTrigger.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
