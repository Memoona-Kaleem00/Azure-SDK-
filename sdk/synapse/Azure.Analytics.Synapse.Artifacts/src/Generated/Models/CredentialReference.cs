// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Credential reference type. </summary>
    public partial class CredentialReference
    {
        /// <summary> Initializes a new instance of <see cref="CredentialReference"/>. </summary>
        /// <param name="type"> Credential reference type. </param>
        /// <param name="referenceName"> Reference credential name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public CredentialReference(CredentialReferenceType type, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="CredentialReference"/>. </summary>
        /// <param name="type"> Credential reference type. </param>
        /// <param name="referenceName"> Reference credential name. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CredentialReference(CredentialReferenceType type, string referenceName, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            ReferenceName = referenceName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Credential reference type. </summary>
        public CredentialReferenceType Type { get; set; }
        /// <summary> Reference credential name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
