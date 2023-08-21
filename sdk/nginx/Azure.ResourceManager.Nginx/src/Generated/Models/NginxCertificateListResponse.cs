// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxCertificateListResponse. </summary>
    internal partial class NginxCertificateListResponse
    {
        /// <summary> Initializes a new instance of NginxCertificateListResponse. </summary>
        internal NginxCertificateListResponse()
        {
            Value = new Core.ChangeTrackingList<NginxCertificateData>();
        }

        /// <summary> Initializes a new instance of NginxCertificateListResponse. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal NginxCertificateListResponse(IReadOnlyList<NginxCertificateData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<NginxCertificateData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
