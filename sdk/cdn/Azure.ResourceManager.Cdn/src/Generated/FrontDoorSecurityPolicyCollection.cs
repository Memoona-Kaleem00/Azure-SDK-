// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorSecurityPolicyResource"/> and their operations.
    /// Each <see cref="FrontDoorSecurityPolicyResource"/> in the collection will belong to the same instance of <see cref="ProfileResource"/>.
    /// To get a <see cref="FrontDoorSecurityPolicyCollection"/> instance call the GetFrontDoorSecurityPolicies method from an instance of <see cref="ProfileResource"/>.
    /// </summary>
    public partial class FrontDoorSecurityPolicyCollection : ArmCollection, IEnumerable<FrontDoorSecurityPolicyResource>, IAsyncEnumerable<FrontDoorSecurityPolicyResource>
    {
        private readonly ClientDiagnostics _frontDoorSecurityPolicyClientDiagnostics;
        private readonly FrontDoorSecurityPoliciesRestOperations _frontDoorSecurityPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorSecurityPolicyCollection"/> class for mocking. </summary>
        protected FrontDoorSecurityPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorSecurityPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorSecurityPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorSecurityPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", FrontDoorSecurityPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorSecurityPolicyResource.ResourceType, out string frontDoorSecurityPolicyApiVersion);
            _frontDoorSecurityPolicyRestClient = new FrontDoorSecurityPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorSecurityPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new security policy within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="data"> The security policy properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorSecurityPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string securityPolicyName, FrontDoorSecurityPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorSecurityPolicyRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorSecurityPolicyResource>(new FrontDoorSecurityPolicyOperationSource(Client), _frontDoorSecurityPolicyClientDiagnostics, Pipeline, _frontDoorSecurityPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new security policy within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="data"> The security policy properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorSecurityPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string securityPolicyName, FrontDoorSecurityPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorSecurityPolicyRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, data, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorSecurityPolicyResource>(new FrontDoorSecurityPolicyOperationSource(Client), _frontDoorSecurityPolicyClientDiagnostics, Pipeline, _frontDoorSecurityPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an existing security policy within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorSecurityPolicyResource>> GetAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorSecurityPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecurityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing security policy within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<FrontDoorSecurityPolicyResource> Get(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorSecurityPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecurityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists security policies associated with the profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_ListByProfile</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorSecurityPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorSecurityPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorSecurityPolicyRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorSecurityPolicyRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorSecurityPolicyResource(Client, FrontDoorSecurityPolicyData.DeserializeFrontDoorSecurityPolicyData(e)), _frontDoorSecurityPolicyClientDiagnostics, Pipeline, "FrontDoorSecurityPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists security policies associated with the profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_ListByProfile</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorSecurityPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorSecurityPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorSecurityPolicyRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorSecurityPolicyRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorSecurityPolicyResource(Client, FrontDoorSecurityPolicyData.DeserializeFrontDoorSecurityPolicyData(e)), _frontDoorSecurityPolicyClientDiagnostics, Pipeline, "FrontDoorSecurityPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorSecurityPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorSecurityPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<FrontDoorSecurityPolicyResource>> GetIfExistsAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontDoorSecurityPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorSecurityPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecurityPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/securityPolicies/{securityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecurityPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/securityPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual NullableResponse<FrontDoorSecurityPolicyResource> GetIfExists(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPolicyName, nameof(securityPolicyName));

            using var scope = _frontDoorSecurityPolicyClientDiagnostics.CreateScope("FrontDoorSecurityPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontDoorSecurityPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorSecurityPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecurityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorSecurityPolicyResource> IEnumerable<FrontDoorSecurityPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorSecurityPolicyResource> IAsyncEnumerable<FrontDoorSecurityPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
