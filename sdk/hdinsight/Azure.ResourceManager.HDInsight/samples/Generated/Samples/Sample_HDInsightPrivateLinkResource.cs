// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.HDInsight.Samples
{
    public partial class Sample_HDInsightPrivateLinkResource
    {
        // Get specific private link resource in a specific HDInsight cluster.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSpecificPrivateLinkResourceInASpecificHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2023-04-15-preview/examples/GetPrivateLinkResource.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightPrivateLinkResource created on azure
            // for more information of creating HDInsightPrivateLinkResource, please refer to the document of HDInsightPrivateLinkResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            string privateLinkResourceName = "gateway";
            ResourceIdentifier hdInsightPrivateLinkResourceId = HDInsightPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateLinkResourceName);
            HDInsightPrivateLinkResource hdInsightPrivateLinkResource = client.GetHDInsightPrivateLinkResource(hdInsightPrivateLinkResourceId);

            // invoke the operation
            HDInsightPrivateLinkResource result = await hdInsightPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
