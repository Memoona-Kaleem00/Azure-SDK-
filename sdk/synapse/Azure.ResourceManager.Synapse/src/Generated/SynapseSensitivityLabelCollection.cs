// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseSensitivityLabelResource"/> and their operations.
    /// Each <see cref="SynapseSensitivityLabelResource"/> in the collection will belong to the same instance of <see cref="SynapseSqlPoolColumnResource"/>.
    /// To get a <see cref="SynapseSensitivityLabelCollection"/> instance call the GetSynapseSensitivityLabels method from an instance of <see cref="SynapseSqlPoolColumnResource"/>.
    /// </summary>
    public partial class SynapseSensitivityLabelCollection : ArmCollection
    {
        private readonly ClientDiagnostics _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics;
        private readonly SqlPoolSensitivityLabelsRestOperations _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSensitivityLabelCollection"/> class for mocking. </summary>
        protected SynapseSensitivityLabelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSensitivityLabelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSensitivityLabelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSensitivityLabelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSensitivityLabelResource.ResourceType, out string synapseSensitivityLabelSqlPoolSensitivityLabelsApiVersion);
            _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient = new SqlPoolSensitivityLabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSensitivityLabelSqlPoolSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolColumnResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolColumnResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the sensitivity label of a given column in a Sql pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseSensitivityLabelResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseSensitivityLabelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new SynapseArmOperation<SynapseSensitivityLabelResource>(Response.FromValue(new SynapseSensitivityLabelResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Creates or updates the sensitivity label of a given column in a Sql pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseSensitivityLabelResource> CreateOrUpdate(WaitUntil waitUntil, SynapseSensitivityLabelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new SynapseArmOperation<SynapseSensitivityLabelResource>(Response.FromValue(new SynapseSensitivityLabelResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Gets the sensitivity label of a given column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseSensitivityLabelResource>> GetAsync(SynapseSensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSensitivityLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseSensitivityLabelResource> Get(SynapseSensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSensitivityLabelResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseSensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseSensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SynapseSensitivityLabelResource>> GetIfExistsAsync(SynapseSensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSensitivityLabelResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSensitivityLabelResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSensitivityLabels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSensitivityLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SynapseSensitivityLabelResource> GetIfExists(SynapseSensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SynapseSensitivityLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseSensitivityLabelSqlPoolSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSensitivityLabelResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSensitivityLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
