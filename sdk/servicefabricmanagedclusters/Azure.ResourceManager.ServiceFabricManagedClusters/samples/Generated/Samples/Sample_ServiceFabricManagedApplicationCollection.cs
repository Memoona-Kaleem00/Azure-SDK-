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
using Azure.ResourceManager.ServiceFabricManagedClusters;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedApplicationCollection
    {
        // Get an application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationResource
            ServiceFabricManagedApplicationCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricManagedApplicationResource result = await collection.GetAsync(applicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationResource
            ServiceFabricManagedApplicationCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplications();

            // invoke the operation
            string applicationName = "myApp";
            bool result = await collection.ExistsAsync(applicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationResource
            ServiceFabricManagedApplicationCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplications();

            // invoke the operation
            string applicationName = "myApp";
            NullableResponse<ServiceFabricManagedApplicationResource> response = await collection.GetIfExistsAsync(applicationName);
            ServiceFabricManagedApplicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedApplicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Put an application with maximum parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationWithMaximumParameters()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationPutOperation_example_max.json
            // this example is just showing the usage of "Applications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationResource
            ServiceFabricManagedApplicationCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricManagedApplicationData data = new ServiceFabricManagedApplicationData(new AzureLocation("eastus"))
            {
                Version = "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/resRg/providers/Microsoft.ServiceFabric/managedclusters/myCluster/applicationTypes/myAppType/versions/1.0",
                Parameters =
{
["param1"] = "value1",
},
                UpgradePolicy = new ApplicationUpgradePolicy()
                {
                    ApplicationHealthPolicy = new ApplicationHealthPolicy(true, 0)
                    {
                        DefaultServiceTypeHealthPolicy = new ServiceTypeHealthPolicy(0, 0, 0),
                        ServiceTypeHealthPolicyMap =
{
["service1"] = new ServiceTypeHealthPolicy(30,30,30),
},
                    },
                    ForceRestart = false,
                    RollingUpgradeMonitoringPolicy = new RollingUpgradeMonitoringPolicy(PolicyViolationCompensationAction.Rollback, TimeSpan.Parse("00:02:00"), TimeSpan.Parse("00:05:00"), TimeSpan.Parse("00:10:00"), TimeSpan.Parse("01:00:00"), TimeSpan.Parse("00:15:00")),
                    InstanceCloseDelayDurationInSeconds = 600,
                    UpgradeMode = RollingUpgradeMode.UnmonitoredAuto,
                    UpgradeReplicaSetCheckTimeout = 3600,
                    RecreateApplication = false,
                },
                Tags =
{
["a"] = "b",
},
            };
            ArmOperation<ServiceFabricManagedApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            ServiceFabricManagedApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Put an application with minimum parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationWithMinimumParameters()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationPutOperation_example_min.json
            // this example is just showing the usage of "Applications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationResource
            ServiceFabricManagedApplicationCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricManagedApplicationData data = new ServiceFabricManagedApplicationData(new AzureLocation("eastus"))
            {
                Version = "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/resRg/providers/Microsoft.ServiceFabric/managedclusters/myCluster/applicationTypes/myAppType/versions/1.0",
            };
            ArmOperation<ServiceFabricManagedApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            ServiceFabricManagedApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a list of application resources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAListOfApplicationResources()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationListOperation_example.json
            // this example is just showing the usage of "Applications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationResource
            ServiceFabricManagedApplicationCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplications();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricManagedApplicationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedApplicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
