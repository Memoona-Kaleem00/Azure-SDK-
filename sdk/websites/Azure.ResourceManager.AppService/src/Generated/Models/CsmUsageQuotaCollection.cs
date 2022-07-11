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
    /// Collection of CSM usage quotas.
    /// Serialized Name: CsmUsageQuotaCollection
    /// </summary>
    internal partial class CsmUsageQuotaCollection
    {
        /// <summary> Initializes a new instance of CsmUsageQuotaCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: CsmUsageQuotaCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CsmUsageQuotaCollection(IEnumerable<CsmUsageQuota> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of CsmUsageQuotaCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: CsmUsageQuotaCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: CsmUsageQuotaCollection.nextLink
        /// </param>
        internal CsmUsageQuotaCollection(IReadOnlyList<CsmUsageQuota> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: CsmUsageQuotaCollection.value
        /// </summary>
        public IReadOnlyList<CsmUsageQuota> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: CsmUsageQuotaCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
