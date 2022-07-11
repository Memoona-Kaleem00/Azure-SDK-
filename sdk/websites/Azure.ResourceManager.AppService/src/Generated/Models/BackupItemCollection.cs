// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Collection of backup items.
    /// Serialized Name: BackupItemCollection
    /// </summary>
    internal partial class BackupItemCollection
    {
        /// <summary> Initializes a new instance of BackupItemCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: BackupItemCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal BackupItemCollection(IEnumerable<BackupItemData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of BackupItemCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: BackupItemCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: BackupItemCollection.nextLink
        /// </param>
        internal BackupItemCollection(IReadOnlyList<BackupItemData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: BackupItemCollection.value
        /// </summary>
        public IReadOnlyList<BackupItemData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: BackupItemCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
