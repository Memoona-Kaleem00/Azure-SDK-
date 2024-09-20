// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudClusterMetricsConfigurationResource
    {
        // Get metrics configuration of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMetricsConfigurationOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/ClusterMetricsConfigurations_Get.json
            // this example is just showing the usage of "MetricsConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterMetricsConfigurationResource created on azure
            // for more information of creating NetworkCloudClusterMetricsConfigurationResource, please refer to the document of NetworkCloudClusterMetricsConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            string metricsConfigurationName = "default";
            ResourceIdentifier networkCloudClusterMetricsConfigurationResourceId = NetworkCloudClusterMetricsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, metricsConfigurationName);
            NetworkCloudClusterMetricsConfigurationResource networkCloudClusterMetricsConfiguration = client.GetNetworkCloudClusterMetricsConfigurationResource(networkCloudClusterMetricsConfigurationResourceId);

            // invoke the operation
            NetworkCloudClusterMetricsConfigurationResource result = await networkCloudClusterMetricsConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterMetricsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete metrics configuration of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteMetricsConfigurationOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/ClusterMetricsConfigurations_Delete.json
            // this example is just showing the usage of "MetricsConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterMetricsConfigurationResource created on azure
            // for more information of creating NetworkCloudClusterMetricsConfigurationResource, please refer to the document of NetworkCloudClusterMetricsConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            string metricsConfigurationName = "default";
            ResourceIdentifier networkCloudClusterMetricsConfigurationResourceId = NetworkCloudClusterMetricsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, metricsConfigurationName);
            NetworkCloudClusterMetricsConfigurationResource networkCloudClusterMetricsConfiguration = client.GetNetworkCloudClusterMetricsConfigurationResource(networkCloudClusterMetricsConfigurationResourceId);

            // invoke the operation
            await networkCloudClusterMetricsConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch metrics configuration of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchMetricsConfigurationOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/ClusterMetricsConfigurations_Patch.json
            // this example is just showing the usage of "MetricsConfigurations_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterMetricsConfigurationResource created on azure
            // for more information of creating NetworkCloudClusterMetricsConfigurationResource, please refer to the document of NetworkCloudClusterMetricsConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            string metricsConfigurationName = "default";
            ResourceIdentifier networkCloudClusterMetricsConfigurationResourceId = NetworkCloudClusterMetricsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, metricsConfigurationName);
            NetworkCloudClusterMetricsConfigurationResource networkCloudClusterMetricsConfiguration = client.GetNetworkCloudClusterMetricsConfigurationResource(networkCloudClusterMetricsConfigurationResourceId);

            // invoke the operation
            NetworkCloudClusterMetricsConfigurationPatch patch = new NetworkCloudClusterMetricsConfigurationPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                CollectionInterval = 15,
                EnabledMetrics =
{
"metric1","metric2"
},
            };
            ArmOperation<NetworkCloudClusterMetricsConfigurationResource> lro = await networkCloudClusterMetricsConfiguration.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterMetricsConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterMetricsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
