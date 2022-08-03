// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Eloqua server linked service. </summary>
    public partial class EloquaLinkedService : FactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of EloquaLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of the Eloqua server. (i.e. eloqua.example.com). </param>
        /// <param name="username"> The site name and user name of your Eloqua account in the form: sitename/username. (i.e. Eloqua/Alice). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="username"/> is null. </exception>
        public EloquaLinkedService(BinaryData endpoint, BinaryData username)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            Endpoint = endpoint;
            Username = username;
            LinkedServiceType = "Eloqua";
        }

        /// <summary> Initializes a new instance of EloquaLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of the Eloqua server. (i.e. eloqua.example.com). </param>
        /// <param name="username"> The site name and user name of your Eloqua account in the form: sitename/username. (i.e. Eloqua/Alice). </param>
        /// <param name="password">
        /// The password corresponding to the user name.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal EloquaLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData endpoint, BinaryData username, FactorySecretBaseDefinition password, BinaryData useEncryptedEndpoints, BinaryData useHostVerification, BinaryData usePeerVerification, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            Username = username;
            Password = password;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Eloqua";
        }

        /// <summary> The endpoint of the Eloqua server. (i.e. eloqua.example.com). </summary>
        public BinaryData Endpoint { get; set; }
        /// <summary> The site name and user name of your Eloqua account in the form: sitename/username. (i.e. Eloqua/Alice). </summary>
        public BinaryData Username { get; set; }
        /// <summary>
        /// The password corresponding to the user name.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Password { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public BinaryData UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public BinaryData UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public BinaryData UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
