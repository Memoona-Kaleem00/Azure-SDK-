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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingSubscriptionAlias along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BillingSubscriptionAliasResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBillingSubscriptionAliasResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetBillingSubscriptionAlias method.
    /// </summary>
    public partial class BillingSubscriptionAliasResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingSubscriptionAliasResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string aliasName)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics;
        private readonly BillingSubscriptionsAliasesRestOperations _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient;
        private readonly BillingSubscriptionAliasData _data;

        /// <summary> Initializes a new instance of the <see cref="BillingSubscriptionAliasResource"/> class for mocking. </summary>
        protected BillingSubscriptionAliasResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BillingSubscriptionAliasResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingSubscriptionAliasResource(ArmClient client, BillingSubscriptionAliasData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingSubscriptionAliasResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingSubscriptionAliasResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingSubscriptionAliasBillingSubscriptionsAliasesApiVersion);
            _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient = new BillingSubscriptionsAliasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingSubscriptionAliasBillingSubscriptionsAliasesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/billingSubscriptionAliases";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingSubscriptionAliasData Data
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
        /// Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}
        /// Operation Id: BillingSubscriptionsAliases_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingSubscriptionAliasResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasResource.Get");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}
        /// Operation Id: BillingSubscriptionsAliases_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingSubscriptionAliasResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasResource.Get");
            scope.Start();
            try
            {
                var response = _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a billing subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}
        /// Operation Id: BillingSubscriptionsAliases_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> New or updated billing subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BillingSubscriptionAliasResource>> UpdateAsync(WaitUntil waitUntil, BillingSubscriptionAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasResource.Update");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation<BillingSubscriptionAliasResource>(new BillingSubscriptionAliasOperationSource(Client), _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics, Pipeline, _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a billing subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}
        /// Operation Id: BillingSubscriptionsAliases_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> New or updated billing subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BillingSubscriptionAliasResource> Update(WaitUntil waitUntil, BillingSubscriptionAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasResource.Update");
            scope.Start();
            try
            {
                var response = _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new BillingArmOperation<BillingSubscriptionAliasResource>(new BillingSubscriptionAliasOperationSource(Client), _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics, Pipeline, _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
