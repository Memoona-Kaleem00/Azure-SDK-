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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a RecommendedAction along with the instance operations that can be performed on it. </summary>
    public partial class RecommendedAction : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RecommendedAction"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string advisorName, string recommendedActionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _recommendedActionDatabaseRecommendedActionsClientDiagnostics;
        private readonly DatabaseRecommendedActionsRestOperations _recommendedActionDatabaseRecommendedActionsRestClient;
        private readonly RecommendedActionData _data;

        /// <summary> Initializes a new instance of the <see cref="RecommendedAction"/> class for mocking. </summary>
        protected RecommendedAction()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RecommendedAction"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RecommendedAction(ArmClient client, RecommendedActionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RecommendedAction"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RecommendedAction(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recommendedActionDatabaseRecommendedActionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string recommendedActionDatabaseRecommendedActionsApiVersion);
            _recommendedActionDatabaseRecommendedActionsRestClient = new DatabaseRecommendedActionsRestOperations(_recommendedActionDatabaseRecommendedActionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, recommendedActionDatabaseRecommendedActionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/advisors/recommendedActions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RecommendedActionData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// OperationId: DatabaseRecommendedActions_Get
        /// <summary> Gets a database recommended action. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<RecommendedAction>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _recommendedActionDatabaseRecommendedActionsClientDiagnostics.CreateScope("RecommendedAction.Get");
            scope.Start();
            try
            {
                var response = await _recommendedActionDatabaseRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _recommendedActionDatabaseRecommendedActionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RecommendedAction(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// OperationId: DatabaseRecommendedActions_Get
        /// <summary> Gets a database recommended action. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RecommendedAction> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _recommendedActionDatabaseRecommendedActionsClientDiagnostics.CreateScope("RecommendedAction.Get");
            scope.Start();
            try
            {
                var response = _recommendedActionDatabaseRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _recommendedActionDatabaseRecommendedActionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecommendedAction(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// OperationId: DatabaseRecommendedActions_Update
        /// <summary> Updates a database recommended action. </summary>
        /// <param name="parameters"> The requested recommended action resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<RecommendedAction>> UpdateAsync(RecommendedActionData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _recommendedActionDatabaseRecommendedActionsClientDiagnostics.CreateScope("RecommendedAction.Update");
            scope.Start();
            try
            {
                var response = await _recommendedActionDatabaseRecommendedActionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RecommendedAction(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// OperationId: DatabaseRecommendedActions_Update
        /// <summary> Updates a database recommended action. </summary>
        /// <param name="parameters"> The requested recommended action resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<RecommendedAction> Update(RecommendedActionData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _recommendedActionDatabaseRecommendedActionsClientDiagnostics.CreateScope("RecommendedAction.Update");
            scope.Start();
            try
            {
                var response = _recommendedActionDatabaseRecommendedActionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new RecommendedAction(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
