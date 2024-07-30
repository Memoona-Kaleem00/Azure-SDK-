// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppReplicaResource
    {
        // Get Container App's revision replica
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContainerAppSRevisionReplica()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Replicas_Get.json
            // this example is just showing the usage of "ContainerAppsRevisionReplicas_GetReplica" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppReplicaResource created on azure
            // for more information of creating ContainerAppReplicaResource, please refer to the document of ContainerAppReplicaResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "myapp";
            string revisionName = "myapp--0wlqy09";
            string replicaName = "myapp--0wlqy09-5d9774cff-5wnd8";
            ResourceIdentifier containerAppReplicaResourceId = ContainerAppReplicaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName, revisionName, replicaName);
            ContainerAppReplicaResource containerAppReplica = client.GetContainerAppReplicaResource(containerAppReplicaResourceId);

            // invoke the operation
            ContainerAppReplicaResource result = await containerAppReplica.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppReplicaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
