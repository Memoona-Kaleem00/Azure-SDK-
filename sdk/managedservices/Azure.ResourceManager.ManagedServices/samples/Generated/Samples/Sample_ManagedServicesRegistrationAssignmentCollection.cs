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
using Azure.ResourceManager.ManagedServices;
using Azure.ResourceManager.ManagedServices.Models;

namespace Azure.ResourceManager.ManagedServices.Samples
{
    public partial class Sample_ManagedServicesRegistrationAssignmentCollection
    {
        // Get Registration Assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ManagedServicesRegistrationAssignmentResource result = await collection.GetAsync(registrationAssignmentId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesRegistrationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registration Assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            bool result = await collection.ExistsAsync(registrationAssignmentId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Registration Assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            NullableResponse<ManagedServicesRegistrationAssignmentResource> response = await collection.GetIfExistsAsync(registrationAssignmentId);
            ManagedServicesRegistrationAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Put Registration Assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/PutRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ManagedServicesRegistrationAssignmentData data = new ManagedServicesRegistrationAssignmentData()
            {
                Properties = new ManagedServicesRegistrationAssignmentProperties(new ResourceIdentifier("/subscriptions/0afefe50-734e-4610-8a82-a144ahf49dea/providers/Microsoft.ManagedServices/registrationDefinitions/26c128c2-fefa-4340-9bb1-6e081c90ada2")),
            };
            ArmOperation<ManagedServicesRegistrationAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, registrationAssignmentId, data);
            ManagedServicesRegistrationAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesRegistrationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registration Assignments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationAssignments()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignments.json
            // this example is just showing the usage of "RegistrationAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (ManagedServicesRegistrationAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registration Assignments with ManagedByTenantId eq filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationAssignmentsWithManagedByTenantIdEqFilter()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignmentsWithManagedByTenantIdEqFilter.json
            // this example is just showing the usage of "RegistrationAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation and iterate over the result
            string filter = "$filter=managedByTenantId eq '83abe5cd-bcc3-441a-bd86-e6a75360cecc'";
            await foreach (ManagedServicesRegistrationAssignmentResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registration Assignments with ManagedByTenantId in filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationAssignmentsWithManagedByTenantIdInFilter()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignmentsWithManagedByTenantIdInFilter.json
            // this example is just showing the usage of "RegistrationAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationAssignmentCollection collection = client.GetManagedServicesRegistrationAssignments(scopeId);

            // invoke the operation and iterate over the result
            string filter = "$filter=managedByTenantId in (83abe5cd-bcc3-441a-bd86-e6a75360cec, de83f4a9-a76a-4025-a91a-91171923eac7)";
            await foreach (ManagedServicesRegistrationAssignmentResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
