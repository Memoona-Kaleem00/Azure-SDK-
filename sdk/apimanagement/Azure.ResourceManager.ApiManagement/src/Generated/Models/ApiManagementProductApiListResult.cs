// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged API list representation. </summary>
    internal partial class ApiManagementProductApiListResult
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementProductApiListResult"/>. </summary>
        internal ApiManagementProductApiListResult()
        {
            Value = new ChangeTrackingList<ProductApiData>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementProductApiListResult"/>. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal ApiManagementProductApiListResult(IReadOnlyList<ProductApiData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<ProductApiData> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
