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
    public partial class Sample_DataBoxEdgeStorageAccountResource
    {
        // StorageAccountGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StorageAccountGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/StorageAccountGet.json
            // this example is just showing the usage of "StorageAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageAccountResource created on azure
            // for more information of creating DataBoxEdgeStorageAccountResource, please refer to the document of DataBoxEdgeStorageAccountResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "blobstorageaccount1";
            ResourceIdentifier dataBoxEdgeStorageAccountResourceId = DataBoxEdgeStorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName);
            DataBoxEdgeStorageAccountResource dataBoxEdgeStorageAccount = client.GetDataBoxEdgeStorageAccountResource(dataBoxEdgeStorageAccountResourceId);

            // invoke the operation
            DataBoxEdgeStorageAccountResource result = await dataBoxEdgeStorageAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeStorageAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_StorageAccountPut()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/StorageAccountPut.json
            // this example is just showing the usage of "StorageAccounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageAccountResource created on azure
            // for more information of creating DataBoxEdgeStorageAccountResource, please refer to the document of DataBoxEdgeStorageAccountResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "blobstorageaccount1";
            ResourceIdentifier dataBoxEdgeStorageAccountResourceId = DataBoxEdgeStorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName);
            DataBoxEdgeStorageAccountResource dataBoxEdgeStorageAccount = client.GetDataBoxEdgeStorageAccountResource(dataBoxEdgeStorageAccountResourceId);

            // invoke the operation
            DataBoxEdgeStorageAccountData data = new DataBoxEdgeStorageAccountData(DataBoxEdgeDataPolicy.Cloud)
            {
                Description = "It's an awesome storage account",
                StorageAccountStatus = DataBoxEdgeStorageAccountStatus.OK,
                StorageAccountCredentialId = new ResourceIdentifier("/subscriptions/4385cf00-2d3a-425a-832f-f4285b1c9dce/resourceGroups/GroupForDataBoxEdgeAutomation/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/testedgedevice/storageAccountCredentials/cisbvt"),
            };
            ArmOperation<DataBoxEdgeStorageAccountResource> lro = await dataBoxEdgeStorageAccount.UpdateAsync(WaitUntil.Completed, data);
            DataBoxEdgeStorageAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeStorageAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StorageAccountDelete()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/StorageAccountDelete.json
            // this example is just showing the usage of "StorageAccounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageAccountResource created on azure
            // for more information of creating DataBoxEdgeStorageAccountResource, please refer to the document of DataBoxEdgeStorageAccountResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "storageaccount1";
            ResourceIdentifier dataBoxEdgeStorageAccountResourceId = DataBoxEdgeStorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName);
            DataBoxEdgeStorageAccountResource dataBoxEdgeStorageAccount = client.GetDataBoxEdgeStorageAccountResource(dataBoxEdgeStorageAccountResourceId);

            // invoke the operation
            await dataBoxEdgeStorageAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
