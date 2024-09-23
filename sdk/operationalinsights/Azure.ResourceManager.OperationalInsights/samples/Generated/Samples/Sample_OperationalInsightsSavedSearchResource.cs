// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsSavedSearchResource
    {
        // SavedSearchesDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SavedSearchesDelete()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/WorkspacesDeleteSavedSearches.json
            // this example is just showing the usage of "SavedSearches_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsSavedSearchResource created on azure
            // for more information of creating OperationalInsightsSavedSearchResource, please refer to the document of OperationalInsightsSavedSearchResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            ResourceIdentifier operationalInsightsSavedSearchResourceId = OperationalInsightsSavedSearchResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, savedSearchId);
            OperationalInsightsSavedSearchResource operationalInsightsSavedSearch = client.GetOperationalInsightsSavedSearchResource(operationalInsightsSavedSearchResourceId);

            // invoke the operation
            await operationalInsightsSavedSearch.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // SavedSearchCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SavedSearchCreateOrUpdate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/WorkspacesSavedSearchesCreateOrUpdate.json
            // this example is just showing the usage of "SavedSearches_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsSavedSearchResource created on azure
            // for more information of creating OperationalInsightsSavedSearchResource, please refer to the document of OperationalInsightsSavedSearchResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            ResourceIdentifier operationalInsightsSavedSearchResourceId = OperationalInsightsSavedSearchResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, savedSearchId);
            OperationalInsightsSavedSearchResource operationalInsightsSavedSearch = client.GetOperationalInsightsSavedSearchResource(operationalInsightsSavedSearchResourceId);

            // invoke the operation
            OperationalInsightsSavedSearchData data = new OperationalInsightsSavedSearchData("Saved Search Test Category", "Create or Update Saved Search Test", "Heartbeat | summarize Count() by Computer | take a")
            {
                FunctionAlias = "heartbeat_func",
                FunctionParameters = "a:int=1",
                Version = 2,
                Tags =
{
new OperationalInsightsTag("Group","Computer")
},
            };
            ArmOperation<OperationalInsightsSavedSearchResource> lro = await operationalInsightsSavedSearch.UpdateAsync(WaitUntil.Completed, data);
            OperationalInsightsSavedSearchResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsSavedSearchData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SavedSearchesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SavedSearchesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/WorkspacesSavedSearchesGet.json
            // this example is just showing the usage of "SavedSearches_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsSavedSearchResource created on azure
            // for more information of creating OperationalInsightsSavedSearchResource, please refer to the document of OperationalInsightsSavedSearchResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            ResourceIdentifier operationalInsightsSavedSearchResourceId = OperationalInsightsSavedSearchResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, savedSearchId);
            OperationalInsightsSavedSearchResource operationalInsightsSavedSearch = client.GetOperationalInsightsSavedSearchResource(operationalInsightsSavedSearchResourceId);

            // invoke the operation
            OperationalInsightsSavedSearchResource result = await operationalInsightsSavedSearch.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsSavedSearchData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
