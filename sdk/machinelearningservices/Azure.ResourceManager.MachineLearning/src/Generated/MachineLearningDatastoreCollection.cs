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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningDatastoreResource"/> and their operations.
    /// Each <see cref="MachineLearningDatastoreResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningDatastoreCollection"/> instance call the GetMachineLearningDatastores method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningDatastoreCollection : ArmCollection, IEnumerable<MachineLearningDatastoreResource>, IAsyncEnumerable<MachineLearningDatastoreResource>
    {
        private readonly ClientDiagnostics _machineLearningDatastoreDatastoresClientDiagnostics;
        private readonly DatastoresRestOperations _machineLearningDatastoreDatastoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningDatastoreCollection"/> class for mocking. </summary>
        protected MachineLearningDatastoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningDatastoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningDatastoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningDatastoreDatastoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningDatastoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningDatastoreResource.ResourceType, out string machineLearningDatastoreDatastoresApiVersion);
            _machineLearningDatastoreDatastoresRestClient = new DatastoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningDatastoreDatastoresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update datastore.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="data"> Datastore entity to create or update. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningDatastoreResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MachineLearningDatastoreData data, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningDatastoreDatastoresRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, skipValidation, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningDatastoreResource>(Response.FromValue(new MachineLearningDatastoreResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update datastore.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="data"> Datastore entity to create or update. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningDatastoreResource> CreateOrUpdate(WaitUntil waitUntil, string name, MachineLearningDatastoreData data, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningDatastoreDatastoresRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, skipValidation, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningDatastoreResource>(Response.FromValue(new MachineLearningDatastoreResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get datastore.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MachineLearningDatastoreResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get datastore.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MachineLearningDatastoreResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List datastores.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningDatastoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningDatastoreResource> GetAllAsync(MachineLearningDatastoreCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningDatastoreCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningDatastoreDatastoresRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Count, options.IsDefault, options.Names, options.SearchText, options.OrderBy, options.OrderByAsc);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningDatastoreDatastoresRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Count, options.IsDefault, options.Names, options.SearchText, options.OrderBy, options.OrderByAsc);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningDatastoreResource(Client, MachineLearningDatastoreData.DeserializeMachineLearningDatastoreData(e)), _machineLearningDatastoreDatastoresClientDiagnostics, Pipeline, "MachineLearningDatastoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List datastores.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningDatastoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningDatastoreResource> GetAll(MachineLearningDatastoreCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningDatastoreCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningDatastoreDatastoresRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Count, options.IsDefault, options.Names, options.SearchText, options.OrderBy, options.OrderByAsc);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningDatastoreDatastoresRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Count, options.IsDefault, options.Names, options.SearchText, options.OrderBy, options.OrderByAsc);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningDatastoreResource(Client, MachineLearningDatastoreData.DeserializeMachineLearningDatastoreData(e)), _machineLearningDatastoreDatastoresClientDiagnostics, Pipeline, "MachineLearningDatastoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningDatastoreResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningDatastoreResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningDatastoreResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/datastores/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MachineLearningDatastoreResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningDatastoreDatastoresClientDiagnostics.CreateScope("MachineLearningDatastoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningDatastoreResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningDatastoreResource> IEnumerable<MachineLearningDatastoreResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningDatastoreResource> IAsyncEnumerable<MachineLearningDatastoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
