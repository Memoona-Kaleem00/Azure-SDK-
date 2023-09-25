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
using Azure.ResourceManager.Marketplace;
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace.Samples
{
    public partial class Sample_PrivateStoreOfferResource
    {
        // GetPrivateStoreCollectionOffer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateStoreCollectionOffer()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetPrivateStoreCollectionOffer.json
            // this example is just showing the usage of "PrivateStoreCollectionOffer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreOfferResource created on azure
            // for more information of creating PrivateStoreOfferResource, please refer to the document of PrivateStoreOfferResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            Guid collectionId = Guid.Parse("56a1a02d-8cf8-45df-bf37-d5f7120fcb3d");
            string offerId = "marketplacetestthirdparty.md-test-third-party-2";
            ResourceIdentifier privateStoreOfferResourceId = PrivateStoreOfferResource.CreateResourceIdentifier(privateStoreId, collectionId, offerId);
            PrivateStoreOfferResource privateStoreOffer = client.GetPrivateStoreOfferResource(privateStoreOfferResourceId);

            // invoke the operation
            PrivateStoreOfferResource result = await privateStoreOffer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateStoreOfferData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateStoreOffer_update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PrivateStoreOfferUpdate()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/PrivateStoreOffer_update.json
            // this example is just showing the usage of "PrivateStoreCollectionOffer_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreOfferResource created on azure
            // for more information of creating PrivateStoreOfferResource, please refer to the document of PrivateStoreOfferResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            Guid collectionId = Guid.Parse("56a1a02d-8cf8-45df-bf37-d5f7120fcb3d");
            string offerId = "marketplacetestthirdparty.md-test-third-party-2";
            ResourceIdentifier privateStoreOfferResourceId = PrivateStoreOfferResource.CreateResourceIdentifier(privateStoreId, collectionId, offerId);
            PrivateStoreOfferResource privateStoreOffer = client.GetPrivateStoreOfferResource(privateStoreOfferResourceId);

            // invoke the operation
            PrivateStoreOfferData data = new PrivateStoreOfferData()
            {
                ETag = new ETag("\"9301f4fd-0000-0100-0000-5e248b350666\""),
                SpecificPlanIdsLimitation =
{
"0001","0002"
},
            };
            ArmOperation<PrivateStoreOfferResource> lro = await privateStoreOffer.UpdateAsync(WaitUntil.Completed, data);
            PrivateStoreOfferResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateStoreOfferData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeletePrivateStoreOffer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePrivateStoreOffer()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/DeletePrivateStoreOffer.json
            // this example is just showing the usage of "PrivateStoreCollectionOffer_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreOfferResource created on azure
            // for more information of creating PrivateStoreOfferResource, please refer to the document of PrivateStoreOfferResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            Guid collectionId = Guid.Parse("56a1a02d-8cf8-45df-bf37-d5f7120fcb3d");
            string offerId = "marketplacetestthirdparty.md-test-third-party-2";
            ResourceIdentifier privateStoreOfferResourceId = PrivateStoreOfferResource.CreateResourceIdentifier(privateStoreId, collectionId, offerId);
            PrivateStoreOfferResource privateStoreOffer = client.GetPrivateStoreOfferResource(privateStoreOfferResourceId);

            // invoke the operation
            await privateStoreOffer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // PostPrivateStoreCollectionOffer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PostPrivateStoreCollectionOffer()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/PostPrivateStoreCollectionOffer.json
            // this example is just showing the usage of "PrivateStoreCollectionOffer_Post" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreOfferResource created on azure
            // for more information of creating PrivateStoreOfferResource, please refer to the document of PrivateStoreOfferResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            Guid collectionId = Guid.Parse("56a1a02d-8cf8-45df-bf37-d5f7120fcb3d");
            string offerId = "marketplacetestthirdparty.md-test-third-party-2";
            ResourceIdentifier privateStoreOfferResourceId = PrivateStoreOfferResource.CreateResourceIdentifier(privateStoreId, collectionId, offerId);
            PrivateStoreOfferResource privateStoreOffer = client.GetPrivateStoreOfferResource(privateStoreOfferResourceId);

            // invoke the operation
            await privateStoreOffer.DeleteAsync();

            Console.WriteLine($"Succeeded");
        }

        // UpsertOfferWithMultiContext
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpsertOfferWithMultiContext_UpsertOfferWithMultiContext()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/UpsertOfferWithMultiContext.json
            // this example is just showing the usage of "PrivateStoreCollectionOffer_UpsertOfferWithMultiContext" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreOfferResource created on azure
            // for more information of creating PrivateStoreOfferResource, please refer to the document of PrivateStoreOfferResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            Guid collectionId = Guid.Parse("56a1a02d-8cf8-45df-bf37-d5f7120fcb3d");
            string offerId = "contoso.logger";
            ResourceIdentifier privateStoreOfferResourceId = PrivateStoreOfferResource.CreateResourceIdentifier(privateStoreId, collectionId, offerId);
            PrivateStoreOfferResource privateStoreOffer = client.GetPrivateStoreOfferResource(privateStoreOfferResourceId);

            // invoke the operation
            MultiContextAndPlansContent content = new MultiContextAndPlansContent()
            {
                OfferId = "contoso.logger",
                ETag = new ETag("\"9301f4fd-0000-0100-0000-5e248b350332\""),
                PlansContext =
{
new ContextAndPlansDetails()
{
Context = "a5edbe7d-9f73-47fd-834a-0d6142f4c7a1",
PlanIds =
{
"log4db","log4file"
},
},new ContextAndPlansDetails()
{
Context = "45b604af-19bb-448e-a761-4a6be7374b2f",
PlanIds =
{
"log4web"
},
}
},
            };
            PrivateStoreOfferResource result = await privateStoreOffer.UpsertOfferWithMultiContextAsync(content: content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateStoreOfferData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
