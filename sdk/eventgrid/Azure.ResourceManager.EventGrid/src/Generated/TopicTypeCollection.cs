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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="TopicTypeResource"/> and their operations.
    /// Each <see cref="TopicTypeResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="TopicTypeCollection"/> instance call the GetTopicTypes method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class TopicTypeCollection : ArmCollection, IEnumerable<TopicTypeResource>, IAsyncEnumerable<TopicTypeResource>
    {
        private readonly ClientDiagnostics _topicTypeClientDiagnostics;
        private readonly TopicTypesRestOperations _topicTypeRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopicTypeCollection"/> class for mocking. </summary>
        protected TopicTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopicTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TopicTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", TopicTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TopicTypeResource.ResourceType, out string topicTypeApiVersion);
            _topicTypeRestClient = new TopicTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information about a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        public virtual async Task<Response<TopicTypeResource>> GetAsync(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _topicTypeRestClient.GetAsync(topicTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        public virtual Response<TopicTypeResource> Get(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _topicTypeRestClient.Get(topicTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all registered topic types.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TopicTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TopicTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topicTypeRestClient.CreateListRequest();
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new TopicTypeResource(Client, TopicTypeData.DeserializeTopicTypeData(e)), _topicTypeClientDiagnostics, Pipeline, "TopicTypeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all registered topic types.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TopicTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TopicTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topicTypeRestClient.CreateListRequest();
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new TopicTypeResource(Client, TopicTypeData.DeserializeTopicTypeData(e)), _topicTypeClientDiagnostics, Pipeline, "TopicTypeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _topicTypeRestClient.GetAsync(topicTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _topicTypeRestClient.Get(topicTypeName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<TopicTypeResource>> GetIfExistsAsync(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _topicTypeRestClient.GetAsync(topicTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TopicTypeResource>(response.GetRawResponse());
                return Response.FromValue(new TopicTypeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        public virtual NullableResponse<TopicTypeResource> GetIfExists(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _topicTypeRestClient.Get(topicTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TopicTypeResource>(response.GetRawResponse());
                return Response.FromValue(new TopicTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TopicTypeResource> IEnumerable<TopicTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TopicTypeResource> IAsyncEnumerable<TopicTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
