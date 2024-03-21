// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Service Classification result object. </summary>
    public partial class ServiceClassificationAnswer : ClassificationService
    {
        /// <summary> Initializes a new instance of <see cref="ServiceClassificationAnswer"/>. </summary>
        internal ServiceClassificationAnswer()
        {
            ResourceTypesChildServiceResourceTypes = new ChangeTrackingList<ResourceType>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceClassificationAnswer"/>. </summary>
        /// <param name="serviceId"> Azure resource Id of the service. </param>
        /// <param name="displayName"> Localized name of the azure service. </param>
        /// <param name="resourceTypes"> List of applicable ARM resource types for this service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="serviceIdChildServiceId"> Azure resource Id of the service. </param>
        /// <param name="displayNameChildServiceDisplayName"> Localized name of the azure service. </param>
        /// <param name="resourceTypesChildServiceResourceTypes"> List of applicable ARM resource types for this service. </param>
        internal ServiceClassificationAnswer(ResourceIdentifier serviceId, string displayName, IReadOnlyList<ResourceType> resourceTypes, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier serviceIdChildServiceId, string displayNameChildServiceDisplayName, IReadOnlyList<ResourceType> resourceTypesChildServiceResourceTypes) : base(serviceId, displayName, resourceTypes, serializedAdditionalRawData)
        {
            ServiceIdChildServiceId = serviceIdChildServiceId;
            DisplayNameChildServiceDisplayName = displayNameChildServiceDisplayName;
            ResourceTypesChildServiceResourceTypes = resourceTypesChildServiceResourceTypes;
        }

        /// <summary> Azure resource Id of the service. </summary>
        public ResourceIdentifier ServiceIdChildServiceId { get; }
        /// <summary> Localized name of the azure service. </summary>
        public string DisplayNameChildServiceDisplayName { get; }
        /// <summary> List of applicable ARM resource types for this service. </summary>
        public IReadOnlyList<ResourceType> ResourceTypesChildServiceResourceTypes { get; }
    }
}
