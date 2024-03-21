// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_SecurityAdminConfigurationResource
    {
        // Get security admin configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSecurityAdminConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerSecurityAdminConfigurationGet.json
            // this example is just showing the usage of "SecurityAdminConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // invoke the operation
            SecurityAdminConfigurationResource result = await securityAdminConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAdminConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create network manager security admin configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateNetworkManagerSecurityAdminConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerSecurityAdminConfigurationPut.json
            // this example is just showing the usage of "SecurityAdminConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // invoke the operation
            SecurityAdminConfigurationData data = new SecurityAdminConfigurationData()
            {
                Description = "A sample policy",
                ApplyOnNetworkIntentPolicyBasedServices =
{
NetworkIntentPolicyBasedService.None
},
            };
            ArmOperation<SecurityAdminConfigurationResource> lro = await securityAdminConfiguration.UpdateAsync(WaitUntil.Completed, data);
            SecurityAdminConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAdminConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete network manager security admin configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteNetworkManagerSecurityAdminConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerSecurityAdminConfigurationDelete.json
            // this example is just showing the usage of "SecurityAdminConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // invoke the operation
            bool? force = false;
            await securityAdminConfiguration.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine($"Succeeded");
        }
    }
}
