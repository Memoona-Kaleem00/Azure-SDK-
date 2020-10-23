// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of server keys. </summary>
    public partial class ServerKeyListResult
    {
        /// <summary> Initializes a new instance of ServerKeyListResult. </summary>
        internal ServerKeyListResult()
        {
            Value = new ChangeTrackingList<ServerKey>();
        }

        /// <summary> Initializes a new instance of ServerKeyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerKeyListResult(IReadOnlyList<ServerKey> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerKey> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
