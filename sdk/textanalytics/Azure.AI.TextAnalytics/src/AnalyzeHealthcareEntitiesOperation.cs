﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.TextAnalytics.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.TextAnalytics
{
    /// <summary> Pageable operation class for analyzing multiple healthcare documents using long running operation. </summary>
    public class AnalyzeHealthcareEntitiesOperation : PageableOperation<AnalyzeHealthcareEntitiesResultCollection>, IOperation<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>, HealthcareJobState>
    {
        /// <summary>
        /// Gets an ID representing the operation that can be used to poll for the status
        /// of the long-running operation.
        /// </summary>
        public override string Id { get; }

        /// <summary>
        /// Time when the operation was created on.
        /// </summary>
        public virtual DateTimeOffset CreatedOn => _createdOn;

        /// <summary>
        /// Time when the operation will expire.
        /// </summary>
        public virtual DateTimeOffset? ExpiresOn => _expiresOn;

        /// <summary>
        /// Time when the operation was last modified on
        /// </summary>
        public virtual DateTimeOffset LastModified => _lastModified;

        /// <summary>
        /// Gets the status of the operation.
        /// </summary>
        public virtual TextAnalyticsOperationStatus Status => _status;

        /// <summary>
        /// Gets the final result of the long-running operation asynchronously.
        /// </summary>
        /// <remarks>
        /// This property can be accessed only after the operation completes successfully (HasValue is true).
        /// </remarks>
        public override AsyncPageable<AnalyzeHealthcareEntitiesResultCollection> Value => GetValuesAsync();

        /// <summary>
        /// Returns true if the long-running operation completed.
        /// </summary>
        public override bool HasCompleted => _operationInternal.HasCompleted;

        /// <summary>
        /// Returns true if the long-running operation completed successfully and has produced final result (accessible by Value property).
        /// </summary>
        public override bool HasValue => _firstPage != null;

        /// <summary>
        /// Provides communication with the Text Analytics Azure Cognitive Service through its REST API.
        /// </summary>
        private readonly TextAnalyticsRestClient _serviceClient;

        private OperationInternal<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>, HealthcareJobState> _operationInternal;

        /// <summary>
        /// Provides tools for exception creation in case of failure.
        /// </summary>
        private readonly ClientDiagnostics _diagnostics;

        /// <summary>
        /// Represents the status of the long-running operation.
        /// </summary>
        private TextAnalyticsOperationStatus _status;

        /// <summary>
        /// If the operation has an exception, this property saves its information.
        /// </summary>
        private RequestFailedException _requestFailedException;

        /// <summary>
        /// Provides the results for the first page.
        /// </summary>
        private Page<AnalyzeHealthcareEntitiesResultCollection> _firstPage;

        /// <summary>
        /// Represents the desire of the user to request statistics.
        /// This is used in every GET request.
        /// </summary>
        private readonly bool? _showStats;

        /// <summary>
        /// Time when the operation will expire.
        /// </summary>
        private DateTimeOffset? _expiresOn;

        /// <summary>
        /// Time when the operation was last modified on.
        /// </summary>
        private DateTimeOffset _lastModified;

        /// <summary>
        /// Time when the operation was created on.
        /// </summary>
        private DateTimeOffset _createdOn;

        /// <summary>
        /// Provides the input to be part of AnalyzeHealthcareEntitiesOperation class
        /// </summary>
        internal readonly IDictionary<string, int> _idToIndexMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesOperation"/> class.
        /// </summary>
        /// <param name="operationId">The ID of this operation.</param>
        /// <param name="client">The client used to check for completion.</param>
        public AnalyzeHealthcareEntitiesOperation(string operationId, TextAnalyticsClient client)
        {
            // TODO: Add argument validation here.

            Id = operationId;
            _serviceClient = client._serviceRestClient;
            _diagnostics = client._clientDiagnostics;
            _operationInternal = new(_diagnostics, this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesOperation"/> class.
        /// </summary>
        /// <param name="serviceClient">The client for communicating with the Text Analytics Azure Cognitive Service through its REST API.</param>
        /// <param name="diagnostics">The client diagnostics for exception creation in case of failure.</param>
        /// <param name="operationLocation">The address of the long-running operation. It can be obtained from the response headers upon starting the operation.</param>
        /// <param name="idToIndexMap"></param>
        /// <param name="showStats"></param>
        internal AnalyzeHealthcareEntitiesOperation(TextAnalyticsRestClient serviceClient, ClientDiagnostics diagnostics, string operationLocation, IDictionary<string, int> idToIndexMap, bool? showStats = default)
        {
            _serviceClient = serviceClient;
            _diagnostics = diagnostics;
            _idToIndexMap = idToIndexMap;
            _showStats = showStats;
            _operationInternal = new(_diagnostics, this);

            // TODO: Add validation here
            // https://github.com/Azure/azure-sdk-for-net/issues/11505
            Id = operationLocation.Split('/').Last();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesOperation"/> class. This constructor
        /// is intended to be used for mocking only.
        /// </summary>
        protected AnalyzeHealthcareEntitiesOperation()
        {
        }

        /// <summary>
        /// The last HTTP response received from the server.
        /// </summary>
        /// <remarks>
        /// The last response returned from the server during the lifecycle of this instance.
        /// An instance of <see cref="AnalyzeHealthcareEntitiesOperation"/> sends requests to a server in UpdateStatusAsync, UpdateStatus, and other methods.
        /// Responses from these requests can be accessed using GetRawResponse.
        /// </remarks>
        public override Response GetRawResponse() => _operationInternal.RawResponse;

        /// <summary>
        /// Calls the server to get updated status of the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the service call.</param>
        /// <returns>The HTTP response received from the server.</returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted, HasValue, and Value.
        /// </remarks>
        public override Response UpdateStatus(CancellationToken cancellationToken = default) =>
            _operationInternal.UpdateStatus(cancellationToken);

        /// <summary>
        /// Calls the server to get updated status of the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the service call.</param>
        /// <returns>The HTTP response received from the server.</returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted, HasValue, and Value.
        /// </remarks>
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) =>
            await _operationInternal.UpdateStatusAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public override async ValueTask<Response<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
            await _operationInternal.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="pollingInterval">
        /// The interval between status requests to the server.
        /// The interval can change based on information returned from the server.
        /// For example, the server might communicate to the client that there is not reason to poll for status change sooner than some time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public override async ValueTask<Response<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) =>
            await _operationInternal.WaitForCompletionAsync(pollingInterval, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancels a pending or running <see cref="AnalyzeHealthcareEntitiesOperation"/>.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        public virtual void Cancel(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(AnalyzeHealthcareEntitiesOperation)}.{nameof(Cancel)}");
            scope.Start();
            try
            {
                ResponseWithHeaders<TextAnalyticsCancelHealthJobHeaders> response = _serviceClient.CancelHealthJob(new Guid(Id), cancellationToken);
                _operationInternal.RawResponse = response.GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a pending or running <see cref="AnalyzeHealthcareEntitiesOperation"/>.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Task"/> to track the service request.</returns>
        public virtual async Task CancelAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(AnalyzeHealthcareEntitiesOperation)}.{nameof(Cancel)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<TextAnalyticsCancelHealthJobHeaders> response = await _serviceClient.CancelHealthJobAsync(new Guid(Id), cancellationToken).ConfigureAwait(false);
                _operationInternal.RawResponse = response.GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the final result of the long-running operation asynchronously.
        /// </summary>
        /// <remarks>
        /// Operation must complete successfully (HasValue is true) for it to provide values.
        /// </remarks>
        public override AsyncPageable<AnalyzeHealthcareEntitiesResultCollection> GetValuesAsync()
        {
            ValidateOperationStatus();

            async Task<Page<AnalyzeHealthcareEntitiesResultCollection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                //diagnostics scope?
                try
                {
                    Response<HealthcareJobState> jobState = await _serviceClient.HealthStatusNextPageAsync(nextLink, _showStats).ConfigureAwait(false);

                    AnalyzeHealthcareEntitiesResultCollection result = Transforms.ConvertToAnalyzeHealthcareEntitiesResultCollection(jobState.Value.Results, _idToIndexMap);
                    return Page.FromValues(new List<AnalyzeHealthcareEntitiesResultCollection>() { result }, jobState.Value.NextLink, jobState.GetRawResponse());
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return PageableHelpers.CreateAsyncEnumerable(_ => Task.FromResult(_firstPage), NextPageFunc);
        }

        /// <summary>
        /// Gets the final result of the long-running operation in synchronously.
        /// </summary>
        /// <remarks>
        /// Operation must complete successfully (HasValue is true) for it to provide values.
        /// </remarks>
        public override Pageable<AnalyzeHealthcareEntitiesResultCollection> GetValues()
        {
            ValidateOperationStatus();

            Page<AnalyzeHealthcareEntitiesResultCollection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                //diagnostics scope?
                try
                {
                    Response<HealthcareJobState> jobState = _serviceClient.HealthStatusNextPage(nextLink, _showStats);

                    AnalyzeHealthcareEntitiesResultCollection result = Transforms.ConvertToAnalyzeHealthcareEntitiesResultCollection(jobState.Value.Results, _idToIndexMap);
                    return Page.FromValues(new List<AnalyzeHealthcareEntitiesResultCollection>() { result }, jobState.Value.NextLink, jobState.GetRawResponse());
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return PageableHelpers.CreateEnumerable(_ => _firstPage, NextPageFunc);
        }

        private void ValidateOperationStatus()
        {
            if (!HasCompleted)
                throw new InvalidOperationException("The operation has not completed yet.");
            if (!HasValue)
                throw _requestFailedException;
        }

        async Task<Response<HealthcareJobState>> IOperation<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>, HealthcareJobState>.GetResponseAsync(CancellationToken cancellationToken) =>
            await _serviceClient.HealthStatusAsync(new Guid(Id), null, null, _showStats, cancellationToken).ConfigureAwait(false);

        Response<HealthcareJobState> IOperation<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>, HealthcareJobState>.GetResponse(CancellationToken cancellationToken) =>
            _serviceClient.HealthStatus(new Guid(Id), null, null, _showStats, cancellationToken);

        OperationState<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>> IOperation<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>, HealthcareJobState>.UpdateState(Response<HealthcareJobState> response)
        {
            var state = new OperationState<AsyncPageable<AnalyzeHealthcareEntitiesResultCollection>>();

            _status = response.Value.Status;
            _createdOn = response.Value.CreatedDateTime;
            _expiresOn = response.Value.ExpirationDateTime;
            _lastModified = response.Value.LastUpdateDateTime;

            if (_status == TextAnalyticsOperationStatus.Succeeded)
            {
                var nextLink = response.Value.NextLink;
                var value = Transforms.ConvertToAnalyzeHealthcareEntitiesResultCollection(response.Value.Results, _idToIndexMap);
                _firstPage = Page.FromValues(new List<AnalyzeHealthcareEntitiesResultCollection>() { value }, nextLink, response.GetRawResponse());

                state.Succeeded = true;
            }
            else if (_status == TextAnalyticsOperationStatus.Failed || _status == TextAnalyticsOperationStatus.Cancelled)
            {
                _requestFailedException = response.Value.Status == TextAnalyticsOperationStatus.Cancelled
                    ? new RequestFailedException("The operation was canceled so no value is available.")
                    : ClientCommon.CreateExceptionForFailedOperationAsync(async: false, _diagnostics, response.GetRawResponse(), response.Value.Errors).EnsureCompleted();

                state.Succeeded = false;
                state.OperationFailedException = _requestFailedException;
            }

            return state;
        }
    }
}
