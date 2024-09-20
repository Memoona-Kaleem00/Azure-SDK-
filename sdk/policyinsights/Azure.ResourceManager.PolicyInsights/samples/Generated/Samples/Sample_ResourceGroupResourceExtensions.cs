// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PolicyInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PolicyInsights.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // Query at resource group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPolicyTrackedResourceQueryResults_QueryAtResourceGroupScope()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/preview/2018-07-01-preview/examples/PolicyTrackedResources_QueryResourceGroupScope.json
            // this example is just showing the usage of "PolicyTrackedResources_ListQueryResultsForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyTrackedResourceType policyTrackedResourceType = PolicyTrackedResourceType.Default;
            await foreach (PolicyTrackedResourceRecord item in resourceGroupResource.GetPolicyTrackedResourceQueryResultsAsync(policyTrackedResourceType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Query at resource group scope using query parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPolicyTrackedResourceQueryResults_QueryAtResourceGroupScopeUsingQueryParameters()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/preview/2018-07-01-preview/examples/PolicyTrackedResources_QueryResourceGroupScopeWithFilterAndTop.json
            // this example is just showing the usage of "PolicyTrackedResources_ListQueryResultsForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyTrackedResourceType policyTrackedResourceType = PolicyTrackedResourceType.Default;
            await foreach (PolicyTrackedResourceRecord item in resourceGroupResource.GetPolicyTrackedResourceQueryResultsAsync(policyTrackedResourceType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Query at resource group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPolicyEventQueryResults_QueryAtResourceGroupScope()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyEvents_QueryResourceGroupScope.json
            // this example is just showing the usage of "PolicyEvents_ListQueryResultsForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyEventType policyEventType = PolicyEventType.Default;
            await foreach (PolicyEvent item in resourceGroupResource.GetPolicyEventQueryResultsAsync(policyEventType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Query at resource group scope with next link
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPolicyEventQueryResults_QueryAtResourceGroupScopeWithNextLink()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyEvents_QueryResourceGroupScopeNextLink.json
            // this example is just showing the usage of "PolicyEvents_ListQueryResultsForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyEventType policyEventType = PolicyEventType.Default;
            await foreach (PolicyEvent item in resourceGroupResource.GetPolicyEventQueryResultsAsync(policyEventType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Query latest at resource group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPolicyStateQueryResults_QueryLatestAtResourceGroupScope()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyStates_QueryResourceGroupScope.json
            // this example is just showing the usage of "PolicyStates_ListQueryResultsForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyStateType policyStateType = PolicyStateType.Latest;
            await foreach (PolicyState item in resourceGroupResource.GetPolicyStateQueryResultsAsync(policyStateType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Query latest at resource group scope with next link
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPolicyStateQueryResults_QueryLatestAtResourceGroupScopeWithNextLink()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyStates_QueryResourceGroupScopeNextLink.json
            // this example is just showing the usage of "PolicyStates_ListQueryResultsForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyStateType policyStateType = PolicyStateType.Latest;
            await foreach (PolicyState item in resourceGroupResource.GetPolicyStateQueryResultsAsync(policyStateType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Summarize at resource group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SummarizePolicyStates_SummarizeAtResourceGroupScope()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyStates_SummarizeResourceGroupScope.json
            // this example is just showing the usage of "PolicyStates_SummarizeForResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            PolicyStateSummaryType policyStateSummaryType = PolicyStateSummaryType.Latest;
            await foreach (PolicySummary item in resourceGroupResource.SummarizePolicyStatesAsync(policyStateSummaryType))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Trigger evaluations for all resources in a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TriggerPolicyStateEvaluation_TriggerEvaluationsForAllResourcesInAResourceGroup()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyStates_TriggerResourceGroupEvaluation.json
            // this example is just showing the usage of "PolicyStates_TriggerResourceGroupEvaluation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            await resourceGroupResource.TriggerPolicyStateEvaluationAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Check policy restrictions at resource group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckPolicyRestrictions_CheckPolicyRestrictionsAtResourceGroupScope()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2022-03-01/examples/PolicyRestrictions_CheckAtResourceGroupScope.json
            // this example is just showing the usage of "PolicyRestrictions_CheckAtResourceGroupScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "vmRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            CheckPolicyRestrictionsContent content = new CheckPolicyRestrictionsContent(new CheckRestrictionsResourceDetails(BinaryData.FromObjectAsJson(new Dictionary<string, object>()
            {
                ["type"] = "Microsoft.Compute/virtualMachines",
                ["properties"] = new Dictionary<string, object>()
                {
                    ["priority"] = "Spot"
                }
            }))
            {
                ApiVersion = "2019-12-01",
            })
            {
                PendingFields =
{
new PendingField("name")
{
Values =
{
"myVMName"
},
},new PendingField("location")
{
Values =
{
"eastus","westus","westus2","westeurope"
},
},new PendingField("tags")
},
            };
            CheckPolicyRestrictionsResult result = await resourceGroupResource.CheckPolicyRestrictionsAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
