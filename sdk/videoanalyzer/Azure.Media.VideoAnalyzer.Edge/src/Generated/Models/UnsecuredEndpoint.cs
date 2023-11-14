// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Unsecured endpoint describes an endpoint that the pipeline can connect to over clear transport (no encryption in transit). </summary>
    public partial class UnsecuredEndpoint : EndpointBase
    {
        /// <summary> Initializes a new instance of <see cref="UnsecuredEndpoint"/>. </summary>
        /// <param name="url"> The endpoint URL for Video Analyzer to connect to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public UnsecuredEndpoint(string url) : base(url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Type = "#Microsoft.VideoAnalyzer.UnsecuredEndpoint";
        }

        /// <summary> Initializes a new instance of <see cref="UnsecuredEndpoint"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="credentials">
        /// Credentials to be presented to the endpoint.
        /// Please note <see cref="CredentialsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HttpHeaderCredentials"/>, <see cref="SymmetricKeyCredentials"/> and <see cref="UsernamePasswordCredentials"/>.
        /// </param>
        /// <param name="url"> The endpoint URL for Video Analyzer to connect to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnsecuredEndpoint(string type, CredentialsBase credentials, string url, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, credentials, url, serializedAdditionalRawData)
        {
            Type = type ?? "#Microsoft.VideoAnalyzer.UnsecuredEndpoint";
        }

        /// <summary> Initializes a new instance of <see cref="UnsecuredEndpoint"/> for deserialization. </summary>
        internal UnsecuredEndpoint()
        {
        }
    }
}
