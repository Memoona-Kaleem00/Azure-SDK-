// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics.Samples
{
    public partial class Sample_DataLakeStoreAccountInformationResource
    {
        // Adds a Data Lake Store account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AddsADataLakeStoreAccount()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_Add.json
            // this example is just showing the usage of "DataLakeStoreAccounts_Add" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeStoreAccountInformationResource created on azure
            // for more information of creating DataLakeStoreAccountInformationResource, please refer to the document of DataLakeStoreAccountInformationResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            string dataLakeStoreAccountName = "test_adls_account";
            ResourceIdentifier dataLakeStoreAccountInformationResourceId = DataLakeStoreAccountInformationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, dataLakeStoreAccountName);
            DataLakeStoreAccountInformationResource dataLakeStoreAccountInformation = client.GetDataLakeStoreAccountInformationResource(dataLakeStoreAccountInformationResourceId);

            // invoke the operation
            DataLakeStoreAccountInformationCreateOrUpdateContent content = new DataLakeStoreAccountInformationCreateOrUpdateContent()
            {
                Suffix = "test_suffix",
            };
            await dataLakeStoreAccountInformation.UpdateAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // Gets the specified Data Lake Store account details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheSpecifiedDataLakeStoreAccountDetails()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_Get.json
            // this example is just showing the usage of "DataLakeStoreAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeStoreAccountInformationResource created on azure
            // for more information of creating DataLakeStoreAccountInformationResource, please refer to the document of DataLakeStoreAccountInformationResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1669ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            string dataLakeStoreAccountName = "test_adls_account";
            ResourceIdentifier dataLakeStoreAccountInformationResourceId = DataLakeStoreAccountInformationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, dataLakeStoreAccountName);
            DataLakeStoreAccountInformationResource dataLakeStoreAccountInformation = client.GetDataLakeStoreAccountInformationResource(dataLakeStoreAccountInformationResourceId);

            // invoke the operation
            DataLakeStoreAccountInformationResource result = await dataLakeStoreAccountInformation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataLakeStoreAccountInformationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Removes the specified Data Lake Store account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RemovesTheSpecifiedDataLakeStoreAccount()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_Delete.json
            // this example is just showing the usage of "DataLakeStoreAccounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeStoreAccountInformationResource created on azure
            // for more information of creating DataLakeStoreAccountInformationResource, please refer to the document of DataLakeStoreAccountInformationResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            string dataLakeStoreAccountName = "test_adls_account";
            ResourceIdentifier dataLakeStoreAccountInformationResourceId = DataLakeStoreAccountInformationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, dataLakeStoreAccountName);
            DataLakeStoreAccountInformationResource dataLakeStoreAccountInformation = client.GetDataLakeStoreAccountInformationResource(dataLakeStoreAccountInformationResourceId);

            // invoke the operation
            await dataLakeStoreAccountInformation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
