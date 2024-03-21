// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_EventGridNamespacePermissionBindingCollection
    {
        // PermissionBindings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PermissionBindingsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PermissionBindings_Get.json
            // this example is just showing the usage of "PermissionBindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this EventGridNamespacePermissionBindingResource
            EventGridNamespacePermissionBindingCollection collection = eventGridNamespace.GetEventGridNamespacePermissionBindings();

            // invoke the operation
            string permissionBindingName = "examplePermissionBindingName1";
            EventGridNamespacePermissionBindingResource result = await collection.GetAsync(permissionBindingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridNamespacePermissionBindingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PermissionBindings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PermissionBindingsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PermissionBindings_Get.json
            // this example is just showing the usage of "PermissionBindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this EventGridNamespacePermissionBindingResource
            EventGridNamespacePermissionBindingCollection collection = eventGridNamespace.GetEventGridNamespacePermissionBindings();

            // invoke the operation
            string permissionBindingName = "examplePermissionBindingName1";
            bool result = await collection.ExistsAsync(permissionBindingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PermissionBindings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PermissionBindingsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PermissionBindings_Get.json
            // this example is just showing the usage of "PermissionBindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this EventGridNamespacePermissionBindingResource
            EventGridNamespacePermissionBindingCollection collection = eventGridNamespace.GetEventGridNamespacePermissionBindings();

            // invoke the operation
            string permissionBindingName = "examplePermissionBindingName1";
            NullableResponse<EventGridNamespacePermissionBindingResource> response = await collection.GetIfExistsAsync(permissionBindingName);
            EventGridNamespacePermissionBindingResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridNamespacePermissionBindingData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PermissionBindings_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PermissionBindingsCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PermissionBindings_CreateOrUpdate.json
            // this example is just showing the usage of "PermissionBindings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this EventGridNamespacePermissionBindingResource
            EventGridNamespacePermissionBindingCollection collection = eventGridNamespace.GetEventGridNamespacePermissionBindings();

            // invoke the operation
            string permissionBindingName = "examplePermissionBindingName1";
            EventGridNamespacePermissionBindingData data = new EventGridNamespacePermissionBindingData()
            {
                TopicSpaceName = "exampleTopicSpaceName1",
                Permission = PermissionType.Publisher,
                ClientGroupName = "exampleClientGroupName1",
            };
            ArmOperation<EventGridNamespacePermissionBindingResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, permissionBindingName, data);
            EventGridNamespacePermissionBindingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridNamespacePermissionBindingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PermissionBindings_ListByNamespace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PermissionBindingsListByNamespace()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PermissionBindings_ListByNamespace.json
            // this example is just showing the usage of "PermissionBindings_ListByNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "namespace123";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this EventGridNamespacePermissionBindingResource
            EventGridNamespacePermissionBindingCollection collection = eventGridNamespace.GetEventGridNamespacePermissionBindings();

            // invoke the operation and iterate over the result
            await foreach (EventGridNamespacePermissionBindingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridNamespacePermissionBindingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
