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
    /// Collection of domain name identifiers.
    /// Serialized Name: NameIdentifierCollection
    /// </summary>
    internal partial class NameIdentifierCollection
    {
        /// <summary> Initializes a new instance of NameIdentifierCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: NameIdentifierCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal NameIdentifierCollection(IEnumerable<NameIdentifier> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of NameIdentifierCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: NameIdentifierCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: NameIdentifierCollection.nextLink
        /// </param>
        internal NameIdentifierCollection(IReadOnlyList<NameIdentifier> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: NameIdentifierCollection.value
        /// </summary>
        public IReadOnlyList<NameIdentifier> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: NameIdentifierCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
