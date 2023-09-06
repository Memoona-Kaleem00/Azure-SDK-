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
    /// The base definition of a linked integration runtime.
    /// Please note <see cref="SynapseLinkedIntegrationRuntimeType"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseLinkedIntegrationRuntimeKeyAuthorization"/> and <see cref="SynapseLinkedIntegrationRuntimeRbacAuthorization"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownLinkedIntegrationRuntimeType))]
    public abstract partial class SynapseLinkedIntegrationRuntimeType
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeType"/>. </summary>
        protected SynapseLinkedIntegrationRuntimeType()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeType"/>. </summary>
        /// <param name="authorizationType"> The authorization type for integration runtime sharing. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseLinkedIntegrationRuntimeType(string authorizationType, Dictionary<string, BinaryData> rawData)
        {
            AuthorizationType = authorizationType;
            _rawData = rawData;
        }

        /// <summary> The authorization type for integration runtime sharing. </summary>
        internal string AuthorizationType { get; set; }
    }
}
