// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformConfigurationService data model.
    /// Application Configuration Service resource
    /// </summary>
    public partial class AppPlatformConfigurationServiceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceData"/>. </summary>
        public AppPlatformConfigurationServiceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Application Configuration Service properties payload. </param>
        internal AppPlatformConfigurationServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformConfigurationServiceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Application Configuration Service properties payload. </summary>
        public AppPlatformConfigurationServiceProperties Properties { get; set; }
    }
}
