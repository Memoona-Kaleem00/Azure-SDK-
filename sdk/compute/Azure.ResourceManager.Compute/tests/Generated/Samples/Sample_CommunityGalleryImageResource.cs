// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CommunityGalleryImageResource
    {
        // Get a community gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetACommunityGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2022-01-03/examples/communityGalleryExamples/CommunityGalleryImage_Get.json
            // this example is just showing the usage of "CommunityGalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CommunityGalleryImageResource created on azure
            // for more information of creating CommunityGalleryImageResource, please refer to the document of CommunityGalleryImageResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string publicGalleryName = "publicGalleryName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier communityGalleryImageResourceId = CommunityGalleryImageResource.CreateResourceIdentifier(subscriptionId, location, publicGalleryName, galleryImageName);
            CommunityGalleryImageResource communityGalleryImage = client.GetCommunityGalleryImageResource(communityGalleryImageResourceId);

            // invoke the operation
            CommunityGalleryImageResource result = await communityGalleryImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommunityGalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
