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
    public partial class Sample_SecurityInsightsBillingStatisticResource
    {
        // Get a billing statistic.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetABillingStatistic()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/billingStatistics/GetBillingStatistic.json
            // this example is just showing the usage of "BillingStatistics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsBillingStatisticResource created on azure
            // for more information of creating SecurityInsightsBillingStatisticResource, please refer to the document of SecurityInsightsBillingStatisticResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string billingStatisticName = "sapSolutionUsage";
            ResourceIdentifier securityInsightsBillingStatisticResourceId = SecurityInsightsBillingStatisticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, billingStatisticName);
            SecurityInsightsBillingStatisticResource securityInsightsBillingStatistic = client.GetSecurityInsightsBillingStatisticResource(securityInsightsBillingStatisticResourceId);

            // invoke the operation
            SecurityInsightsBillingStatisticResource result = await securityInsightsBillingStatistic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityInsightsBillingStatisticData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
