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
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Samples
{
    public partial class Sample_ViewResourceFormatCollection
    {
        // Views_ListByHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ViewsListByHub()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/ViewsListByHub.json
            // this example is just showing the usage of "Views_ListByHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this ViewResourceFormatResource
            ViewResourceFormatCollection collection = hub.GetViewResourceFormats();

            // invoke the operation and iterate over the result
            string userId = "*";
            await foreach (ViewResourceFormatResource item in collection.GetAllAsync(userId))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ViewResourceFormatData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Views_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ViewsCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/ViewsCreateOrUpdate.json
            // this example is just showing the usage of "Views_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this ViewResourceFormatResource
            ViewResourceFormatCollection collection = hub.GetViewResourceFormats();

            // invoke the operation
            string viewName = "testView";
            ViewResourceFormatData data = new ViewResourceFormatData()
            {
                UserId = "testUser",
                DisplayName =
{
["en"] = "some name",
},
                Definition = "{\\\"isProfileType\\\":false,\\\"profileTypes\\\":[],\\\"widgets\\\":[],\\\"style\\\":[]}",
            };
            ArmOperation<ViewResourceFormatResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, viewName, data);
            ViewResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ViewResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Views_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ViewsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/ViewsGet.json
            // this example is just showing the usage of "Views_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this ViewResourceFormatResource
            ViewResourceFormatCollection collection = hub.GetViewResourceFormats();

            // invoke the operation
            string viewName = "testView";
            string userId = "*";
            ViewResourceFormatResource result = await collection.GetAsync(viewName, userId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ViewResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Views_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ViewsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/ViewsGet.json
            // this example is just showing the usage of "Views_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this ViewResourceFormatResource
            ViewResourceFormatCollection collection = hub.GetViewResourceFormats();

            // invoke the operation
            string viewName = "testView";
            string userId = "*";
            bool result = await collection.ExistsAsync(viewName, userId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Views_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ViewsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/ViewsGet.json
            // this example is just showing the usage of "Views_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this ViewResourceFormatResource
            ViewResourceFormatCollection collection = hub.GetViewResourceFormats();

            // invoke the operation
            string viewName = "testView";
            string userId = "*";
            NullableResponse<ViewResourceFormatResource> response = await collection.GetIfExistsAsync(viewName, userId);
            ViewResourceFormatResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ViewResourceFormatData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
