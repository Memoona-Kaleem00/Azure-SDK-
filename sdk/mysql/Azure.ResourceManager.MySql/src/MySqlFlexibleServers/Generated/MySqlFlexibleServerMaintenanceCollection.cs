// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlFlexibleServerMaintenanceResource"/> and their operations.
    /// Each <see cref="MySqlFlexibleServerMaintenanceResource"/> in the collection will belong to the same instance of <see cref="MySqlFlexibleServerResource"/>.
    /// To get a <see cref="MySqlFlexibleServerMaintenanceCollection"/> instance call the GetMySqlFlexibleServerMaintenances method from an instance of <see cref="MySqlFlexibleServerResource"/>.
    /// </summary>
    public partial class MySqlFlexibleServerMaintenanceCollection : ArmCollection, IEnumerable<MySqlFlexibleServerMaintenanceResource>, IAsyncEnumerable<MySqlFlexibleServerMaintenanceResource>
    {
        private readonly ClientDiagnostics _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics;
        private readonly MaintenancesRestOperations _mySqlFlexibleServerMaintenanceMaintenancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerMaintenanceCollection"/> class for mocking. </summary>
        protected MySqlFlexibleServerMaintenanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerMaintenanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlFlexibleServerMaintenanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerMaintenanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServerMaintenanceResource.ResourceType, out string mySqlFlexibleServerMaintenanceMaintenancesApiVersion);
            _mySqlFlexibleServerMaintenanceMaintenancesRestClient = new MaintenancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerMaintenanceMaintenancesApiVersion);
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
        /// Read maintenance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances/{maintenanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_Read</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceName"> The name of the maintenance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="maintenanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceName"/> is null. </exception>
        public virtual async Task<Response<MySqlFlexibleServerMaintenanceResource>> GetAsync(string maintenanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(maintenanceName, nameof(maintenanceName));

            using var scope = _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics.CreateScope("MySqlFlexibleServerMaintenanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerMaintenanceMaintenancesRestClient.ReadAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maintenanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerMaintenanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Read maintenance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances/{maintenanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_Read</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceName"> The name of the maintenance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="maintenanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceName"/> is null. </exception>
        public virtual Response<MySqlFlexibleServerMaintenanceResource> Get(string maintenanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(maintenanceName, nameof(maintenanceName));

            using var scope = _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics.CreateScope("MySqlFlexibleServerMaintenanceCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerMaintenanceMaintenancesRestClient.Read(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maintenanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerMaintenanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List maintenances.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerMaintenanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerMaintenanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerMaintenanceMaintenancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerMaintenanceMaintenancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerMaintenanceResource(Client, MySqlFlexibleServerMaintenanceData.DeserializeMySqlFlexibleServerMaintenanceData(e)), _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics, Pipeline, "MySqlFlexibleServerMaintenanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List maintenances.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerMaintenanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerMaintenanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerMaintenanceMaintenancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerMaintenanceMaintenancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerMaintenanceResource(Client, MySqlFlexibleServerMaintenanceData.DeserializeMySqlFlexibleServerMaintenanceData(e)), _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics, Pipeline, "MySqlFlexibleServerMaintenanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances/{maintenanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_Read</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceName"> The name of the maintenance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="maintenanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string maintenanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(maintenanceName, nameof(maintenanceName));

            using var scope = _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics.CreateScope("MySqlFlexibleServerMaintenanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerMaintenanceMaintenancesRestClient.ReadAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maintenanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances/{maintenanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_Read</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceName"> The name of the maintenance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="maintenanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string maintenanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(maintenanceName, nameof(maintenanceName));

            using var scope = _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics.CreateScope("MySqlFlexibleServerMaintenanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerMaintenanceMaintenancesRestClient.Read(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maintenanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances/{maintenanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_Read</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceName"> The name of the maintenance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="maintenanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlFlexibleServerMaintenanceResource>> GetIfExistsAsync(string maintenanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(maintenanceName, nameof(maintenanceName));

            using var scope = _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics.CreateScope("MySqlFlexibleServerMaintenanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerMaintenanceMaintenancesRestClient.ReadAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maintenanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServerMaintenanceResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerMaintenanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/maintenances/{maintenanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Maintenances_Read</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerMaintenanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceName"> The name of the maintenance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="maintenanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceName"/> is null. </exception>
        public virtual NullableResponse<MySqlFlexibleServerMaintenanceResource> GetIfExists(string maintenanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(maintenanceName, nameof(maintenanceName));

            using var scope = _mySqlFlexibleServerMaintenanceMaintenancesClientDiagnostics.CreateScope("MySqlFlexibleServerMaintenanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerMaintenanceMaintenancesRestClient.Read(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maintenanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServerMaintenanceResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerMaintenanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlFlexibleServerMaintenanceResource> IEnumerable<MySqlFlexibleServerMaintenanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlFlexibleServerMaintenanceResource> IAsyncEnumerable<MySqlFlexibleServerMaintenanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
