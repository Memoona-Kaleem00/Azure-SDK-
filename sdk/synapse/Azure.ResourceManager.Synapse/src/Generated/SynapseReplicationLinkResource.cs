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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseReplicationLink along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseReplicationLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseReplicationLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseSqlPoolResource" /> using the GetSynapseReplicationLink method.
    /// </summary>
    public partial class SynapseReplicationLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseReplicationLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="sqlPoolName"> The sqlPoolName. </param>
        /// <param name="linkId"> The linkId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string linkId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/replicationLinks/{linkId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseReplicationLinkSqlPoolReplicationLinksClientDiagnostics;
        private readonly SqlPoolReplicationLinksRestOperations _synapseReplicationLinkSqlPoolReplicationLinksRestClient;
        private readonly SynapseReplicationLinkData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseReplicationLinkResource"/> class for mocking. </summary>
        protected SynapseReplicationLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseReplicationLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseReplicationLinkResource(ArmClient client, SynapseReplicationLinkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseReplicationLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseReplicationLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseReplicationLinkSqlPoolReplicationLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseReplicationLinkSqlPoolReplicationLinksApiVersion);
            _synapseReplicationLinkSqlPoolReplicationLinksRestClient = new SqlPoolReplicationLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseReplicationLinkSqlPoolReplicationLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/replicationLinks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseReplicationLinkData Data
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

        /// <summary>
        /// Get SQL pool replication link by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolReplicationLinks_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseReplicationLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseReplicationLinkSqlPoolReplicationLinksClientDiagnostics.CreateScope("SynapseReplicationLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseReplicationLinkSqlPoolReplicationLinksRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseReplicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get SQL pool replication link by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolReplicationLinks_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseReplicationLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseReplicationLinkSqlPoolReplicationLinksClientDiagnostics.CreateScope("SynapseReplicationLinkResource.Get");
            scope.Start();
            try
            {
                var response = _synapseReplicationLinkSqlPoolReplicationLinksRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseReplicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
