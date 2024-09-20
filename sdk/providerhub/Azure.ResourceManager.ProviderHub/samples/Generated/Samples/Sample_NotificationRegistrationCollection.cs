// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_NotificationRegistrationCollection
    {
        // NotificationRegistrations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NotificationRegistrationsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_Get.json
            // this example is just showing the usage of "NotificationRegistrations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this NotificationRegistrationResource
            NotificationRegistrationCollection collection = providerRegistration.GetNotificationRegistrations();

            // invoke the operation
            string notificationRegistrationName = "fooNotificationRegistration";
            NotificationRegistrationResource result = await collection.GetAsync(notificationRegistrationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NotificationRegistrations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_NotificationRegistrationsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_Get.json
            // this example is just showing the usage of "NotificationRegistrations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this NotificationRegistrationResource
            NotificationRegistrationCollection collection = providerRegistration.GetNotificationRegistrations();

            // invoke the operation
            string notificationRegistrationName = "fooNotificationRegistration";
            bool result = await collection.ExistsAsync(notificationRegistrationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NotificationRegistrations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_NotificationRegistrationsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_Get.json
            // this example is just showing the usage of "NotificationRegistrations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this NotificationRegistrationResource
            NotificationRegistrationCollection collection = providerRegistration.GetNotificationRegistrations();

            // invoke the operation
            string notificationRegistrationName = "fooNotificationRegistration";
            NullableResponse<NotificationRegistrationResource> response = await collection.GetIfExistsAsync(notificationRegistrationName);
            NotificationRegistrationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NotificationRegistrationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // NotificationRegistrations_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_NotificationRegistrationsCreateOrUpdate()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_CreateOrUpdate.json
            // this example is just showing the usage of "NotificationRegistrations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this NotificationRegistrationResource
            NotificationRegistrationCollection collection = providerRegistration.GetNotificationRegistrations();

            // invoke the operation
            string notificationRegistrationName = "fooNotificationRegistration";
            NotificationRegistrationData data = new NotificationRegistrationData()
            {
                Properties = new NotificationRegistrationProperties()
                {
                    NotificationMode = NotificationMode.EventHub,
                    MessageScope = MessageScope.RegisteredSubscriptions,
                    IncludedEvents =
{
"*/write","Microsoft.Contoso/employees/delete"
},
                    NotificationEndpoints =
{
new NotificationEndpoint()
{
NotificationDestination = new ResourceIdentifier("/subscriptions/ac6bcfb5-3dc1-491f-95a6-646b89bf3e88/resourceGroups/mgmtexp-eastus/providers/Microsoft.EventHub/namespaces/unitedstates-mgmtexpint/eventhubs/armlinkednotifications"),
Locations =
{
new AzureLocation(""),new AzureLocation("East US")
},
},new NotificationEndpoint()
{
NotificationDestination = new ResourceIdentifier("/subscriptions/ac6bcfb5-3dc1-491f-95a6-646b89bf3e88/resourceGroups/mgmtexp-northeurope/providers/Microsoft.EventHub/namespaces/europe-mgmtexpint/eventhubs/armlinkednotifications"),
Locations =
{
new AzureLocation("North Europe")
},
}
},
                },
            };
            ArmOperation<NotificationRegistrationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, notificationRegistrationName, data);
            NotificationRegistrationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NotificationRegistrations_ListByProviderRegistration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_NotificationRegistrationsListByProviderRegistration()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_ListByProviderRegistration.json
            // this example is just showing the usage of "NotificationRegistrations_ListByProviderRegistration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this NotificationRegistrationResource
            NotificationRegistrationCollection collection = providerRegistration.GetNotificationRegistrations();

            // invoke the operation and iterate over the result
            await foreach (NotificationRegistrationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NotificationRegistrationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
