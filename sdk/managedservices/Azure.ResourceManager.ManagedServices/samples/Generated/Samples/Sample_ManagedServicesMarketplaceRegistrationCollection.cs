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
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Samples
{
    public partial class Sample_ManagedServicesMarketplaceRegistrationCollection
    {
        // Get Registration Definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationDefinitions()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetMarketplaceRegistrationDefinitions.json
            // this example is just showing the usage of "MarketplaceRegistrationDefinitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesMarketplaceRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesMarketplaceRegistrationCollection collection = client.GetManagedServicesMarketplaceRegistrations(scopeId);

            // invoke the operation and iterate over the result
            string filter = "planIdentifier eq 'publisher.offerIdentifier.planName.version'";
            await foreach (ManagedServicesMarketplaceRegistrationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesMarketplaceRegistrationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registration Definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistrationDefinitions()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetMarketplaceRegistrationDefinition.json
            // this example is just showing the usage of "MarketplaceRegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesMarketplaceRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesMarketplaceRegistrationCollection collection = client.GetManagedServicesMarketplaceRegistrations(scopeId);

            // invoke the operation
            string marketplaceIdentifier = "publisher.product.planName.version";
            ManagedServicesMarketplaceRegistrationResource result = await collection.GetAsync(marketplaceIdentifier);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesMarketplaceRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registration Definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRegistrationDefinitions()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetMarketplaceRegistrationDefinition.json
            // this example is just showing the usage of "MarketplaceRegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesMarketplaceRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesMarketplaceRegistrationCollection collection = client.GetManagedServicesMarketplaceRegistrations(scopeId);

            // invoke the operation
            string marketplaceIdentifier = "publisher.product.planName.version";
            bool result = await collection.ExistsAsync(marketplaceIdentifier);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Registration Definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRegistrationDefinitions()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetMarketplaceRegistrationDefinition.json
            // this example is just showing the usage of "MarketplaceRegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesMarketplaceRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesMarketplaceRegistrationCollection collection = client.GetManagedServicesMarketplaceRegistrations(scopeId);

            // invoke the operation
            string marketplaceIdentifier = "publisher.product.planName.version";
            NullableResponse<ManagedServicesMarketplaceRegistrationResource> response = await collection.GetIfExistsAsync(marketplaceIdentifier);
            ManagedServicesMarketplaceRegistrationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesMarketplaceRegistrationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
