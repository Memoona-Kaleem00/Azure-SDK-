// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Administration.Models
{
    /// <summary> A private endpoint class. </summary>
    public partial class PrivateEndpoint
    {
        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        internal PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        /// <param name="id"> The private endpoint identifier. </param>
        internal PrivateEndpoint(string id)
        {
            Id = id;
        }

        /// <summary> The private endpoint identifier. </summary>
        public string Id { get; }
    }
}
