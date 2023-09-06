// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// The base definition of a secret type.
    /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseSecureString"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownSecretBase))]
    public abstract partial class SynapseSecretBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseSecretBase"/>. </summary>
        protected SynapseSecretBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSecretBase"/>. </summary>
        /// <param name="secretBaseType"> Type of the secret. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseSecretBase(string secretBaseType, Dictionary<string, BinaryData> rawData)
        {
            SecretBaseType = secretBaseType;
            _rawData = rawData;
        }

        /// <summary> Type of the secret. </summary>
        internal string SecretBaseType { get; set; }
    }
}
