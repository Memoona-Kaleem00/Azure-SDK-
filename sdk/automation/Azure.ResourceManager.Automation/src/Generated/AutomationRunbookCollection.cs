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

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationRunbookResource"/> and their operations.
    /// Each <see cref="AutomationRunbookResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationRunbookCollection"/> instance call the GetAutomationRunbooks method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationRunbookCollection : ArmCollection, IEnumerable<AutomationRunbookResource>, IAsyncEnumerable<AutomationRunbookResource>
    {
        private readonly ClientDiagnostics _automationRunbookRunbookClientDiagnostics;
        private readonly RunbookRestOperations _automationRunbookRunbookRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationRunbookCollection"/> class for mocking. </summary>
        protected AutomationRunbookCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationRunbookCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationRunbookCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationRunbookRunbookClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationRunbookResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationRunbookResource.ResourceType, out string automationRunbookRunbookApiVersion);
            _automationRunbookRunbookRestClient = new RunbookRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationRunbookRunbookApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the runbook identified by runbook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="content"> The create or update parameters for runbook. Provide either content link for a published runbook or draft, not both. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationRunbookResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string runbookName, AutomationRunbookCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationRunbookRunbookRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationRunbookResource>(Response.FromValue(new AutomationRunbookResource(Client, response), response.GetRawResponse()));
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
        /// Create the runbook identified by runbook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="content"> The create or update parameters for runbook. Provide either content link for a published runbook or draft, not both. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationRunbookResource> CreateOrUpdate(WaitUntil waitUntil, string runbookName, AutomationRunbookCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationRunbookRunbookRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationRunbookResource>(Response.FromValue(new AutomationRunbookResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the runbook identified by runbook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> is null. </exception>
        public virtual async Task<Response<AutomationRunbookResource>> GetAsync(string runbookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationRunbookRunbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationRunbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the runbook identified by runbook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> is null. </exception>
        public virtual Response<AutomationRunbookResource> Get(string runbookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.Get");
            scope.Start();
            try
            {
                var response = _automationRunbookRunbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationRunbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of runbooks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationRunbookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationRunbookResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationRunbookRunbookRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationRunbookRunbookRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationRunbookResource(Client, AutomationRunbookData.DeserializeAutomationRunbookData(e)), _automationRunbookRunbookClientDiagnostics, Pipeline, "AutomationRunbookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of runbooks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationRunbookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationRunbookResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationRunbookRunbookRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationRunbookRunbookRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationRunbookResource(Client, AutomationRunbookData.DeserializeAutomationRunbookData(e)), _automationRunbookRunbookClientDiagnostics, Pipeline, "AutomationRunbookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runbookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationRunbookRunbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> is null. </exception>
        public virtual Response<bool> Exists(string runbookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationRunbookRunbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationRunbookResource>> GetIfExistsAsync(string runbookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationRunbookRunbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationRunbookResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationRunbookResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runbook_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automation/automationAccounts/runbooks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runbookName"/> is null. </exception>
        public virtual NullableResponse<AutomationRunbookResource> GetIfExists(string runbookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var scope = _automationRunbookRunbookClientDiagnostics.CreateScope("AutomationRunbookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationRunbookRunbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runbookName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationRunbookResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationRunbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationRunbookResource> IEnumerable<AutomationRunbookResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationRunbookResource> IAsyncEnumerable<AutomationRunbookResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
