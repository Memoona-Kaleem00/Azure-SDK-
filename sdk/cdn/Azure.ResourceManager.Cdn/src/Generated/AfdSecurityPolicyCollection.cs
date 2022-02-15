// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdSecurityPolicy and their operations over its parent. </summary>
    public partial class AfdSecurityPolicyCollection : ArmCollection, IEnumerable<AfdSecurityPolicy>, IAsyncEnumerable<AfdSecurityPolicy>
    {
        private readonly ClientDiagnostics _afdSecurityPolicyClientDiagnostics;
        private readonly AfdSecurityPoliciesRestOperations _afdSecurityPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdSecurityPolicyCollection"/> class for mocking. </summary>
        protected AfdSecurityPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdSecurityPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AfdSecurityPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdSecurityPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", AfdSecurityPolicy.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(AfdSecurityPolicy.ResourceType, out string afdSecurityPolicyApiVersion);
            _afdSecurityPolicyRestClient = new AfdSecurityPoliciesRestOperations(_afdSecurityPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdSecurityPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new security policy within the specified profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="securityPolicy"> The security policy properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> or <paramref name="securityPolicy"/> is null. </exception>
        public async virtual Task<ArmOperation<AfdSecurityPolicy>> CreateOrUpdateAsync(bool waitForCompletion, string securityPolicyName, AfdSecurityPolicyData securityPolicy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));
            if (securityPolicy == null)
            {
                throw new ArgumentNullException(nameof(securityPolicy));
            }

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdSecurityPolicyRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdSecurityPolicy>(new AfdSecurityPolicyOperationSource(Client), _afdSecurityPolicyClientDiagnostics, Pipeline, _afdSecurityPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
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
        /// Creates a new security policy within the specified profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="securityPolicy"> The security policy properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> or <paramref name="securityPolicy"/> is null. </exception>
        public virtual ArmOperation<AfdSecurityPolicy> CreateOrUpdate(bool waitForCompletion, string securityPolicyName, AfdSecurityPolicyData securityPolicy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));
            if (securityPolicy == null)
            {
                throw new ArgumentNullException(nameof(securityPolicy));
            }

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdSecurityPolicyRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy, cancellationToken);
                var operation = new CdnArmOperation<AfdSecurityPolicy>(new AfdSecurityPolicyOperationSource(Client), _afdSecurityPolicyClientDiagnostics, Pipeline, _afdSecurityPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
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
        /// Gets an existing security policy within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Get
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public async virtual Task<Response<AfdSecurityPolicy>> GetAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdSecurityPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdSecurityPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdSecurityPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing security policy within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Get
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<AfdSecurityPolicy> Get(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _afdSecurityPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _afdSecurityPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdSecurityPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists security policies associated with the profile
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies
        /// Operation Id: AfdSecurityPolicies_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdSecurityPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdSecurityPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdSecurityPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecurityPolicyRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdSecurityPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecurityPolicyRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists security policies associated with the profile
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies
        /// Operation Id: AfdSecurityPolicies_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdSecurityPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdSecurityPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdSecurityPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecurityPolicyRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdSecurityPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecurityPolicyRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Get
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(securityPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Get
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(securityPolicyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Get
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public async virtual Task<Response<AfdSecurityPolicy>> GetIfExistsAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdSecurityPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdSecurityPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecurityPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}
        /// Operation Id: AfdSecurityPolicies_Get
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<AfdSecurityPolicy> GetIfExists(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _afdSecurityPolicyClientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdSecurityPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdSecurityPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecurityPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AfdSecurityPolicy> IEnumerable<AfdSecurityPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdSecurityPolicy> IAsyncEnumerable<AfdSecurityPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
