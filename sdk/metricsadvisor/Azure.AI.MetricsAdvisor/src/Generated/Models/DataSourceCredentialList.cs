// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataSourceCredentialList. </summary>
    internal partial class DataSourceCredentialList
    {
        /// <summary> Initializes a new instance of DataSourceCredentialList. </summary>
        internal DataSourceCredentialList()
        {
            Value = new ChangeTrackingList<DatasourceCredential>();
        }

        /// <summary> Initializes a new instance of DataSourceCredentialList. </summary>
        /// <param name="nextLink"> . </param>
        /// <param name="value"> . </param>
        internal DataSourceCredentialList(string nextLink, IReadOnlyList<DatasourceCredential> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        public IReadOnlyList<DatasourceCredential> Value { get; }
    }
}
