// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Base definition of WebLinkedServiceTypeProperties, this typeProperties is polymorphic based on authenticationType, so not flattened in SDK models.
    /// Please note <see cref="WebLinkedServiceTypeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WebAnonymousAuthentication"/>, <see cref="WebBasicAuthentication"/> and <see cref="WebClientCertificateAuthentication"/>.
    /// </summary>
    public abstract partial class WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of WebLinkedServiceTypeProperties. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        protected WebLinkedServiceTypeProperties(BinaryData uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
        }

        /// <summary> Initializes a new instance of WebLinkedServiceTypeProperties. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        internal WebLinkedServiceTypeProperties(BinaryData uri, WebAuthenticationType authenticationType)
        {
            Uri = uri;
            AuthenticationType = authenticationType;
        }

        /// <summary> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </summary>
        public BinaryData Uri { get; set; }
        /// <summary> Type of authentication used to connect to the web table source. </summary>
        internal WebAuthenticationType AuthenticationType { get; set; }
    }
}
