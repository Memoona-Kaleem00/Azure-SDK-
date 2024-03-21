// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Batch;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // LocationGetQuotas
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBatchQuotas_LocationGetQuotas()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-02-01/examples/LocationGetQuotas.json
            // this example is just showing the usage of "Location_GetQuotas" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("japaneast");
            BatchLocationQuota result = await subscriptionResource.GetBatchQuotasAsync(locationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocationListVirtualMachineSkus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBatchSupportedVirtualMachineSkus_LocationListVirtualMachineSkus()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-02-01/examples/LocationListVirtualMachineSkus.json
            // this example is just showing the usage of "Location_ListSupportedVirtualMachineSkus" operation, for the dependent resources, they will have to be created separately.

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
            AzureLocation locationName = new AzureLocation("japaneast");
            await foreach (BatchSupportedSku item in subscriptionResource.GetBatchSupportedVirtualMachineSkusAsync(locationName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LocationListCloudServiceSkus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBatchSupportedCloudServiceSkus_LocationListCloudServiceSkus()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-02-01/examples/LocationListCloudServiceSkus.json
            // this example is just showing the usage of "Location_ListSupportedCloudServiceSkus" operation, for the dependent resources, they will have to be created separately.

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
            AzureLocation locationName = new AzureLocation("japaneast");
            await foreach (BatchSupportedSku item in subscriptionResource.GetBatchSupportedCloudServiceSkusAsync(locationName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LocationCheckNameAvailability_AlreadyExists
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckBatchNameAvailability_LocationCheckNameAvailabilityAlreadyExists()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-02-01/examples/LocationCheckNameAvailability_AlreadyExists.json
            // this example is just showing the usage of "Location_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("japaneast");
            BatchNameAvailabilityContent content = new BatchNameAvailabilityContent("existingaccountname");
            BatchNameAvailabilityResult result = await subscriptionResource.CheckBatchNameAvailabilityAsync(locationName, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocationCheckNameAvailability_Available
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckBatchNameAvailability_LocationCheckNameAvailabilityAvailable()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-02-01/examples/LocationCheckNameAvailability_Available.json
            // this example is just showing the usage of "Location_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("japaneast");
            BatchNameAvailabilityContent content = new BatchNameAvailabilityContent("newaccountname");
            BatchNameAvailabilityResult result = await subscriptionResource.CheckBatchNameAvailabilityAsync(locationName, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
