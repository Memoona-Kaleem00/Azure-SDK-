// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Page of a security applications list. </summary>
    internal partial class ApplicationsList
    {
        /// <summary> Initializes a new instance of ApplicationsList. </summary>
        internal ApplicationsList()
        {
            Value = new ChangeTrackingList<ApplicationData>();
        }

        /// <summary> Initializes a new instance of ApplicationsList. </summary>
        /// <param name="value"> Collection of applications in this page. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal ApplicationsList(IReadOnlyList<ApplicationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of applications in this page. </summary>
        public IReadOnlyList<ApplicationData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
