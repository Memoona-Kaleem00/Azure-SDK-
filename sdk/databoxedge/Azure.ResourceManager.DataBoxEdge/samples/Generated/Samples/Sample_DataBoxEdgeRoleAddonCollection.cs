// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge.Samples
{
    public partial class Sample_DataBoxEdgeRoleAddonCollection
    {
        // RoleListAddOns
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RoleListAddOns()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/RoleListAddOns.json
            // this example is just showing the usage of "Addons_ListByRole" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeRoleResource created on azure
            // for more information of creating DataBoxEdgeRoleResource, please refer to the document of DataBoxEdgeRoleResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string roleName = "IoTRole1";
            ResourceIdentifier dataBoxEdgeRoleResourceId = DataBoxEdgeRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, roleName);
            DataBoxEdgeRoleResource dataBoxEdgeRole = client.GetDataBoxEdgeRoleResource(dataBoxEdgeRoleResourceId);

            // get the collection of this DataBoxEdgeRoleAddonResource
            DataBoxEdgeRoleAddonCollection collection = dataBoxEdgeRole.GetDataBoxEdgeRoleAddons();

            // invoke the operation and iterate over the result
            await foreach (DataBoxEdgeRoleAddonResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataBoxEdgeRoleAddonData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetAddOns
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAddOns()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/GetAddons.json
            // this example is just showing the usage of "Addons_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeRoleResource created on azure
            // for more information of creating DataBoxEdgeRoleResource, please refer to the document of DataBoxEdgeRoleResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string roleName = "KubernetesRole";
            ResourceIdentifier dataBoxEdgeRoleResourceId = DataBoxEdgeRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, roleName);
            DataBoxEdgeRoleResource dataBoxEdgeRole = client.GetDataBoxEdgeRoleResource(dataBoxEdgeRoleResourceId);

            // get the collection of this DataBoxEdgeRoleAddonResource
            DataBoxEdgeRoleAddonCollection collection = dataBoxEdgeRole.GetDataBoxEdgeRoleAddons();

            // invoke the operation
            string addonName = "arcName";
            DataBoxEdgeRoleAddonResource result = await collection.GetAsync(addonName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeRoleAddonData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetAddOns
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAddOns()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/GetAddons.json
            // this example is just showing the usage of "Addons_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeRoleResource created on azure
            // for more information of creating DataBoxEdgeRoleResource, please refer to the document of DataBoxEdgeRoleResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string roleName = "KubernetesRole";
            ResourceIdentifier dataBoxEdgeRoleResourceId = DataBoxEdgeRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, roleName);
            DataBoxEdgeRoleResource dataBoxEdgeRole = client.GetDataBoxEdgeRoleResource(dataBoxEdgeRoleResourceId);

            // get the collection of this DataBoxEdgeRoleAddonResource
            DataBoxEdgeRoleAddonCollection collection = dataBoxEdgeRole.GetDataBoxEdgeRoleAddons();

            // invoke the operation
            string addonName = "arcName";
            bool result = await collection.ExistsAsync(addonName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetAddOns
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAddOns()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/GetAddons.json
            // this example is just showing the usage of "Addons_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeRoleResource created on azure
            // for more information of creating DataBoxEdgeRoleResource, please refer to the document of DataBoxEdgeRoleResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string roleName = "KubernetesRole";
            ResourceIdentifier dataBoxEdgeRoleResourceId = DataBoxEdgeRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, roleName);
            DataBoxEdgeRoleResource dataBoxEdgeRole = client.GetDataBoxEdgeRoleResource(dataBoxEdgeRoleResourceId);

            // get the collection of this DataBoxEdgeRoleAddonResource
            DataBoxEdgeRoleAddonCollection collection = dataBoxEdgeRole.GetDataBoxEdgeRoleAddons();

            // invoke the operation
            string addonName = "arcName";
            NullableResponse<DataBoxEdgeRoleAddonResource> response = await collection.GetIfExistsAsync(addonName);
            DataBoxEdgeRoleAddonResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataBoxEdgeRoleAddonData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PutAddOns
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAddOns()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/PutAddons.json
            // this example is just showing the usage of "Addons_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeRoleResource created on azure
            // for more information of creating DataBoxEdgeRoleResource, please refer to the document of DataBoxEdgeRoleResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string roleName = "KubernetesRole";
            ResourceIdentifier dataBoxEdgeRoleResourceId = DataBoxEdgeRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, roleName);
            DataBoxEdgeRoleResource dataBoxEdgeRole = client.GetDataBoxEdgeRoleResource(dataBoxEdgeRoleResourceId);

            // get the collection of this DataBoxEdgeRoleAddonResource
            DataBoxEdgeRoleAddonCollection collection = dataBoxEdgeRole.GetDataBoxEdgeRoleAddons();

            // invoke the operation
            string addonName = "arcName";
            DataBoxEdgeRoleAddonData data = new EdgeArcAddon("4385cf00-2d3a-425a-832f-f4285b1c9dce", "GroupForEdgeAutomation", "testedgedevice", new AzureLocation("EastUS"));
            ArmOperation<DataBoxEdgeRoleAddonResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, addonName, data);
            DataBoxEdgeRoleAddonResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeRoleAddonData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
