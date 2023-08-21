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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlAdvisorResource" /> and their operations.
    /// Each <see cref="MySqlAdvisorResource" /> in the collection will belong to the same instance of <see cref="MySqlServerResource" />.
    /// To get a <see cref="MySqlAdvisorCollection" /> instance call the GetMySqlAdvisors method from an instance of <see cref="MySqlServerResource" />.
    /// </summary>
    public partial class MySqlAdvisorCollection : ArmCollection, IEnumerable<MySqlAdvisorResource>, IAsyncEnumerable<MySqlAdvisorResource>
    {
        private readonly ClientDiagnostics _mySqlAdvisorAdvisorsClientDiagnostics;
        private readonly AdvisorsRestOperations _mySqlAdvisorAdvisorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlAdvisorCollection"/> class for mocking. </summary>
        protected MySqlAdvisorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlAdvisorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlAdvisorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlAdvisorAdvisorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlAdvisorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlAdvisorResource.ResourceType, out string mySqlAdvisorAdvisorsApiVersion);
            _mySqlAdvisorAdvisorsRestClient = new AdvisorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlAdvisorAdvisorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a recommendation action advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<MySqlAdvisorResource>> GetAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _mySqlAdvisorAdvisorsClientDiagnostics.CreateScope("MySqlAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlAdvisorAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a recommendation action advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<MySqlAdvisorResource> Get(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _mySqlAdvisorAdvisorsClientDiagnostics.CreateScope("MySqlAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlAdvisorAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List recommendation action advisors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlAdvisorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlAdvisorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlAdvisorAdvisorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlAdvisorAdvisorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MySqlAdvisorResource(Client, MySqlAdvisorData.DeserializeMySqlAdvisorData(e)), _mySqlAdvisorAdvisorsClientDiagnostics, Pipeline, "MySqlAdvisorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List recommendation action advisors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlAdvisorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlAdvisorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlAdvisorAdvisorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlAdvisorAdvisorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MySqlAdvisorResource(Client, MySqlAdvisorData.DeserializeMySqlAdvisorData(e)), _mySqlAdvisorAdvisorsClientDiagnostics, Pipeline, "MySqlAdvisorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _mySqlAdvisorAdvisorsClientDiagnostics.CreateScope("MySqlAdvisorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlAdvisorAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<bool> Exists(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _mySqlAdvisorAdvisorsClientDiagnostics.CreateScope("MySqlAdvisorCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlAdvisorAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlAdvisorResource> IEnumerable<MySqlAdvisorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlAdvisorResource> IAsyncEnumerable<MySqlAdvisorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
