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
    /// Collection of Kudu thread information elements.
    /// Serialized Name: ProcessThreadInfoCollection
    /// </summary>
    internal partial class ProcessThreadInfoCollection
    {
        /// <summary> Initializes a new instance of ProcessThreadInfoCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: ProcessThreadInfoCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ProcessThreadInfoCollection(IEnumerable<ProcessThreadInfo> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ProcessThreadInfoCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: ProcessThreadInfoCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: ProcessThreadInfoCollection.nextLink
        /// </param>
        internal ProcessThreadInfoCollection(IReadOnlyList<ProcessThreadInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: ProcessThreadInfoCollection.value
        /// </summary>
        public IReadOnlyList<ProcessThreadInfo> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: ProcessThreadInfoCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
