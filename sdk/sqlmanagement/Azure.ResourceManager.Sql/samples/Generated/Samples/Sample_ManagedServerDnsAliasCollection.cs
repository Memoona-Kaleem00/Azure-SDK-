// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedServerDnsAliasCollection
    {
        // List managed server DNS aliases
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListManagedServerDNSAliases()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ManagedServerDnsAliasList.json
            // this example is just showing the usage of "ManagedServerDnsAliases_ListByManagedInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "dns-mi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerDnsAliasResource
            ManagedServerDnsAliasCollection collection = managedInstance.GetManagedServerDnsAliases();

            // invoke the operation and iterate over the result
            await foreach (ManagedServerDnsAliasResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServerDnsAliasData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get managed server DNS alias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetManagedServerDNSAlias()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ManagedServerDnsAliasGet.json
            // this example is just showing the usage of "ManagedServerDnsAliases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "dns-mi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerDnsAliasResource
            ManagedServerDnsAliasCollection collection = managedInstance.GetManagedServerDnsAliases();

            // invoke the operation
            string dnsAliasName = "dns-alias-mi";
            ManagedServerDnsAliasResource result = await collection.GetAsync(dnsAliasName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServerDnsAliasData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get managed server DNS alias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetManagedServerDNSAlias()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ManagedServerDnsAliasGet.json
            // this example is just showing the usage of "ManagedServerDnsAliases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "dns-mi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerDnsAliasResource
            ManagedServerDnsAliasCollection collection = managedInstance.GetManagedServerDnsAliases();

            // invoke the operation
            string dnsAliasName = "dns-alias-mi";
            bool result = await collection.ExistsAsync(dnsAliasName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get managed server DNS alias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetManagedServerDNSAlias()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ManagedServerDnsAliasGet.json
            // this example is just showing the usage of "ManagedServerDnsAliases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "dns-mi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerDnsAliasResource
            ManagedServerDnsAliasCollection collection = managedInstance.GetManagedServerDnsAliases();

            // invoke the operation
            string dnsAliasName = "dns-alias-mi";
            NullableResponse<ManagedServerDnsAliasResource> response = await collection.GetIfExistsAsync(dnsAliasName);
            ManagedServerDnsAliasResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServerDnsAliasData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create managed server DNS alias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateManagedServerDNSAlias()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ManagedServerDnsAliasCreateOrUpdate.json
            // this example is just showing the usage of "ManagedServerDnsAliases_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "dns-mi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerDnsAliasResource
            ManagedServerDnsAliasCollection collection = managedInstance.GetManagedServerDnsAliases();

            // invoke the operation
            string dnsAliasName = "dns-alias-mi";
            ManagedServerDnsAliasCreateOrUpdateContent content = new ManagedServerDnsAliasCreateOrUpdateContent();
            ArmOperation<ManagedServerDnsAliasResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dnsAliasName, content);
            ManagedServerDnsAliasResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServerDnsAliasData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
