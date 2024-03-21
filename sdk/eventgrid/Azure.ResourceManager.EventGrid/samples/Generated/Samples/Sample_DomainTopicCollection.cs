// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_DomainTopicCollection
    {
        // DomainTopics_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DomainTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopics_Get.json
            // this example is just showing the usage of "DomainTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainTopicResource
            DomainTopicCollection collection = eventGridDomain.GetDomainTopics();

            // invoke the operation
            string domainTopicName = "topic1";
            DomainTopicResource result = await collection.GetAsync(domainTopicName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DomainTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DomainTopics_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DomainTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopics_Get.json
            // this example is just showing the usage of "DomainTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainTopicResource
            DomainTopicCollection collection = eventGridDomain.GetDomainTopics();

            // invoke the operation
            string domainTopicName = "topic1";
            bool result = await collection.ExistsAsync(domainTopicName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DomainTopics_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_DomainTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopics_Get.json
            // this example is just showing the usage of "DomainTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainTopicResource
            DomainTopicCollection collection = eventGridDomain.GetDomainTopics();

            // invoke the operation
            string domainTopicName = "topic1";
            NullableResponse<DomainTopicResource> response = await collection.GetIfExistsAsync(domainTopicName);
            DomainTopicResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DomainTopicData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // DomainTopics_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DomainTopicsCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopics_CreateOrUpdate.json
            // this example is just showing the usage of "DomainTopics_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainTopicResource
            DomainTopicCollection collection = eventGridDomain.GetDomainTopics();

            // invoke the operation
            string domainTopicName = "exampledomaintopic1";
            ArmOperation<DomainTopicResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, domainTopicName);
            DomainTopicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DomainTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DomainTopics_ListByDomain
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DomainTopicsListByDomain()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopics_ListByDomain.json
            // this example is just showing the usage of "DomainTopics_ListByDomain" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainTopicResource
            DomainTopicCollection collection = eventGridDomain.GetDomainTopics();

            // invoke the operation and iterate over the result
            await foreach (DomainTopicResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DomainTopicData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
