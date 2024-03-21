// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HDInsight.Models;

namespace Azure.ResourceManager.HDInsight.Samples
{
    public partial class Sample_HDInsightApplicationCollection
    {
        // Get All Applications for an HDInsight cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllApplicationsForAnHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetAllApplications.json
            // this example is just showing the usage of "Applications_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation and iterate over the result
            await foreach (HDInsightApplicationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightApplicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get application on HDInsight cluster creation in progress
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetApplicationOnHDInsightClusterCreationInProgress()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetApplicationInProgress.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "app";
            HDInsightApplicationResource result = await collection.GetAsync(applicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get application on HDInsight cluster creation in progress
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetApplicationOnHDInsightClusterCreationInProgress()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetApplicationInProgress.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "app";
            bool result = await collection.ExistsAsync(applicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get application on HDInsight cluster creation in progress
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetApplicationOnHDInsightClusterCreationInProgress()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetApplicationInProgress.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "app";
            NullableResponse<HDInsightApplicationResource> response = await collection.GetIfExistsAsync(applicationName);
            HDInsightApplicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightApplicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get application on HDInsight cluster successfully created.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetApplicationOnHDInsightClusterSuccessfullyCreated()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetApplicationCreated.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "app";
            HDInsightApplicationResource result = await collection.GetAsync(applicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get application on HDInsight cluster successfully created.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetApplicationOnHDInsightClusterSuccessfullyCreated()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetApplicationCreated.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "app";
            bool result = await collection.ExistsAsync(applicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get application on HDInsight cluster successfully created.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetApplicationOnHDInsightClusterSuccessfullyCreated()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetApplicationCreated.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "app";
            NullableResponse<HDInsightApplicationResource> response = await collection.GetIfExistsAsync(applicationName);
            HDInsightApplicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightApplicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create Application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateApplication()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/CreateApplication.json
            // this example is just showing the usage of "Applications_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightApplicationResource
            HDInsightApplicationCollection collection = hdInsightCluster.GetHDInsightApplications();

            // invoke the operation
            string applicationName = "hue";
            HDInsightApplicationData data = new HDInsightApplicationData()
            {
                Properties = new HDInsightApplicationProperties()
                {
                    ComputeRoles =
{
new HDInsightClusterRole()
{
Name = "edgenode",
TargetInstanceCount = 1,
HardwareVmSize = "Standard_D12_v2",
}
},
                    InstallScriptActions =
{
new RuntimeScriptAction("app-install-app1",new Uri("https://.../install.sh"),new string[]
{
"edgenode"
})
{
Parameters = "-version latest -port 20000",
}
},
                    UninstallScriptActions =
{
},
                    HttpsEndpoints =
{
new HDInsightApplicationHttpsEndpoint()
{
AccessModes =
{
"WebPage"
},
DestinationPort = 20000,
SubDomainSuffix = "dss",
}
},
                    ApplicationType = "CustomApplication",
                    Errors =
{
},
                },
            };
            ArmOperation<HDInsightApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            HDInsightApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
