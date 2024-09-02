// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Service Principal datastore credentials configuration. </summary>
    public partial class MachineLearningServicePrincipalDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>. </summary>
        /// <param name="tenantId"> [Required] ID of the tenant to which the service principal belongs. </param>
        /// <param name="clientId"> [Required] Service principal client ID. </param>
        /// <param name="secrets"> [Required] Service principal secrets. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/> is null. </exception>
        public MachineLearningServicePrincipalDatastoreCredentials(Guid tenantId, Guid clientId, MachineLearningServicePrincipalDatastoreSecrets secrets)
        {
            Argument.AssertNotNull(secrets, nameof(secrets));

            TenantId = tenantId;
            ClientId = clientId;
            Secrets = secrets;
            CredentialsType = CredentialsType.ServicePrincipal;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="authorityUri"> Authority URL used for authentication. </param>
        /// <param name="resourceUri"> Resource the service principal has access to. </param>
        /// <param name="tenantId"> [Required] ID of the tenant to which the service principal belongs. </param>
        /// <param name="clientId"> [Required] Service principal client ID. </param>
        /// <param name="secrets"> [Required] Service principal secrets. </param>
        internal MachineLearningServicePrincipalDatastoreCredentials(CredentialsType credentialsType, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri authorityUri, Uri resourceUri, Guid tenantId, Guid clientId, MachineLearningServicePrincipalDatastoreSecrets secrets) : base(credentialsType, serializedAdditionalRawData)
        {
            AuthorityUri = authorityUri;
            ResourceUri = resourceUri;
            TenantId = tenantId;
            ClientId = clientId;
            Secrets = secrets;
            CredentialsType = credentialsType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningServicePrincipalDatastoreCredentials"/> for deserialization. </summary>
        internal MachineLearningServicePrincipalDatastoreCredentials()
        {
        }

        /// <summary> Authority URL used for authentication. </summary>
        public Uri AuthorityUri { get; set; }
        /// <summary> Resource the service principal has access to. </summary>
        public Uri ResourceUri { get; set; }
        /// <summary> [Required] ID of the tenant to which the service principal belongs. </summary>
        public Guid TenantId { get; set; }
        /// <summary> [Required] Service principal client ID. </summary>
        public Guid ClientId { get; set; }
        /// <summary> [Required] Service principal secrets. </summary>
        public MachineLearningServicePrincipalDatastoreSecrets Secrets { get; set; }
    }
}
