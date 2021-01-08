// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.Administration.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Administration
{
    /// <summary> Creates a phone number search. </summary>
    public partial class PhoneNumberAdministrationCreateSearchOperation : Operation<PhoneNumberReservation>, IOperationSource<PhoneNumberReservation>
    {
        private readonly ArmOperationHelpers<PhoneNumberReservation> _operation;
        internal PhoneNumberAdministrationCreateSearchOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<PhoneNumberReservation>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "PhoneNumberAdministrationCreateSearchOperation");
        }

        /// <inheritdoc />
        public override PhoneNumberReservation Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PhoneNumberReservation>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PhoneNumberReservation>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PhoneNumberReservation IOperationSource<PhoneNumberReservation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PhoneNumberReservation.DeserializePhoneNumberReservation(document.RootElement);
        }

        async ValueTask<PhoneNumberReservation> IOperationSource<PhoneNumberReservation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PhoneNumberReservation.DeserializePhoneNumberReservation(document.RootElement);
        }
    }
}
