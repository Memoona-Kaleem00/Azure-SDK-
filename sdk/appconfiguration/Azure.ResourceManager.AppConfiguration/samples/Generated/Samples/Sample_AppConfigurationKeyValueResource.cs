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
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration.Samples
{
    public partial class Sample_AppConfigurationKeyValueResource
    {
        // KeyValues_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KeyValuesGet()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresGetKeyValue.json
            // this example is just showing the usage of "KeyValues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationKeyValueResource created on azure
            // for more information of creating AppConfigurationKeyValueResource, please refer to the document of AppConfigurationKeyValueResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            string keyValueName = "myKey$myLabel";
            ResourceIdentifier appConfigurationKeyValueResourceId = AppConfigurationKeyValueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName, keyValueName);
            AppConfigurationKeyValueResource appConfigurationKeyValue = client.GetAppConfigurationKeyValueResource(appConfigurationKeyValueResourceId);

            // invoke the operation
            AppConfigurationKeyValueResource result = await appConfigurationKeyValue.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationKeyValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KeyValues_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_KeyValuesCreateOrUpdate()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresCreateKeyValue.json
            // this example is just showing the usage of "KeyValues_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationKeyValueResource created on azure
            // for more information of creating AppConfigurationKeyValueResource, please refer to the document of AppConfigurationKeyValueResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            string keyValueName = "myKey$myLabel";
            ResourceIdentifier appConfigurationKeyValueResourceId = AppConfigurationKeyValueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName, keyValueName);
            AppConfigurationKeyValueResource appConfigurationKeyValue = client.GetAppConfigurationKeyValueResource(appConfigurationKeyValueResourceId);

            // invoke the operation
            AppConfigurationKeyValueData data = new AppConfigurationKeyValueData()
            {
                Value = "myValue",
                Tags =
{
["tag1"] = "tagValue1",
["tag2"] = "tagValue2",
},
            };
            ArmOperation<AppConfigurationKeyValueResource> lro = await appConfigurationKeyValue.UpdateAsync(WaitUntil.Completed, data);
            AppConfigurationKeyValueResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationKeyValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KeyValues_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_KeyValuesDelete()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresDeleteKeyValue.json
            // this example is just showing the usage of "KeyValues_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationKeyValueResource created on azure
            // for more information of creating AppConfigurationKeyValueResource, please refer to the document of AppConfigurationKeyValueResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            string keyValueName = "myKey$myLabel";
            ResourceIdentifier appConfigurationKeyValueResourceId = AppConfigurationKeyValueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName, keyValueName);
            AppConfigurationKeyValueResource appConfigurationKeyValue = client.GetAppConfigurationKeyValueResource(appConfigurationKeyValueResourceId);

            // invoke the operation
            await appConfigurationKeyValue.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
