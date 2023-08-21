// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeExtension. </summary>
    public partial class ResourceTypeExtension
    {
        /// <summary> Initializes a new instance of ResourceTypeExtension. </summary>
        public ResourceTypeExtension()
        {
            ExtensionCategories = new Core.ChangeTrackingList<ResourceTypeExtensionCategory>();
        }

        /// <summary> Initializes a new instance of ResourceTypeExtension. </summary>
        /// <param name="endpointUri"></param>
        /// <param name="extensionCategories"></param>
        /// <param name="timeout"></param>
        internal ResourceTypeExtension(Uri endpointUri, IList<ResourceTypeExtensionCategory> extensionCategories, TimeSpan? timeout)
        {
            EndpointUri = endpointUri;
            ExtensionCategories = extensionCategories;
            Timeout = timeout;
        }

        /// <summary> Gets or sets the endpoint uri. </summary>
        public Uri EndpointUri { get; set; }
        /// <summary> Gets the extension categories. </summary>
        public IList<ResourceTypeExtensionCategory> ExtensionCategories { get; }
        /// <summary> Gets or sets the timeout. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
