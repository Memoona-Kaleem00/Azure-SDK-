// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs.Samples
{
    public partial class Sample_NotificationHubResource
    {
        // NotificationHubs_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NotificationHubsGet()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/preview/2023-10-01-preview/examples/NotificationHubs/Get.json
            // this example is just showing the usage of "NotificationHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubResource created on azure
            // for more information of creating NotificationHubResource, please refer to the document of NotificationHubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string notificationHubName = "nh-sdk-hub";
            ResourceIdentifier notificationHubResourceId = NotificationHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, notificationHubName);
            NotificationHubResource notificationHub = client.GetNotificationHubResource(notificationHubResourceId);

            // invoke the operation
            NotificationHubResource result = await notificationHub.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NotificationHubs_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NotificationHubsUpdate()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/preview/2023-10-01-preview/examples/NotificationHubs/Update.json
            // this example is just showing the usage of "NotificationHubs_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubResource created on azure
            // for more information of creating NotificationHubResource, please refer to the document of NotificationHubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sdkresourceGroup";
            string namespaceName = "nh-sdk-ns";
            string notificationHubName = "sdk-notificationHubs-8708";
            ResourceIdentifier notificationHubResourceId = NotificationHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, notificationHubName);
            NotificationHubResource notificationHub = client.GetNotificationHubResource(notificationHubResourceId);

            // invoke the operation
            NotificationHubPatch patch = new NotificationHubPatch(new AzureLocation("placeholder"))
            {
                RegistrationTtl = TimeSpan.Parse("10675199.02:48:05.4775807"),
                GcmCredential = new NotificationHubGcmCredential("###################################")
                {
                    GcmEndpoint = new Uri("https://fcm.googleapis.com/fcm/send"),
                },
            };
            NotificationHubResource result = await notificationHub.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NotificationHubs_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NotificationHubsDelete()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/preview/2023-10-01-preview/examples/NotificationHubs/Delete.json
            // this example is just showing the usage of "NotificationHubs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubResource created on azure
            // for more information of creating NotificationHubResource, please refer to the document of NotificationHubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string notificationHubName = "nh-sdk-hub";
            ResourceIdentifier notificationHubResourceId = NotificationHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, notificationHubName);
            NotificationHubResource notificationHub = client.GetNotificationHubResource(notificationHubResourceId);

            // invoke the operation
            await notificationHub.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NotificationHubs_DebugSend
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DebugSend_NotificationHubsDebugSend()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/preview/2023-10-01-preview/examples/NotificationHubs/DebugSend.json
            // this example is just showing the usage of "NotificationHubs_DebugSend" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubResource created on azure
            // for more information of creating NotificationHubResource, please refer to the document of NotificationHubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string notificationHubName = "nh-sdk-hub";
            ResourceIdentifier notificationHubResourceId = NotificationHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, notificationHubName);
            NotificationHubResource notificationHub = client.GetNotificationHubResource(notificationHubResourceId);

            // invoke the operation
            NotificationHubTestSendResult result = await notificationHub.DebugSendAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // NotificationHubs_GetPnsCredentials
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPnsCredentials_NotificationHubsGetPnsCredentials()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/preview/2023-10-01-preview/examples/NotificationHubs/PnsCredentialsGet.json
            // this example is just showing the usage of "NotificationHubs_GetPnsCredentials" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubResource created on azure
            // for more information of creating NotificationHubResource, please refer to the document of NotificationHubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string notificationHubName = "nh-sdk-hub";
            ResourceIdentifier notificationHubResourceId = NotificationHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, notificationHubName);
            NotificationHubResource notificationHub = client.GetNotificationHubResource(notificationHubResourceId);

            // invoke the operation
            NotificationHubPnsCredentials result = await notificationHub.GetPnsCredentialsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
