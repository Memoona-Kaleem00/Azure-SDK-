// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Peering Client
    /// </summary>
    public partial interface IPeeringManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The Azure subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The client API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the ILegacyPeeringsOperations.
        /// </summary>
        ILegacyPeeringsOperations LegacyPeerings { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IPeerAsnsOperations.
        /// </summary>
        IPeerAsnsOperations PeerAsns { get; }

        /// <summary>
        /// Gets the IPeeringLocationsOperations.
        /// </summary>
        IPeeringLocationsOperations PeeringLocations { get; }

        /// <summary>
        /// Gets the IRegisteredAsnsOperations.
        /// </summary>
        IRegisteredAsnsOperations RegisteredAsns { get; }

        /// <summary>
        /// Gets the IRegisteredPrefixesOperations.
        /// </summary>
        IRegisteredPrefixesOperations RegisteredPrefixes { get; }

        /// <summary>
        /// Gets the IPeeringsOperations.
        /// </summary>
        IPeeringsOperations Peerings { get; }

        /// <summary>
        /// Gets the IPeeringServiceCountriesOperations.
        /// </summary>
        IPeeringServiceCountriesOperations PeeringServiceCountries { get; }

        /// <summary>
        /// Gets the IPeeringServiceLocationsOperations.
        /// </summary>
        IPeeringServiceLocationsOperations PeeringServiceLocations { get; }

        /// <summary>
        /// Gets the IPrefixesOperations.
        /// </summary>
        IPrefixesOperations Prefixes { get; }

        /// <summary>
        /// Gets the IPeeringServiceProvidersOperations.
        /// </summary>
        IPeeringServiceProvidersOperations PeeringServiceProviders { get; }

        /// <summary>
        /// Gets the IPeeringServicesOperations.
        /// </summary>
        IPeeringServicesOperations PeeringServices { get; }

        /// <summary>
        /// Checks if the peering service provider is present within 1000 miles
        /// of customer's location
        /// </summary>
        /// <param name='peeringServiceLocation'>
        /// Gets or sets the peering service location.
        /// </param>
        /// <param name='peeringServiceProvider'>
        /// Gets or sets the peering service provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<string>> CheckServiceProviderAvailabilityWithHttpMessagesAsync(string peeringServiceLocation = default(string), string peeringServiceProvider = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
