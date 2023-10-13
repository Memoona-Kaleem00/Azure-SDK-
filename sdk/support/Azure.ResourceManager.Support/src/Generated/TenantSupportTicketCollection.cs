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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantSupportTicketResource" /> and their operations.
    /// Each <see cref="TenantSupportTicketResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="TenantSupportTicketCollection" /> instance call the GetTenantSupportTickets method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class TenantSupportTicketCollection : ArmCollection, IEnumerable<TenantSupportTicketResource>, IAsyncEnumerable<TenantSupportTicketResource>
    {
        private readonly ClientDiagnostics _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics;
        private readonly SupportTicketsNoSubscriptionRestOperations _tenantSupportTicketSupportTicketsNoSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantSupportTicketCollection"/> class for mocking. </summary>
        protected TenantSupportTicketCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantSupportTicketCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantSupportTicketCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", TenantSupportTicketResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantSupportTicketResource.ResourceType, out string tenantSupportTicketSupportTicketsNoSubscriptionApiVersion);
            _tenantSupportTicketSupportTicketsNoSubscriptionRestClient = new SupportTicketsNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantSupportTicketSupportTicketsNoSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new support ticket for Billing, and Subscription Management issues. Learn the [prerequisites](https://aka.ms/supportAPI) required to create a support ticket.&lt;br/&gt;&lt;br/&gt;Always call the Services and ProblemClassifications API to get the most recent set of services and problem categories required for support ticket creation.&lt;br/&gt;&lt;br/&gt;Adding attachments is not currently supported via the API. To add a file to an existing support ticket, visit the [Manage support ticket](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest) page in the Azure portal, select the support ticket, and use the file upload control to add a new file.&lt;br/&gt;&lt;br/&gt;Providing consent to share diagnostic information with Azure support is currently not supported via the API. The Azure support engineer working on your ticket will reach out to you for consent if your issue requires gathering diagnostic information from your Azure resources.&lt;br/&gt;&lt;br/&gt;
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="data"> Support ticket request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantSupportTicketResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string supportTicketName, SupportTicketData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateAsync(supportTicketName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<TenantSupportTicketResource>(new TenantSupportTicketOperationSource(Client), _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics, Pipeline, _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateCreateRequest(supportTicketName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new support ticket for Billing, and Subscription Management issues. Learn the [prerequisites](https://aka.ms/supportAPI) required to create a support ticket.&lt;br/&gt;&lt;br/&gt;Always call the Services and ProblemClassifications API to get the most recent set of services and problem categories required for support ticket creation.&lt;br/&gt;&lt;br/&gt;Adding attachments is not currently supported via the API. To add a file to an existing support ticket, visit the [Manage support ticket](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest) page in the Azure portal, select the support ticket, and use the file upload control to add a new file.&lt;br/&gt;&lt;br/&gt;Providing consent to share diagnostic information with Azure support is currently not supported via the API. The Azure support engineer working on your ticket will reach out to you for consent if your issue requires gathering diagnostic information from your Azure resources.&lt;br/&gt;&lt;br/&gt;
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="data"> Support ticket request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TenantSupportTicketResource> CreateOrUpdate(WaitUntil waitUntil, string supportTicketName, SupportTicketData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.Create(supportTicketName, data, cancellationToken);
                var operation = new SupportArmOperation<TenantSupportTicketResource>(new TenantSupportTicketOperationSource(Client), _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics, Pipeline, _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateCreateRequest(supportTicketName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual async Task<Response<TenantSupportTicketResource>> GetAsync(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.GetAsync(supportTicketName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual Response<TenantSupportTicketResource> Get(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.Get(supportTicketName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the support tickets. &lt;br/&gt;&lt;br/&gt;You can also filter the support tickets by &lt;i&gt;Status&lt;/i&gt;, &lt;i&gt;CreatedDate&lt;/i&gt;, , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; using the $filter parameter. Output will be a paged result with &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support 'odata v4.0' filter semantics. &lt;a target='_blank' href='https://docs.microsoft.com/odata/concepts/queryoptions-overview'&gt;Learn more&lt;/a&gt; &lt;br/&gt;&lt;i&gt;Status&lt;/i&gt; , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; filters can only be used with 'eq' operator. For &lt;i&gt;CreatedDate&lt;/i&gt; filter, the supported operators are 'gt' and 'ge'. When using both filters, combine them using the logical 'AND'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantSupportTicketResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantSupportTicketResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateListRequest(top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateListNextPageRequest(nextLink, top, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TenantSupportTicketResource(Client, SupportTicketData.DeserializeSupportTicketData(e)), _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics, Pipeline, "TenantSupportTicketCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the support tickets. &lt;br/&gt;&lt;br/&gt;You can also filter the support tickets by &lt;i&gt;Status&lt;/i&gt;, &lt;i&gt;CreatedDate&lt;/i&gt;, , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; using the $filter parameter. Output will be a paged result with &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support 'odata v4.0' filter semantics. &lt;a target='_blank' href='https://docs.microsoft.com/odata/concepts/queryoptions-overview'&gt;Learn more&lt;/a&gt; &lt;br/&gt;&lt;i&gt;Status&lt;/i&gt; , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; filters can only be used with 'eq' operator. For &lt;i&gt;CreatedDate&lt;/i&gt; filter, the supported operators are 'gt' and 'ge'. When using both filters, combine them using the logical 'AND'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantSupportTicketResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantSupportTicketResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateListRequest(top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.CreateListNextPageRequest(nextLink, top, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TenantSupportTicketResource(Client, SupportTicketData.DeserializeSupportTicketData(e)), _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics, Pipeline, "TenantSupportTicketCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.GetAsync(supportTicketName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual Response<bool> Exists(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.Get(supportTicketName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TenantSupportTicketResource> IEnumerable<TenantSupportTicketResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantSupportTicketResource> IAsyncEnumerable<TenantSupportTicketResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
