// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_ProfileResource
    {
        // AFDProfiles_ListResourceUsage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFrontDoorProfileResourceUsages_AFDProfilesListResourceUsage()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDProfiles_ListResourceUsage.json
            // this example is just showing the usage of "FrontDoorProfiles_ListResourceUsage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation and iterate over the result
            await foreach (FrontDoorUsage item in profile.GetFrontDoorProfileResourceUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AFDProfiles_CheckHostNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckFrontDoorProfileHostNameAvailability_AFDProfilesCheckHostNameAvailability()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDProfiles_CheckHostNameAvailability.json
            // this example is just showing the usage of "FrontDoorProfiles_CheckHostNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            HostNameAvailabilityContent content = new HostNameAvailabilityContent("www.someDomain.net");
            CdnNameAvailabilityResult result = await profile.CheckFrontDoorProfileHostNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LogAnalytics_GetLogAnalyticsRankings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLogAnalyticsRankings_LogAnalyticsGetLogAnalyticsRankings()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/LogAnalytics_GetLogAnalyticsRankings.json
            // this example is just showing the usage of "LogAnalytics_GetLogAnalyticsRankings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            ProfileResourceGetLogAnalyticsRankingsOptions options = new ProfileResourceGetLogAnalyticsRankingsOptions(rankings: new LogRanking[]
            {
LogRanking.Uri
            }, metrics: new LogRankingMetric[]
            {
LogRankingMetric.ClientRequestCount
            }, maxRanking: 5, dateTimeBegin: DateTimeOffset.Parse("2020-11-04T06:49:27.554Z"), dateTimeEnd: DateTimeOffset.Parse("2020-11-04T09:49:27.554Z"))
            { };
            RankingsResponse result = await profile.GetLogAnalyticsRankingsAsync(options);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LogAnalytics_GetLogAnalyticsLocations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLogAnalyticsLocations_LogAnalyticsGetLogAnalyticsLocations()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/LogAnalytics_GetLogAnalyticsLocations.json
            // this example is just showing the usage of "LogAnalytics_GetLogAnalyticsLocations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            ContinentsResponse result = await profile.GetLogAnalyticsLocationsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // LogAnalytics_GetLogAnalyticsResources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLogAnalyticsResources_LogAnalyticsGetLogAnalyticsResources()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/LogAnalytics_GetLogAnalyticsResources.json
            // this example is just showing the usage of "LogAnalytics_GetLogAnalyticsResources" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            ResourcesResponse result = await profile.GetLogAnalyticsResourcesAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // LogAnalytics_GetWafLogAnalyticsRankings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetWafLogAnalyticsRankings_LogAnalyticsGetWafLogAnalyticsRankings()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/LogAnalytics_GetWafLogAnalyticsRankings.json
            // this example is just showing the usage of "LogAnalytics_GetWafLogAnalyticsRankings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            ProfileResourceGetWafLogAnalyticsRankingsOptions options = new ProfileResourceGetWafLogAnalyticsRankingsOptions(metrics: new WafMetric[]
            {
WafMetric.ClientRequestCount
            }, dateTimeBegin: DateTimeOffset.Parse("2020-11-04T06:49:27.554Z"), dateTimeEnd: DateTimeOffset.Parse("2020-11-04T09:49:27.554Z"), maxRanking: 5, rankings: new WafRankingType[]
            {
WafRankingType.RuleId
            })
            { };
            WafRankingsResponse result = await profile.GetWafLogAnalyticsRankingsAsync(options);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Profiles_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetProfiles_ProfilesList()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_List.json
            // this example is just showing the usage of "Profiles_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (ProfileResource item in subscriptionResource.GetProfilesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Profiles_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ProfilesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_Get.json
            // this example is just showing the usage of "Profiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            ProfileResource result = await profile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Profiles_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ProfilesUpdate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_Update.json
            // this example is just showing the usage of "Profiles_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            ProfilePatch patch = new ProfilePatch()
            {
                Tags =
{
["additionalProperties"] = "Tag1",
},
            };
            ArmOperation<ProfileResource> lro = await profile.UpdateAsync(WaitUntil.Completed, patch);
            ProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Profiles_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ProfilesDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_Delete.json
            // this example is just showing the usage of "Profiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            await profile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Profiles_GenerateSsoUri
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateSsoUri_ProfilesGenerateSsoUri()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_GenerateSsoUri.json
            // this example is just showing the usage of "Profiles_GenerateSsoUri" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            SsoUri result = await profile.GenerateSsoUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Profiles_ListSupportedOptimizationTypes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSupportedOptimizationTypes_ProfilesListSupportedOptimizationTypes()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_ListSupportedOptimizationTypes.json
            // this example is just showing the usage of "Profiles_ListSupportedOptimizationTypes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation
            SupportedOptimizationTypesListResult result = await profile.GetSupportedOptimizationTypesAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Profiles_ListResourceUsage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetResourceUsages_ProfilesListResourceUsage()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Profiles_ListResourceUsage.json
            // this example is just showing the usage of "Profiles_ListResourceUsage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // invoke the operation and iterate over the result
            await foreach (CdnUsage item in profile.GetResourceUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
