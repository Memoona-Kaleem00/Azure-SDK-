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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A Class representing a MySqlFlexibleServerConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MySqlFlexibleServerConfigurationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMySqlFlexibleServerConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="MySqlFlexibleServerResource" /> using the GetMySqlFlexibleServerConfiguration method.
    /// </summary>
    public partial class MySqlFlexibleServerConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MySqlFlexibleServerConfigurationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string configurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _mySqlFlexibleServerConfigurationConfigurationsRestClient;
        private readonly MySqlFlexibleServerConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerConfigurationResource"/> class for mocking. </summary>
        protected MySqlFlexibleServerConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MySqlFlexibleServerConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MySqlFlexibleServerConfigurationResource(ArmClient client, MySqlFlexibleServerConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MySqlFlexibleServerConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mySqlFlexibleServerConfigurationConfigurationsApiVersion);
            _mySqlFlexibleServerConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforMySQL/flexibleServers/configurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MySqlFlexibleServerConfigurationData Data
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
        /// Gets information about a configuration of server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Updates a configuration of a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for updating a server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlFlexibleServerConfigurationResource>> UpdateAsync(WaitUntil waitUntil, MySqlFlexibleServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerConfigurationResource>(new MySqlFlexibleServerConfigurationOperationSource(Client), _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics, Pipeline, _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Updates a configuration of a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for updating a server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MySqlFlexibleServerConfigurationResource> Update(WaitUntil waitUntil, MySqlFlexibleServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerConfigurationResource>(new MySqlFlexibleServerConfigurationOperationSource(Client), _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics, Pipeline, _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
