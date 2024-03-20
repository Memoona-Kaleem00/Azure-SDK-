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
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Samples
{
    public partial class Sample_SphereDeviceCollection
    {
        // Devices_ListByDeviceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DevicesListByDeviceGroup()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetDevices.json
            // this example is just showing the usage of "Devices_ListByDeviceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceGroupResource created on azure
            // for more information of creating SphereDeviceGroupResource, please refer to the document of SphereDeviceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            ResourceIdentifier sphereDeviceGroupResourceId = SphereDeviceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName);
            SphereDeviceGroupResource sphereDeviceGroup = client.GetSphereDeviceGroupResource(sphereDeviceGroupResourceId);

            // get the collection of this SphereDeviceResource
            SphereDeviceCollection collection = sphereDeviceGroup.GetSphereDevices();

            // invoke the operation and iterate over the result
            await foreach (SphereDeviceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SphereDeviceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Devices_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DevicesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetDevice.json
            // this example is just showing the usage of "Devices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceGroupResource created on azure
            // for more information of creating SphereDeviceGroupResource, please refer to the document of SphereDeviceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            ResourceIdentifier sphereDeviceGroupResourceId = SphereDeviceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName);
            SphereDeviceGroupResource sphereDeviceGroup = client.GetSphereDeviceGroupResource(sphereDeviceGroupResourceId);

            // get the collection of this SphereDeviceResource
            SphereDeviceCollection collection = sphereDeviceGroup.GetSphereDevices();

            // invoke the operation
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            SphereDeviceResource result = await collection.GetAsync(deviceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereDeviceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Devices_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DevicesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetDevice.json
            // this example is just showing the usage of "Devices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceGroupResource created on azure
            // for more information of creating SphereDeviceGroupResource, please refer to the document of SphereDeviceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            ResourceIdentifier sphereDeviceGroupResourceId = SphereDeviceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName);
            SphereDeviceGroupResource sphereDeviceGroup = client.GetSphereDeviceGroupResource(sphereDeviceGroupResourceId);

            // get the collection of this SphereDeviceResource
            SphereDeviceCollection collection = sphereDeviceGroup.GetSphereDevices();

            // invoke the operation
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            bool result = await collection.ExistsAsync(deviceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Devices_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_DevicesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetDevice.json
            // this example is just showing the usage of "Devices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceGroupResource created on azure
            // for more information of creating SphereDeviceGroupResource, please refer to the document of SphereDeviceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            ResourceIdentifier sphereDeviceGroupResourceId = SphereDeviceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName);
            SphereDeviceGroupResource sphereDeviceGroup = client.GetSphereDeviceGroupResource(sphereDeviceGroupResourceId);

            // get the collection of this SphereDeviceResource
            SphereDeviceCollection collection = sphereDeviceGroup.GetSphereDevices();

            // invoke the operation
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            NullableResponse<SphereDeviceResource> response = await collection.GetIfExistsAsync(deviceName);
            SphereDeviceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SphereDeviceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Devices_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DevicesCreateOrUpdate()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/PutDevice.json
            // this example is just showing the usage of "Devices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceGroupResource created on azure
            // for more information of creating SphereDeviceGroupResource, please refer to the document of SphereDeviceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            ResourceIdentifier sphereDeviceGroupResourceId = SphereDeviceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName);
            SphereDeviceGroupResource sphereDeviceGroup = client.GetSphereDeviceGroupResource(sphereDeviceGroupResourceId);

            // get the collection of this SphereDeviceResource
            SphereDeviceCollection collection = sphereDeviceGroup.GetSphereDevices();

            // invoke the operation
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            SphereDeviceData data = new SphereDeviceData();
            ArmOperation<SphereDeviceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, deviceName, data);
            SphereDeviceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereDeviceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
