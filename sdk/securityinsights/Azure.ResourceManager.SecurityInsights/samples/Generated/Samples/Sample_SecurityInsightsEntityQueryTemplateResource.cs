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
    public partial class Sample_SecurityInsightsEntityQueryTemplateResource
    {
        // Get an Activity entity query template.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnActivityEntityQueryTemplate()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/entityQueryTemplates/GetActivityEntityQueryTemplateById.json
            // this example is just showing the usage of "EntityQueryTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsEntityQueryTemplateResource created on azure
            // for more information of creating SecurityInsightsEntityQueryTemplateResource, please refer to the document of SecurityInsightsEntityQueryTemplateResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string entityQueryTemplateId = "07da3cc8-c8ad-4710-a44e-334cdcb7882b";
            ResourceIdentifier securityInsightsEntityQueryTemplateResourceId = SecurityInsightsEntityQueryTemplateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, entityQueryTemplateId);
            SecurityInsightsEntityQueryTemplateResource securityInsightsEntityQueryTemplate = client.GetSecurityInsightsEntityQueryTemplateResource(securityInsightsEntityQueryTemplateResourceId);

            // invoke the operation
            SecurityInsightsEntityQueryTemplateResource result = await securityInsightsEntityQueryTemplate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityInsightsEntityQueryTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
