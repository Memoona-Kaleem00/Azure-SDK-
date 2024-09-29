// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceTagApiLinkResource
    {
        // ApiManagementGetTagApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetTagApiLink.json
            // this example is just showing the usage of "TagApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceTagApiLinkResource created on azure
            // for more information of creating ServiceTagApiLinkResource, please refer to the document of ServiceTagApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tag1";
            string apiLinkId = "link1";
            ResourceIdentifier serviceTagApiLinkResourceId = ServiceTagApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId, apiLinkId);
            ServiceTagApiLinkResource serviceTagApiLink = client.GetServiceTagApiLinkResource(serviceTagApiLinkResourceId);

            // invoke the operation
            ServiceTagApiLinkResource result = await serviceTagApiLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateTagApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateTagApiLink.json
            // this example is just showing the usage of "TagApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceTagApiLinkResource created on azure
            // for more information of creating ServiceTagApiLinkResource, please refer to the document of ServiceTagApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tag1";
            string apiLinkId = "link1";
            ResourceIdentifier serviceTagApiLinkResourceId = ServiceTagApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId, apiLinkId);
            ServiceTagApiLinkResource serviceTagApiLink = client.GetServiceTagApiLinkResource(serviceTagApiLinkResourceId);

            // invoke the operation
            TagApiLinkContractData data = new TagApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/apis/echo-api",
            };
            ArmOperation<ServiceTagApiLinkResource> lro = await serviceTagApiLink.UpdateAsync(WaitUntil.Completed, data);
            ServiceTagApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteTagApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteTagApiLink.json
            // this example is just showing the usage of "TagApiLink_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceTagApiLinkResource created on azure
            // for more information of creating ServiceTagApiLinkResource, please refer to the document of ServiceTagApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tag1";
            string apiLinkId = "link1";
            ResourceIdentifier serviceTagApiLinkResourceId = ServiceTagApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId, apiLinkId);
            ServiceTagApiLinkResource serviceTagApiLink = client.GetServiceTagApiLinkResource(serviceTagApiLinkResourceId);

            // invoke the operation
            await serviceTagApiLink.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
