// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the login flow, including the scopes that should be requested. </summary>
    internal partial class LoginScopes
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LoginScopes"/>. </summary>
        public LoginScopes()
        {
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LoginScopes"/>. </summary>
        /// <param name="scopes"> A list of the scopes that should be requested while authenticating. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoginScopes(IList<string> scopes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scopes = scopes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> Scopes { get; }
    }
}
