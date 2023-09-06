// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> AML file system HSM settings. </summary>
    public partial class AmlFileSystemHsmSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHsmSettings"/>. </summary>
        /// <param name="container"> Resource ID of storage container used for hydrating the namespace and archiving from the namespace. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <param name="loggingContainer"> Resource ID of storage container used for logging events and errors.  Must be a separate container in the same storage account as the hydration and archive container. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="container"/> or <paramref name="loggingContainer"/> is null. </exception>
        public AmlFileSystemHsmSettings(string container, string loggingContainer)
        {
            Argument.AssertNotNull(container, nameof(container));
            Argument.AssertNotNull(loggingContainer, nameof(loggingContainer));

            Container = container;
            LoggingContainer = loggingContainer;
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHsmSettings"/>. </summary>
        /// <param name="container"> Resource ID of storage container used for hydrating the namespace and archiving from the namespace. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <param name="loggingContainer"> Resource ID of storage container used for logging events and errors.  Must be a separate container in the same storage account as the hydration and archive container. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <param name="importPrefix"> Only blobs in the non-logging container that start with this path/prefix get hydrated into the cluster namespace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlFileSystemHsmSettings(string container, string loggingContainer, string importPrefix, Dictionary<string, BinaryData> rawData)
        {
            Container = container;
            LoggingContainer = loggingContainer;
            ImportPrefix = importPrefix;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHsmSettings"/> for deserialization. </summary>
        internal AmlFileSystemHsmSettings()
        {
        }

        /// <summary> Resource ID of storage container used for hydrating the namespace and archiving from the namespace. The resource provider must have permission to create SAS tokens on the storage account. </summary>
        public string Container { get; set; }
        /// <summary> Resource ID of storage container used for logging events and errors.  Must be a separate container in the same storage account as the hydration and archive container. The resource provider must have permission to create SAS tokens on the storage account. </summary>
        public string LoggingContainer { get; set; }
        /// <summary> Only blobs in the non-logging container that start with this path/prefix get hydrated into the cluster namespace. </summary>
        public string ImportPrefix { get; set; }
    }
}
