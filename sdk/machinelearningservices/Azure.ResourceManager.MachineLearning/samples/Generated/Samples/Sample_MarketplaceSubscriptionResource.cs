// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MarketplaceSubscriptionResource
    {
        // Delete Workspace Marketplace Subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceMarketplaceSubscription()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/MarketplaceSubscription/delete.json
            // this example is just showing the usage of "MarketplaceSubscriptions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MarketplaceSubscriptionResource created on azure
            // for more information of creating MarketplaceSubscriptionResource, please refer to the document of MarketplaceSubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier marketplaceSubscriptionResourceId = MarketplaceSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MarketplaceSubscriptionResource marketplaceSubscription = client.GetMarketplaceSubscriptionResource(marketplaceSubscriptionResourceId);

            // invoke the operation
            await marketplaceSubscription.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Marketplace Subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceMarketplaceSubscription()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/MarketplaceSubscription/get.json
            // this example is just showing the usage of "MarketplaceSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MarketplaceSubscriptionResource created on azure
            // for more information of creating MarketplaceSubscriptionResource, please refer to the document of MarketplaceSubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier marketplaceSubscriptionResourceId = MarketplaceSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MarketplaceSubscriptionResource marketplaceSubscription = client.GetMarketplaceSubscriptionResource(marketplaceSubscriptionResourceId);

            // invoke the operation
            MarketplaceSubscriptionResource result = await marketplaceSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MarketplaceSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Workspace Marketplace Subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateWorkspaceMarketplaceSubscription()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/MarketplaceSubscription/createOrUpdate.json
            // this example is just showing the usage of "MarketplaceSubscriptions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MarketplaceSubscriptionResource created on azure
            // for more information of creating MarketplaceSubscriptionResource, please refer to the document of MarketplaceSubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier marketplaceSubscriptionResourceId = MarketplaceSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MarketplaceSubscriptionResource marketplaceSubscription = client.GetMarketplaceSubscriptionResource(marketplaceSubscriptionResourceId);

            // invoke the operation
            MarketplaceSubscriptionData data = new MarketplaceSubscriptionData(new MarketplaceSubscriptionProperties("string"));
            ArmOperation<MarketplaceSubscriptionResource> lro = await marketplaceSubscription.UpdateAsync(WaitUntil.Completed, data);
            MarketplaceSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MarketplaceSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
