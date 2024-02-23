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
    /// A class representing a collection of <see cref="AutomationScheduleResource"/> and their operations.
    /// Each <see cref="AutomationScheduleResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationScheduleCollection"/> instance call the GetAutomationSchedules method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationScheduleCollection : ArmCollection, IEnumerable<AutomationScheduleResource>, IAsyncEnumerable<AutomationScheduleResource>
    {
        private readonly ClientDiagnostics _automationScheduleScheduleClientDiagnostics;
        private readonly ScheduleRestOperations _automationScheduleScheduleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationScheduleCollection"/> class for mocking. </summary>
        protected AutomationScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationScheduleScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationScheduleResource.ResourceType, out string automationScheduleScheduleApiVersion);
            _automationScheduleScheduleRestClient = new ScheduleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationScheduleScheduleApiVersion);
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
        /// Create a schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="content"> The parameters supplied to the create or update schedule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scheduleName, AutomationScheduleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationScheduleScheduleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, content, cancellationToken).ConfigureAwait(false);
                var uri = _automationScheduleScheduleRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AutomationArmOperation<AutomationScheduleResource>(Response.FromValue(new AutomationScheduleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="content"> The parameters supplied to the create or update schedule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string scheduleName, AutomationScheduleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationScheduleScheduleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, content, cancellationToken);
                var uri = _automationScheduleScheduleRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AutomationArmOperation<AutomationScheduleResource>(Response.FromValue(new AutomationScheduleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Retrieve the schedule identified by schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<Response<AutomationScheduleResource>> GetAsync(string scheduleName, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationScheduleScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the schedule identified by schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual Response<AutomationScheduleResource> Get(string scheduleName, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _automationScheduleScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of schedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationScheduleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationScheduleScheduleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationScheduleScheduleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationScheduleResource(Client, AutomationScheduleData.DeserializeAutomationScheduleData(e)), _automationScheduleScheduleClientDiagnostics, Pipeline, "AutomationScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of schedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationScheduleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationScheduleScheduleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationScheduleScheduleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationScheduleResource(Client, AutomationScheduleData.DeserializeAutomationScheduleData(e)), _automationScheduleScheduleClientDiagnostics, Pipeline, "AutomationScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scheduleName, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationScheduleScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string scheduleName, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationScheduleScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationScheduleResource>> GetIfExistsAsync(string scheduleName, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationScheduleScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedule_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual NullableResponse<AutomationScheduleResource> GetIfExists(string scheduleName, CancellationToken cancellationToken = default)
        {
            if (scheduleName == null)
            {
                throw new ArgumentNullException(nameof(scheduleName));
            }
            if (scheduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(scheduleName));
            }

            using var scope = _automationScheduleScheduleClientDiagnostics.CreateScope("AutomationScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationScheduleScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationScheduleResource> IEnumerable<AutomationScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationScheduleResource> IAsyncEnumerable<AutomationScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
