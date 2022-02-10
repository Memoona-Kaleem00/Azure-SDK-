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

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A Class representing a AfdSecret along with the instance operations that can be performed on it. </summary>
    public partial class AfdSecret : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AfdSecret"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string secretName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _afdSecretClientDiagnostics;
        private readonly AfdSecretsRestOperations _afdSecretRestClient;
        private readonly AfdSecretData _data;

        /// <summary> Initializes a new instance of the <see cref="AfdSecret"/> class for mocking. </summary>
        protected AfdSecret()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AfdSecret"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AfdSecret(ArmClient client, AfdSecretData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AfdSecret"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AfdSecret(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdSecretClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string afdSecretApiVersion);
            _afdSecretRestClient = new AfdSecretsRestOperations(_afdSecretClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdSecretApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/secrets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AfdSecretData Data
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

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AfdSecret>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecret.Get");
            scope.Start();
            try
            {
                var response = await _afdSecretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdSecretClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdSecret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AfdSecret> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecret.Get");
            scope.Start();
            try
            {
                var response = _afdSecretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _afdSecretClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdSecret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing Secret within profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecret.Delete");
            scope.Start();
            try
            {
                var response = await _afdSecretRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_afdSecretClientDiagnostics, Pipeline, _afdSecretRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing Secret within profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecret.Delete");
            scope.Start();
            try
            {
                var response = _afdSecretRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_afdSecretClientDiagnostics, Pipeline, _afdSecretRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
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
