// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> List of Job resources. </summary>
    internal partial class JobResourceList
    {
        /// <summary> Initializes a new instance of JobResourceList. </summary>
        internal JobResourceList()
        {
            Value = new ChangeTrackingList<JobResourceData>();
        }

        /// <summary> Initializes a new instance of JobResourceList. </summary>
        /// <param name="value"> List of resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. </param>
        internal JobResourceList(IReadOnlyList<JobResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<JobResourceData> Value { get; }
        /// <summary> The uri to fetch the next page of resources. </summary>
        public string NextLink { get; }
    }
}
