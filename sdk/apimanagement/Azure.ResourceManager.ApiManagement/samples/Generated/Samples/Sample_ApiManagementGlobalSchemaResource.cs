// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementGlobalSchemaResource
    {
        // ApiManagementHeadApi
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadApi()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementHeadGlobalSchema.json
            // this example is just showing the usage of "GlobalSchema_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGlobalSchemaResource created on azure
            // for more information of creating ApiManagementGlobalSchemaResource, please refer to the document of ApiManagementGlobalSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string schemaId = "myschema";
            ResourceIdentifier apiManagementGlobalSchemaResourceId = ApiManagementGlobalSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, schemaId);
            ApiManagementGlobalSchemaResource apiManagementGlobalSchema = client.GetApiManagementGlobalSchemaResource(apiManagementGlobalSchemaResourceId);

            // invoke the operation
            bool result = await apiManagementGlobalSchema.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetSchema1
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetSchema1()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetGlobalSchema1.json
            // this example is just showing the usage of "GlobalSchema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGlobalSchemaResource created on azure
            // for more information of creating ApiManagementGlobalSchemaResource, please refer to the document of ApiManagementGlobalSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string schemaId = "schema1";
            ResourceIdentifier apiManagementGlobalSchemaResourceId = ApiManagementGlobalSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, schemaId);
            ApiManagementGlobalSchemaResource apiManagementGlobalSchema = client.GetApiManagementGlobalSchemaResource(apiManagementGlobalSchemaResourceId);

            // invoke the operation
            ApiManagementGlobalSchemaResource result = await apiManagementGlobalSchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGlobalSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetSchema2
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetSchema2()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetGlobalSchema2.json
            // this example is just showing the usage of "GlobalSchema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGlobalSchemaResource created on azure
            // for more information of creating ApiManagementGlobalSchemaResource, please refer to the document of ApiManagementGlobalSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string schemaId = "schema2";
            ResourceIdentifier apiManagementGlobalSchemaResourceId = ApiManagementGlobalSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, schemaId);
            ApiManagementGlobalSchemaResource apiManagementGlobalSchema = client.GetApiManagementGlobalSchemaResource(apiManagementGlobalSchemaResourceId);

            // invoke the operation
            ApiManagementGlobalSchemaResource result = await apiManagementGlobalSchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGlobalSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateSchema1
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateSchema1()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementCreateGlobalSchema1.json
            // this example is just showing the usage of "GlobalSchema_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGlobalSchemaResource created on azure
            // for more information of creating ApiManagementGlobalSchemaResource, please refer to the document of ApiManagementGlobalSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string schemaId = "schema1";
            ResourceIdentifier apiManagementGlobalSchemaResourceId = ApiManagementGlobalSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, schemaId);
            ApiManagementGlobalSchemaResource apiManagementGlobalSchema = client.GetApiManagementGlobalSchemaResource(apiManagementGlobalSchemaResourceId);

            // invoke the operation
            ApiManagementGlobalSchemaData data = new ApiManagementGlobalSchemaData()
            {
                SchemaType = ApiSchemaType.Xml,
                Description = "sample schema description",
                Value = BinaryData.FromString("\"<xsd:schema xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"\r\n           xmlns:tns=\"http://tempuri.org/PurchaseOrderSchema.xsd\"\r\n           targetNamespace=\"http://tempuri.org/PurchaseOrderSchema.xsd\"\r\n           elementFormDefault=\"qualified\">\r\n <xsd:element name=\"PurchaseOrder\" type=\"tns:PurchaseOrderType\"/>\r\n <xsd:complexType name=\"PurchaseOrderType\">\r\n  <xsd:sequence>\r\n   <xsd:element name=\"ShipTo\" type=\"tns:USAddress\" maxOccurs=\"2\"/>\r\n   <xsd:element name=\"BillTo\" type=\"tns:USAddress\"/>\r\n  </xsd:sequence>\r\n  <xsd:attribute name=\"OrderDate\" type=\"xsd:date\"/>\r\n </xsd:complexType>\r\n\r\n <xsd:complexType name=\"USAddress\">\r\n  <xsd:sequence>\r\n   <xsd:element name=\"name\"   type=\"xsd:string\"/>\r\n   <xsd:element name=\"street\" type=\"xsd:string\"/>\r\n   <xsd:element name=\"city\"   type=\"xsd:string\"/>\r\n   <xsd:element name=\"state\"  type=\"xsd:string\"/>\r\n   <xsd:element name=\"zip\"    type=\"xsd:integer\"/>\r\n  </xsd:sequence>\r\n  <xsd:attribute name=\"country\" type=\"xsd:NMTOKEN\" fixed=\"US\"/>\r\n </xsd:complexType>\r\n</xsd:schema>\""),
            };
            ArmOperation<ApiManagementGlobalSchemaResource> lro = await apiManagementGlobalSchema.UpdateAsync(WaitUntil.Completed, data);
            ApiManagementGlobalSchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGlobalSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateSchema2
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateSchema2()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementCreateGlobalSchema2.json
            // this example is just showing the usage of "GlobalSchema_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGlobalSchemaResource created on azure
            // for more information of creating ApiManagementGlobalSchemaResource, please refer to the document of ApiManagementGlobalSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string schemaId = "schema1";
            ResourceIdentifier apiManagementGlobalSchemaResourceId = ApiManagementGlobalSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, schemaId);
            ApiManagementGlobalSchemaResource apiManagementGlobalSchema = client.GetApiManagementGlobalSchemaResource(apiManagementGlobalSchemaResourceId);

            // invoke the operation
            ApiManagementGlobalSchemaData data = new ApiManagementGlobalSchemaData()
            {
                SchemaType = ApiSchemaType.Json,
                Description = "sample schema description",
                Document = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["type"] = "object",
                    ["$id"] = "https://example.com/person.schema.json",
                    ["$schema"] = "https://json-schema.org/draft/2020-12/schema",
                    ["properties"] = new Dictionary<string, object>()
                    {
                        ["age"] = new Dictionary<string, object>()
                        {
                            ["type"] = "integer",
                            ["description"] = "Age in years which must be equal to or greater than zero.",
                            ["minimum"] = "0"
                        },
                        ["firstName"] = new Dictionary<string, object>()
                        {
                            ["type"] = "string",
                            ["description"] = "The person's first name."
                        },
                        ["lastName"] = new Dictionary<string, object>()
                        {
                            ["type"] = "string",
                            ["description"] = "The person's last name."
                        }
                    },
                    ["title"] = "Person"
                }),
            };
            ArmOperation<ApiManagementGlobalSchemaResource> lro = await apiManagementGlobalSchema.UpdateAsync(WaitUntil.Completed, data);
            ApiManagementGlobalSchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGlobalSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteSchema
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementDeleteGlobalSchema.json
            // this example is just showing the usage of "GlobalSchema_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGlobalSchemaResource created on azure
            // for more information of creating ApiManagementGlobalSchemaResource, please refer to the document of ApiManagementGlobalSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string schemaId = "schema1";
            ResourceIdentifier apiManagementGlobalSchemaResourceId = ApiManagementGlobalSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, schemaId);
            ApiManagementGlobalSchemaResource apiManagementGlobalSchema = client.GetApiManagementGlobalSchemaResource(apiManagementGlobalSchemaResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementGlobalSchema.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
