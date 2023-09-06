// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Specification for an App Service Environment to use for this resource. </summary>
    public partial class HostingEnvironmentProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HostingEnvironmentProfile"/>. </summary>
        public HostingEnvironmentProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HostingEnvironmentProfile"/>. </summary>
        /// <param name="id"> Resource ID of the App Service Environment. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="resourceType"> Resource type of the App Service Environment. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HostingEnvironmentProfile(ResourceIdentifier id, string name, ResourceType? resourceType, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Resource ID of the App Service Environment. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Name of the App Service Environment. </summary>
        public string Name { get; }
        /// <summary> Resource type of the App Service Environment. </summary>
        public ResourceType? ResourceType { get; }
    }
}
