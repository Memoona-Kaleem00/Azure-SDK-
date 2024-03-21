// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.GraphServices.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmGraphServicesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="GraphServices.GraphServicesAccountResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Property bag from billing account. </param>
        /// <returns> A new <see cref="GraphServices.GraphServicesAccountResourceData"/> instance for mocking. </returns>
        public static GraphServicesAccountResourceData GraphServicesAccountResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, GraphServicesAccountResourceProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new GraphServicesAccountResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GraphServicesAccountResourceProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="appId"> Customer owned application ID. </param>
        /// <param name="billingPlanId"> Billing Plan Id. </param>
        /// <returns> A new <see cref="Models.GraphServicesAccountResourceProperties"/> instance for mocking. </returns>
        public static GraphServicesAccountResourceProperties GraphServicesAccountResourceProperties(GraphServicesProvisioningState? provisioningState = null, string appId = null, string billingPlanId = null)
        {
            return new GraphServicesAccountResourceProperties(provisioningState, appId, billingPlanId, serializedAdditionalRawData: null);
        }
    }
}
