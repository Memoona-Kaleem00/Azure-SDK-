// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementCertificateCollection
    {
        // ApiManagementListCertificates
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListCertificates()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListCertificates.json
            // this example is just showing the usage of "Certificate_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation and iterate over the result
            await foreach (ApiManagementCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCert1";
            ApiManagementCertificateResource result = await collection.GetAsync(certificateId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCert1";
            bool result = await collection.ExistsAsync(certificateId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCert1";
            NullableResponse<ApiManagementCertificateResource> response = await collection.GetIfExistsAsync(certificateId);
            ApiManagementCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementGetCertificateWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetCertificateWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetCertificateWithKeyVault.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCertkv";
            ApiManagementCertificateResource result = await collection.GetAsync(certificateId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetCertificateWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetCertificateWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetCertificateWithKeyVault.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCertkv";
            bool result = await collection.ExistsAsync(certificateId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetCertificateWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetCertificateWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetCertificateWithKeyVault.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCertkv";
            NullableResponse<ApiManagementCertificateResource> response = await collection.GetIfExistsAsync(certificateId);
            ApiManagementCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateCertificate.json
            // this example is just showing the usage of "Certificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "tempcert";
            ApiManagementCertificateCreateOrUpdateContent content = new ApiManagementCertificateCreateOrUpdateContent()
            {
                Data = "****************Base 64 Encoded Certificate *******************************",
                Password = "****Certificate Password******",
            };
            ArmOperation<ApiManagementCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateId, content);
            ApiManagementCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateCertificateWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateCertificateWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateCertificateWithKeyVault.json
            // this example is just showing the usage of "Certificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementCertificateResource
            ApiManagementCertificateCollection collection = apiManagementService.GetApiManagementCertificates();

            // invoke the operation
            string certificateId = "templateCertkv";
            ApiManagementCertificateCreateOrUpdateContent content = new ApiManagementCertificateCreateOrUpdateContent()
            {
                KeyVaultDetails = new KeyVaultContractCreateProperties()
                {
                    SecretIdentifier = "https://rpbvtkeyvaultintegration.vault-int.azure-int.net/secrets/msitestingCert",
                    IdentityClientId = "ceaa6b06-c00f-43ef-99ac-f53d1fe876a0",
                },
            };
            ArmOperation<ApiManagementCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateId, content);
            ApiManagementCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
