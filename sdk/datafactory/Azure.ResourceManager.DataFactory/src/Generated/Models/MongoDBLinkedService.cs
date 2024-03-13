// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for MongoDb data source. </summary>
    public partial class MongoDBLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBLinkedService"/>. </summary>
        /// <param name="server"> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </param>
        /// <param name="databaseName"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="databaseName"/> is null. </exception>
        public MongoDBLinkedService(DataFactoryElement<string> server, DataFactoryElement<string> databaseName)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            Server = server;
            DatabaseName = databaseName;
            LinkedServiceType = "MongoDb";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the MongoDB database. </param>
        /// <param name="databaseName"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for authentication. </param>
        /// <param name="authSource"> Database to verify the username and password. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the MongoDB server uses to listen for client connections. The default value is 27017. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal MongoDBLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> server, MongoDBAuthenticationType? authenticationType, DataFactoryElement<string> databaseName, DataFactoryElement<string> username, DataFactorySecret password, DataFactoryElement<string> authSource, DataFactoryElement<int> port, DataFactoryElement<bool> enableSsl, DataFactoryElement<bool> allowSelfSignedServerCert, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            AuthenticationType = authenticationType;
            DatabaseName = databaseName;
            Username = username;
            Password = password;
            AuthSource = authSource;
            Port = port;
            EnableSsl = enableSsl;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "MongoDb";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBLinkedService"/> for deserialization. </summary>
        internal MongoDBLinkedService()
        {
        }

        /// <summary> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> The authentication type to be used to connect to the MongoDB database. </summary>
        public MongoDBAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DatabaseName { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> Password for authentication. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> Database to verify the username and password. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AuthSource { get; set; }
        /// <summary> The TCP port number that the MongoDB server uses to listen for client connections. The default value is 27017. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableSsl { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
