// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A class representing the operations that can be performed over a specific PolicySetDefinition. </summary>
    public partial class PolicySetDefinitionTenantOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, PolicySetDefinition>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal PolicySetDefinitionsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="PolicySetDefinitionTenantOperations"/> class for mocking. </summary>
        protected PolicySetDefinitionTenantOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicySetDefinitionTenantOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal PolicySetDefinitionTenantOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            RestClient = new PolicySetDefinitionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policySetDefinitions";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<PolicySetDefinition>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicySetDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<PolicySetDefinition> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.Name, cancellationToken);
                return Response.FromValue(new PolicySetDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> This operation deletes the policy set definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy set definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy set definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Azure.Operation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await RestClient.DeleteAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return new PolicySetDefinitionsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy set definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Azure.Operation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.StartDelete");
            scope.Start();
            try
            {
                var response = RestClient.Delete(Id.Name, cancellationToken);
                return new PolicySetDefinitionsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> This operation retrieves the built-in policy set definition with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicySetDefinitionData>> GetBuiltInAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.GetBuiltIn");
            scope.Start();
            try
            {
                return await RestClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the built-in policy set definition with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicySetDefinitionData> GetBuiltIn(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.GetBuiltIn");
            scope.Start();
            try
            {
                return RestClient.GetBuiltIn(Id.Name, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy set definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAtManagementGroupAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.DeleteAtManagementGroup");
            scope.Start();
            try
            {
                return await RestClient.DeleteAtManagementGroupAsync(Id.Name, Id.Name, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy set definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteAtManagementGroup(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.DeleteAtManagementGroup");
            scope.Start();
            try
            {
                return RestClient.DeleteAtManagementGroup(Id.Name, Id.Name, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy set definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicySetDefinitionData>> GetAtManagementGroupAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.GetAtManagementGroup");
            scope.Start();
            try
            {
                return await RestClient.GetAtManagementGroupAsync(Id.Name, Id.Name, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy set definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicySetDefinitionData> GetAtManagementGroup(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionTenantOperations.GetAtManagementGroup");
            scope.Start();
            try
            {
                return RestClient.GetAtManagementGroup(Id.Name, Id.Name, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
