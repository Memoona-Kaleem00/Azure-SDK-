// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Collection compose of certificate resources list and a possible link for next page. </summary>
    internal partial class CertificateResourceList
    {
        /// <summary> Initializes a new instance of CertificateResourceList. </summary>
        internal CertificateResourceList()
        {
            Value = new ChangeTrackingList<CertificateResourceData>();
        }

        /// <summary> Initializes a new instance of CertificateResourceList. </summary>
        /// <param name="value"> The certificate resources list. </param>
        /// <param name="nextLink"> The link to next page of certificate list. </param>
        internal CertificateResourceList(IReadOnlyList<CertificateResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The certificate resources list. </summary>
        public IReadOnlyList<CertificateResourceData> Value { get; }
        /// <summary> The link to next page of certificate list. </summary>
        public string NextLink { get; }
    }
}
