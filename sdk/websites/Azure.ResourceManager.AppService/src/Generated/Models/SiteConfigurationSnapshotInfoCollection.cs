// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Collection of metadata for the app configuration snapshots that can be restored.
    /// Serialized Name: SiteConfigurationSnapshotInfoCollection
    /// </summary>
    internal partial class SiteConfigurationSnapshotInfoCollection
    {
        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfoCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: SiteConfigurationSnapshotInfoCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SiteConfigurationSnapshotInfoCollection(IEnumerable<SiteConfigurationSnapshotInfo> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfoCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: SiteConfigurationSnapshotInfoCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: SiteConfigurationSnapshotInfoCollection.nextLink
        /// </param>
        internal SiteConfigurationSnapshotInfoCollection(IReadOnlyList<SiteConfigurationSnapshotInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: SiteConfigurationSnapshotInfoCollection.value
        /// </summary>
        public IReadOnlyList<SiteConfigurationSnapshotInfo> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: SiteConfigurationSnapshotInfoCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
