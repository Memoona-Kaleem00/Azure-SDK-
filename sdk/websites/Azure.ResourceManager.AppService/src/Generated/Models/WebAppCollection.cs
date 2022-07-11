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
    /// Collection of App Service apps.
    /// Serialized Name: WebAppCollection
    /// </summary>
    internal partial class WebAppCollection
    {
        /// <summary> Initializes a new instance of WebAppCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: WebAppCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal WebAppCollection(IEnumerable<WebSiteData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of WebAppCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: WebAppCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: WebAppCollection.nextLink
        /// </param>
        internal WebAppCollection(IReadOnlyList<WebSiteData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: WebAppCollection.value
        /// </summary>
        public IReadOnlyList<WebSiteData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: WebAppCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
