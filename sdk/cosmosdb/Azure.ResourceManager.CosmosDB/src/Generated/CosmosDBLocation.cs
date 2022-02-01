// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a CosmosDBLocation along with the instance operations that can be performed on it. </summary>
    public partial class CosmosDBLocation : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBLocation"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBLocationLocationsClientDiagnostics;
        private readonly LocationsRestOperations _cosmosDBLocationLocationsRestClient;
        private readonly CosmosDBLocationData _data;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocation"/> class for mocking. </summary>
        protected CosmosDBLocation()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CosmosDBLocation"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBLocation(ArmClient armClient, CosmosDBLocationData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocation"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBLocation(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _cosmosDBLocationLocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string cosmosDBLocationLocationsApiVersion);
            _cosmosDBLocationLocationsRestClient = new LocationsRestOperations(_cosmosDBLocationLocationsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cosmosDBLocationLocationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/locations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBLocationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Get the properties of an existing Cosmos DB location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CosmosDBLocation>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocation.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _cosmosDBLocationLocationsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CosmosDBLocation(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the properties of an existing Cosmos DB location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBLocation> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocation.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _cosmosDBLocationLocationsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocation(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocation.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocation.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region RestorableDatabaseAccount

        /// <summary> Gets a collection of RestorableDatabaseAccounts in the CosmosDBLocation. </summary>
        /// <returns> An object representing collection of RestorableDatabaseAccounts and their operations over a CosmosDBLocation. </returns>
        public virtual RestorableDatabaseAccountCollection GetRestorableDatabaseAccounts()
        {
            return new RestorableDatabaseAccountCollection(this);
        }
        #endregion
    }
}
