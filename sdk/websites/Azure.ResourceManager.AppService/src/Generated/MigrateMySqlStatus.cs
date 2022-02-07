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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a MigrateMySqlStatus along with the instance operations that can be performed on it. </summary>
    public partial class MigrateMySqlStatus : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MigrateMySqlStatus"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/migratemysql/status";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _migrateMySqlStatusWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _migrateMySqlStatusWebAppsRestClient;
        private readonly MigrateMySqlStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="MigrateMySqlStatus"/> class for mocking. </summary>
        protected MigrateMySqlStatus()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MigrateMySqlStatus"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MigrateMySqlStatus(ArmClient client, MigrateMySqlStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MigrateMySqlStatus"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MigrateMySqlStatus(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrateMySqlStatusWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string migrateMySqlStatusWebAppsApiVersion);
            _migrateMySqlStatusWebAppsRestClient = new WebAppsRestOperations(_migrateMySqlStatusWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, migrateMySqlStatusWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/migratemysql";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MigrateMySqlStatusData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/migratemysql/status
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/migratemysql/status
        /// OperationId: WebApps_GetMigrateMySqlStatusSlot
        /// <summary> Description for Returns the status of MySql in app migration, if one is active, and whether or not MySql in app is enabled. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<MigrateMySqlStatus>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrateMySqlStatusWebAppsClientDiagnostics.CreateScope("MigrateMySqlStatus.Get");
            scope.Start();
            try
            {
                var response = await _migrateMySqlStatusWebAppsRestClient.GetMigrateMySqlStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _migrateMySqlStatusWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MigrateMySqlStatus(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/migratemysql/status
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/migratemysql/status
        /// OperationId: WebApps_GetMigrateMySqlStatusSlot
        /// <summary> Description for Returns the status of MySql in app migration, if one is active, and whether or not MySql in app is enabled. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrateMySqlStatus> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _migrateMySqlStatusWebAppsClientDiagnostics.CreateScope("MigrateMySqlStatus.Get");
            scope.Start();
            try
            {
                var response = _migrateMySqlStatusWebAppsRestClient.GetMigrateMySqlStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _migrateMySqlStatusWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrateMySqlStatus(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
