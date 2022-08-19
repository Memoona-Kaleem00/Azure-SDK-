// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlFlexibleServerConfigurationResource" /> and their operations.
    /// Each <see cref="MySqlFlexibleServerConfigurationResource" /> in the collection will belong to the same instance of <see cref="MySqlFlexibleServerResource" />.
    /// To get a <see cref="MySqlFlexibleServerConfigurationCollection" /> instance call the GetMySqlFlexibleServerConfigurations method from an instance of <see cref="MySqlFlexibleServerResource" />.
    /// </summary>
    public partial class MySqlFlexibleServerConfigurationCollection : ArmCollection, IEnumerable<MySqlFlexibleServerConfigurationResource>, IAsyncEnumerable<MySqlFlexibleServerConfigurationResource>
    {
        private readonly ClientDiagnostics _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _mySqlFlexibleServerConfigurationConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerConfigurationCollection"/> class for mocking. </summary>
        protected MySqlFlexibleServerConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlFlexibleServerConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServerConfigurationResource.ResourceType, out string mySqlFlexibleServerConfigurationConfigurationsApiVersion);
            _mySqlFlexibleServerConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<MySqlFlexibleServerConfigurationResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<MySqlFlexibleServerConfigurationResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations
        /// Operation Id: Configurations_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlFlexibleServerConfigurationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Values.Select(value => new MySqlFlexibleServerConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MySqlFlexibleServerConfigurationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Values.Select(value => new MySqlFlexibleServerConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations
        /// Operation Id: Configurations_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MySqlFlexibleServerConfigurationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Values.Select(value => new MySqlFlexibleServerConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MySqlFlexibleServerConfigurationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Values.Select(value => new MySqlFlexibleServerConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlFlexibleServerConfigurationResource> IEnumerable<MySqlFlexibleServerConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlFlexibleServerConfigurationResource> IAsyncEnumerable<MySqlFlexibleServerConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
