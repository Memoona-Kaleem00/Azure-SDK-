// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The URIs that are the public endpoints of the account. </summary>
    public partial class AccountPropertiesEndpoints : AccountEndpoints
    {
        /// <summary> Initializes a new instance of AccountPropertiesEndpoints. </summary>
        internal AccountPropertiesEndpoints()
        {
        }

        /// <summary> Initializes a new instance of AccountPropertiesEndpoints. </summary>
        /// <param name="catalog"> Gets the catalog endpoint. </param>
        /// <param name="guardian"> Gets the guardian endpoint. </param>
        /// <param name="scan"> Gets the scan endpoint. </param>
        internal AccountPropertiesEndpoints(string catalog, string guardian, string scan) : base(catalog, guardian, scan)
        {
        }
    }
}
