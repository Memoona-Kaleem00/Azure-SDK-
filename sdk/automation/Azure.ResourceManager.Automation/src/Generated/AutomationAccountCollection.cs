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
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationAccountResource"/> and their operations.
    /// Each <see cref="AutomationAccountResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AutomationAccountCollection"/> instance call the GetAutomationAccounts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AutomationAccountCollection : ArmCollection, IEnumerable<AutomationAccountResource>, IAsyncEnumerable<AutomationAccountResource>
    {
        private readonly ClientDiagnostics _automationAccountClientDiagnostics;
        private readonly AutomationAccountRestOperations _automationAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountCollection"/> class for mocking. </summary>
        protected AutomationAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationAccountResource.ResourceType, out string automationAccountApiVersion);
            _automationAccountRestClient = new AutomationAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update automation account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="content"> Parameters supplied to the create or update automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string automationAccountName, AutomationAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationAccountRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, content, cancellationToken).ConfigureAwait(false);
                var uri = _automationAccountRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AutomationArmOperation<AutomationAccountResource>(Response.FromValue(new AutomationAccountResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update automation account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="content"> Parameters supplied to the create or update automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationAccountResource> CreateOrUpdate(WaitUntil waitUntil, string automationAccountName, AutomationAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationAccountRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, content, cancellationToken);
                var uri = _automationAccountRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AutomationArmOperation<AutomationAccountResource>(Response.FromValue(new AutomationAccountResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get information about an Automation Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        public virtual async Task<Response<AutomationAccountResource>> GetAsync(string automationAccountName, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about an Automation Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        public virtual Response<AutomationAccountResource> Get(string automationAccountName, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _automationAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of accounts within a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountResource(Client, AutomationAccountData.DeserializeAutomationAccountData(e)), _automationAccountClientDiagnostics, Pipeline, "AutomationAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of accounts within a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountResource(Client, AutomationAccountData.DeserializeAutomationAccountData(e)), _automationAccountClientDiagnostics, Pipeline, "AutomationAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string automationAccountName, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string automationAccountName, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationAccountResource>> GetIfExistsAsync(string automationAccountName, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationAccountResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        public virtual NullableResponse<AutomationAccountResource> GetIfExists(string automationAccountName, CancellationToken cancellationToken = default)
        {
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }

            using var scope = _automationAccountClientDiagnostics.CreateScope("AutomationAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, automationAccountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationAccountResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationAccountResource> IEnumerable<AutomationAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationAccountResource> IAsyncEnumerable<AutomationAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
