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
    public partial class Sample_RouteTableResource
    {
        // Delete route table
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRouteTable()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RouteTableDelete.json
            // this example is just showing the usage of "RouteTables_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteTableResource created on azure
            // for more information of creating RouteTableResource, please refer to the document of RouteTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeTableName = "testrt";
            ResourceIdentifier routeTableResourceId = RouteTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeTableName);
            RouteTableResource routeTable = client.GetRouteTableResource(routeTableResourceId);

            // invoke the operation
            await routeTable.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get route table
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRouteTable()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RouteTableGet.json
            // this example is just showing the usage of "RouteTables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteTableResource created on azure
            // for more information of creating RouteTableResource, please refer to the document of RouteTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeTableName = "testrt";
            ResourceIdentifier routeTableResourceId = RouteTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeTableName);
            RouteTableResource routeTable = client.GetRouteTableResource(routeTableResourceId);

            // invoke the operation
            RouteTableResource result = await routeTable.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update route table tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateRouteTableTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RouteTableUpdateTags.json
            // this example is just showing the usage of "RouteTables_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteTableResource created on azure
            // for more information of creating RouteTableResource, please refer to the document of RouteTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeTableName = "testrt";
            ResourceIdentifier routeTableResourceId = RouteTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeTableName);
            RouteTableResource routeTable = client.GetRouteTableResource(routeTableResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            RouteTableResource result = await routeTable.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all route tables
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRouteTables_ListAllRouteTables()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RouteTableListAll.json
            // this example is just showing the usage of "RouteTables_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (RouteTableResource item in subscriptionResource.GetRouteTablesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RouteTableData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
