// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A failover group update request. </summary>
    public partial class FailoverGroupUpdateOptions
    {
        /// <summary> Initializes a new instance of FailoverGroupUpdateOptions. </summary>
        public FailoverGroupUpdateOptions()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Databases = new ChangeTrackingList<string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Read-write endpoint of the failover group instance. </summary>
        public FailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }
        /// <summary> Read-only endpoint of the failover group instance. </summary>
        public FailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }
        /// <summary> List of databases in the failover group. </summary>
        public IList<string> Databases { get; }
    }
}
