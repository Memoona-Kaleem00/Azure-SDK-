// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A WebLinkedService that uses client certificate based authentication to communicate with an HTTP endpoint. This scheme follows mutual authentication; the server must also provide valid credentials to the client. </summary>
    public partial class WebClientCertificateAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="WebClientCertificateAuthentication"/>. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="pfx"> Base64-encoded contents of a PFX file. </param>
        /// <param name="password"> Password for the PFX file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/>, <paramref name="pfx"/> or <paramref name="password"/> is null. </exception>
        public WebClientCertificateAuthentication(DataFactoryElement<string> uri, DataFactorySecretBaseDefinition pfx, DataFactorySecretBaseDefinition password) : base(uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));
            Argument.AssertNotNull(pfx, nameof(pfx));
            Argument.AssertNotNull(password, nameof(password));

            Pfx = pfx;
            Password = password;
            AuthenticationType = WebAuthenticationType.ClientCertificate;
        }

        /// <summary> Initializes a new instance of <see cref="WebClientCertificateAuthentication"/>. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="pfx"> Base64-encoded contents of a PFX file. </param>
        /// <param name="password"> Password for the PFX file. </param>
        internal WebClientCertificateAuthentication(DataFactoryElement<string> uri, WebAuthenticationType authenticationType, DataFactorySecretBaseDefinition pfx, DataFactorySecretBaseDefinition password) : base(uri, authenticationType)
        {
            Pfx = pfx;
            Password = password;
            AuthenticationType = authenticationType;
        }

        /// <summary> Base64-encoded contents of a PFX file. </summary>
        public DataFactorySecretBaseDefinition Pfx { get; set; }
        /// <summary> Password for the PFX file. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
    }
}
