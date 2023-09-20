// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryProtectableItemCollection
    {
        // Gets the list of protectable items.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsTheListOfProtectableItems()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectableItems_ListByReplicationProtectionContainers.json
            // this example is just showing the usage of "ReplicationProtectableItems_ListByReplicationProtectionContainers" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this SiteRecoveryProtectableItemResource
            SiteRecoveryProtectableItemCollection collection = siteRecoveryProtectionContainer.GetSiteRecoveryProtectableItems();

            // invoke the operation and iterate over the result
            await foreach (SiteRecoveryProtectableItemResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SiteRecoveryProtectableItemData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets the details of a protectable item.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDetailsOfAProtectableItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectableItems_Get.json
            // this example is just showing the usage of "ReplicationProtectableItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this SiteRecoveryProtectableItemResource
            SiteRecoveryProtectableItemCollection collection = siteRecoveryProtectionContainer.GetSiteRecoveryProtectableItems();

            // invoke the operation
            string protectableItemName = "c0c14913-3d7a-48ea-9531-cc99e0e686e6";
            SiteRecoveryProtectableItemResource result = await collection.GetAsync(protectableItemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryProtectableItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the details of a protectable item.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsTheDetailsOfAProtectableItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectableItems_Get.json
            // this example is just showing the usage of "ReplicationProtectableItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this SiteRecoveryProtectableItemResource
            SiteRecoveryProtectableItemCollection collection = siteRecoveryProtectionContainer.GetSiteRecoveryProtectableItems();

            // invoke the operation
            string protectableItemName = "c0c14913-3d7a-48ea-9531-cc99e0e686e6";
            bool result = await collection.ExistsAsync(protectableItemName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
