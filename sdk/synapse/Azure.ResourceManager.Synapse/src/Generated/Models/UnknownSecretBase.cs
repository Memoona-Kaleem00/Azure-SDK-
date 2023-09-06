// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The UnknownSecretBase. </summary>
    internal partial class UnknownSecretBase : SynapseSecretBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSecretBase"/>. </summary>
        /// <param name="secretBaseType"> Type of the secret. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSecretBase(string secretBaseType, Dictionary<string, BinaryData> rawData) : base(secretBaseType, rawData)
        {
            SecretBaseType = secretBaseType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSecretBase"/> for deserialization. </summary>
        internal UnknownSecretBase()
        {
        }
    }
}
