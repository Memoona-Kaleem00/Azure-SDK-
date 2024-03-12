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
    /// <summary> A FTP server Linked Service. </summary>
    public partial class FtpServerLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="FtpServerLinkedService"/>. </summary>
        /// <param name="host"> Host name of the FTP server. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public FtpServerLinkedService(DataFactoryElement<string> host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            LinkedServiceType = "FtpServer";
        }

        /// <summary> Initializes a new instance of <see cref="FtpServerLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> Host name of the FTP server. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the FTP server uses to listen for client connections. Default value is 21. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the FTP server. </param>
        /// <param name="userName"> Username to logon the FTP server. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to logon the FTP server. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="enableSsl"> If true, connect to the FTP server over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="enableServerCertificateValidation"> If true, validate the FTP server SSL certificate when connect over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        internal FtpServerLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<int> port, FtpAuthenticationType? authenticationType, DataFactoryElement<string> userName, DataFactorySecret password, string encryptedCredential, DataFactoryElement<bool> enableSsl, DataFactoryElement<bool> enableServerCertificateValidation) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            EnableSsl = enableSsl;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            LinkedServiceType = linkedServiceType ?? "FtpServer";
        }

        /// <summary> Initializes a new instance of <see cref="FtpServerLinkedService"/> for deserialization. </summary>
        internal FtpServerLinkedService()
        {
        }

        /// <summary> Host name of the FTP server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The TCP port number that the FTP server uses to listen for client connections. Default value is 21. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> The authentication type to be used to connect to the FTP server. </summary>
        public FtpAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username to logon the FTP server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password to logon the FTP server. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> If true, connect to the FTP server over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableSsl { get; set; }
        /// <summary> If true, validate the FTP server SSL certificate when connect over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableServerCertificateValidation { get; set; }
    }
}
