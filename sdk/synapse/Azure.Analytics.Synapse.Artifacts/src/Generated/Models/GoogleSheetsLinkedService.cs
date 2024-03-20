// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for GoogleSheets. </summary>
    public partial class GoogleSheetsLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="GoogleSheetsLinkedService"/>. </summary>
        /// <param name="apiToken">
        /// The api token for the GoogleSheets source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiToken"/> is null. </exception>
        public GoogleSheetsLinkedService(SecretBase apiToken)
        {
            Argument.AssertNotNull(apiToken, nameof(apiToken));

            ApiToken = apiToken;
            Type = "GoogleSheets";
        }

        /// <summary> Initializes a new instance of <see cref="GoogleSheetsLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="apiToken">
        /// The api token for the GoogleSheets source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal GoogleSheetsLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, SecretBase apiToken, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ApiToken = apiToken;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "GoogleSheets";
        }

        /// <summary>
        /// The api token for the GoogleSheets source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ApiToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
