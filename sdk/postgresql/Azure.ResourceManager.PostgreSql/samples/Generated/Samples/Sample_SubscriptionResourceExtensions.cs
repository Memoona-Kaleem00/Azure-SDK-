// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // CapabilitiesList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExecuteLocationBasedCapabilities_CapabilitiesList()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/CapabilitiesByLocation.json
            // this example is just showing the usage of "LocationBasedCapabilities_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation locationName = new AzureLocation("westus");
            await foreach (PostgreSqlFlexibleServerCapabilityProperties item in subscriptionResource.ExecuteLocationBasedCapabilitiesAsync(locationName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckPostgreSqlFlexibleServerNameAvailability_NameAvailability()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/CheckNameAvailability.json
            // this example is just showing the usage of "CheckNameAvailability_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            PostgreSqlFlexibleServerNameAvailabilityContent content = new PostgreSqlFlexibleServerNameAvailabilityContent("name1")
            {
                ResourceType = new ResourceType("Microsoft.DBforPostgreSQL/flexibleServers"),
            };
            PostgreSqlFlexibleServerNameAvailabilityResult result = await subscriptionResource.CheckPostgreSqlFlexibleServerNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckPostgreSqlFlexibleServerNameAvailabilityWithLocation_NameAvailability()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/CheckNameAvailabilityLocationBased.json
            // this example is just showing the usage of "CheckNameAvailabilityWithLocation_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("westus");
            PostgreSqlFlexibleServerNameAvailabilityContent content = new PostgreSqlFlexibleServerNameAvailabilityContent("name1")
            {
                ResourceType = new ResourceType("Microsoft.DBforPostgreSQL/flexibleServers"),
            };
            PostgreSqlFlexibleServerNameAvailabilityResult result = await subscriptionResource.CheckPostgreSqlFlexibleServerNameAvailabilityWithLocationAsync(locationName, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualNetworkSubnetUsageList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExecuteVirtualNetworkSubnetUsage_VirtualNetworkSubnetUsageList()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/VirtualNetworkSubnetUsage.json
            // this example is just showing the usage of "VirtualNetworkSubnetUsage_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("westus");
            PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter = new PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter()
            {
                VirtualNetworkArmResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/testvnet"),
            };
            PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult result = await subscriptionResource.ExecuteVirtualNetworkSubnetUsageAsync(locationName, postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
