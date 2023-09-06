// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Phoenix server linked service. </summary>
    public partial class PhoenixLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="PhoenixLinkedService"/>. </summary>
        /// <param name="host"> The IP address or host name of the Phoenix server. (i.e. 192.168.222.160). </param>
        /// <param name="authenticationType"> The authentication mechanism used to connect to the Phoenix server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public PhoenixLinkedService(object host, PhoenixAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            AuthenticationType = authenticationType;
            Type = "Phoenix";
        }

        /// <summary> Initializes a new instance of <see cref="PhoenixLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The IP address or host name of the Phoenix server. (i.e. 192.168.222.160). </param>
        /// <param name="port"> The TCP port that the Phoenix server uses to listen for client connections. The default value is 8765. </param>
        /// <param name="httpPath"> The partial URL corresponding to the Phoenix server. (i.e. /gateway/sandbox/phoenix/version). The default value is hbasephoenix if using WindowsAzureHDInsightService. </param>
        /// <param name="authenticationType"> The authentication mechanism used to connect to the Phoenix server. </param>
        /// <param name="username"> The user name used to connect to the Phoenix server. </param>
        /// <param name="password">
        /// The password corresponding to the user name.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="allowHostNameCNMismatch"> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal PhoenixLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object port, object httpPath, PhoenixAuthenticationType authenticationType, object username, SecretBase password, object enableSsl, object trustedCertPath, object useSystemTrustStore, object allowHostNameCNMismatch, object allowSelfSignedServerCert, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            HttpPath = httpPath;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Phoenix";
        }

        /// <summary> Initializes a new instance of <see cref="PhoenixLinkedService"/> for deserialization. </summary>
        internal PhoenixLinkedService()
        {
        }

        /// <summary> The IP address or host name of the Phoenix server. (i.e. 192.168.222.160). </summary>
        public object Host { get; set; }
        /// <summary> The TCP port that the Phoenix server uses to listen for client connections. The default value is 8765. </summary>
        public object Port { get; set; }
        /// <summary> The partial URL corresponding to the Phoenix server. (i.e. /gateway/sandbox/phoenix/version). The default value is hbasephoenix if using WindowsAzureHDInsightService. </summary>
        public object HttpPath { get; set; }
        /// <summary> The authentication mechanism used to connect to the Phoenix server. </summary>
        public PhoenixAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to connect to the Phoenix server. </summary>
        public object Username { get; set; }
        /// <summary>
        /// The password corresponding to the user name.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </summary>
        public object EnableSsl { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public object TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public object UseSystemTrustStore { get; set; }
        /// <summary> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </summary>
        public object AllowHostNameCNMismatch { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. </summary>
        public object AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
