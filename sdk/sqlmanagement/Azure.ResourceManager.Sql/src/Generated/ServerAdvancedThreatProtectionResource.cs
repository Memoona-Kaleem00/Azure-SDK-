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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ServerAdvancedThreatProtection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServerAdvancedThreatProtectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServerAdvancedThreatProtectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource"/> using the GetServerAdvancedThreatProtection method.
    /// </summary>
    public partial class ServerAdvancedThreatProtectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerAdvancedThreatProtectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="advancedThreatProtectionName"> The advancedThreatProtectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, AdvancedThreatProtectionName advancedThreatProtectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly ServerAdvancedThreatProtectionSettingsRestOperations _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient;
        private readonly ServerAdvancedThreatProtectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/advancedThreatProtectionSettings";

        /// <summary> Initializes a new instance of the <see cref="ServerAdvancedThreatProtectionResource"/> class for mocking. </summary>
        protected ServerAdvancedThreatProtectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerAdvancedThreatProtectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerAdvancedThreatProtectionResource(ArmClient client, ServerAdvancedThreatProtectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerAdvancedThreatProtectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerAdvancedThreatProtectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsApiVersion);
            _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient = new ServerAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServerAdvancedThreatProtectionData Data
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
        /// Get a server's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerAdvancedThreatProtectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionResource.Get");
            scope.Start();
            try
            {
                var response = await _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a server's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAdvancedThreatProtectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionResource.Get");
            scope.Start();
            try
            {
                var response = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The server Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerAdvancedThreatProtectionResource>> UpdateAsync(WaitUntil waitUntil, ServerAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionResource.Update");
            scope.Start();
            try
            {
                var response = await _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerAdvancedThreatProtectionResource>(new ServerAdvancedThreatProtectionOperationSource(Client), _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The server Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerAdvancedThreatProtectionResource> Update(WaitUntil waitUntil, ServerAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionResource.Update");
            scope.Start();
            try
            {
                var response = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<ServerAdvancedThreatProtectionResource>(new ServerAdvancedThreatProtectionOperationSource(Client), _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
