// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SecurityInsights.Samples
{
    public partial class Sample_SecurityInsightsHuntRelationResource
    {
        // Get a hunt relation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAHuntRelation()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/hunts/GetHuntRelationById.json
            // this example is just showing the usage of "HuntRelations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsHuntRelationResource created on azure
            // for more information of creating SecurityInsightsHuntRelationResource, please refer to the document of SecurityInsightsHuntRelationResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string huntId = "163e7b2a-a2ec-4041-aaba-d878a38f265f";
            string huntRelationId = "2216d0e1-91e3-4902-89fd-d2df8c535096";
            ResourceIdentifier securityInsightsHuntRelationResourceId = SecurityInsightsHuntRelationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, huntId, huntRelationId);
            SecurityInsightsHuntRelationResource securityInsightsHuntRelation = client.GetSecurityInsightsHuntRelationResource(securityInsightsHuntRelationResourceId);

            // invoke the operation
            SecurityInsightsHuntRelationResource result = await securityInsightsHuntRelation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityInsightsHuntRelationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a hunt relation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAHuntRelation()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/hunts/DeleteHuntRelation.json
            // this example is just showing the usage of "HuntRelations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsHuntRelationResource created on azure
            // for more information of creating SecurityInsightsHuntRelationResource, please refer to the document of SecurityInsightsHuntRelationResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string huntId = "163e7b2a-a2ec-4041-aaba-d878a38f265f";
            string huntRelationId = "2216d0e1-91e3-4902-89fd-d2df8c535096";
            ResourceIdentifier securityInsightsHuntRelationResourceId = SecurityInsightsHuntRelationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, huntId, huntRelationId);
            SecurityInsightsHuntRelationResource securityInsightsHuntRelation = client.GetSecurityInsightsHuntRelationResource(securityInsightsHuntRelationResourceId);

            // invoke the operation
            await securityInsightsHuntRelation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Creates or updates a hunt relation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatesOrUpdatesAHuntRelation()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/hunts/CreateHuntRelation.json
            // this example is just showing the usage of "HuntRelations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsHuntRelationResource created on azure
            // for more information of creating SecurityInsightsHuntRelationResource, please refer to the document of SecurityInsightsHuntRelationResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string huntId = "163e7b2a-a2ec-4041-aaba-d878a38f265f";
            string huntRelationId = "2216d0e1-91e3-4902-89fd-d2df8c535096";
            ResourceIdentifier securityInsightsHuntRelationResourceId = SecurityInsightsHuntRelationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, huntId, huntRelationId);
            SecurityInsightsHuntRelationResource securityInsightsHuntRelation = client.GetSecurityInsightsHuntRelationResource(securityInsightsHuntRelationResourceId);

            // invoke the operation
            SecurityInsightsHuntRelationData data = new SecurityInsightsHuntRelationData()
            {
                RelatedResourceId = new ResourceIdentifier("/subscriptions/bd794837-4d29-4647-9105-6339bfdb4e6a/resourceGroups/mms-eus/providers/Microsoft.OperationalInsights/workspaces/avdvirint/providers/Microsoft.SecurityInsights/Bookmarks/2216d0e1-91e3-4902-89fd-d2df8c535096"),
                Labels =
{
"Test Label"
},
            };
            ArmOperation<SecurityInsightsHuntRelationResource> lro = await securityInsightsHuntRelation.UpdateAsync(WaitUntil.Completed, data);
            SecurityInsightsHuntRelationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityInsightsHuntRelationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
