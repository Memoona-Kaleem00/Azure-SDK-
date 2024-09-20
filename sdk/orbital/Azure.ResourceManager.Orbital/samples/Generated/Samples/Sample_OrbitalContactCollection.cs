// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Orbital.Samples
{
    public partial class Sample_OrbitalContactCollection
    {
        // List of Spacecraft
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListOfSpacecraft()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactsBySpacecraftNameList.json
            // this example is just showing the usage of "Contacts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalSpacecraftResource created on azure
            // for more information of creating OrbitalSpacecraftResource, please refer to the document of OrbitalSpacecraftResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            ResourceIdentifier orbitalSpacecraftResourceId = OrbitalSpacecraftResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName);
            OrbitalSpacecraftResource orbitalSpacecraft = client.GetOrbitalSpacecraftResource(orbitalSpacecraftResourceId);

            // get the collection of this OrbitalContactResource
            OrbitalContactCollection collection = orbitalSpacecraft.GetOrbitalContacts();

            // invoke the operation and iterate over the result
            await foreach (OrbitalContactResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OrbitalContactData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactGet.json
            // this example is just showing the usage of "Contacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalSpacecraftResource created on azure
            // for more information of creating OrbitalSpacecraftResource, please refer to the document of OrbitalSpacecraftResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            ResourceIdentifier orbitalSpacecraftResourceId = OrbitalSpacecraftResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName);
            OrbitalSpacecraftResource orbitalSpacecraft = client.GetOrbitalSpacecraftResource(orbitalSpacecraftResourceId);

            // get the collection of this OrbitalContactResource
            OrbitalContactCollection collection = orbitalSpacecraft.GetOrbitalContacts();

            // invoke the operation
            string contactName = "contact1";
            OrbitalContactResource result = await collection.GetAsync(contactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OrbitalContactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactGet.json
            // this example is just showing the usage of "Contacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalSpacecraftResource created on azure
            // for more information of creating OrbitalSpacecraftResource, please refer to the document of OrbitalSpacecraftResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            ResourceIdentifier orbitalSpacecraftResourceId = OrbitalSpacecraftResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName);
            OrbitalSpacecraftResource orbitalSpacecraft = client.GetOrbitalSpacecraftResource(orbitalSpacecraftResourceId);

            // get the collection of this OrbitalContactResource
            OrbitalContactCollection collection = orbitalSpacecraft.GetOrbitalContacts();

            // invoke the operation
            string contactName = "contact1";
            bool result = await collection.ExistsAsync(contactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactGet.json
            // this example is just showing the usage of "Contacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalSpacecraftResource created on azure
            // for more information of creating OrbitalSpacecraftResource, please refer to the document of OrbitalSpacecraftResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            ResourceIdentifier orbitalSpacecraftResourceId = OrbitalSpacecraftResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName);
            OrbitalSpacecraftResource orbitalSpacecraft = client.GetOrbitalSpacecraftResource(orbitalSpacecraftResourceId);

            // get the collection of this OrbitalContactResource
            OrbitalContactCollection collection = orbitalSpacecraft.GetOrbitalContacts();

            // invoke the operation
            string contactName = "contact1";
            NullableResponse<OrbitalContactResource> response = await collection.GetIfExistsAsync(contactName);
            OrbitalContactResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OrbitalContactData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactCreate.json
            // this example is just showing the usage of "Contacts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalSpacecraftResource created on azure
            // for more information of creating OrbitalSpacecraftResource, please refer to the document of OrbitalSpacecraftResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            ResourceIdentifier orbitalSpacecraftResourceId = OrbitalSpacecraftResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName);
            OrbitalSpacecraftResource orbitalSpacecraft = client.GetOrbitalSpacecraftResource(orbitalSpacecraftResourceId);

            // get the collection of this OrbitalContactResource
            OrbitalContactCollection collection = orbitalSpacecraft.GetOrbitalContacts();

            // invoke the operation
            string contactName = "contact1";
            OrbitalContactData data = new OrbitalContactData()
            {
                ReservationStartOn = DateTimeOffset.Parse("2022-03-02T10:58:30Z"),
                ReservationEndOn = DateTimeOffset.Parse("2022-03-02T11:10:45Z"),
                GroundStationName = "EASTUS2_0",
                ContactProfileId = new ResourceIdentifier("/subscriptions/c1be1141-a7c9-4aac-9608-3c2e2f1152c3/resourceGroups/contoso-Rgp/providers/Microsoft.Orbital/contactProfiles/CONTOSO-CP"),
            };
            ArmOperation<OrbitalContactResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, contactName, data);
            OrbitalContactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OrbitalContactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
