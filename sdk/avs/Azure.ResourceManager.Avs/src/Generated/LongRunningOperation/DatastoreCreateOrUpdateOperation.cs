// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Avs;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Create or update a datastore in a private cloud cluster. </summary>
    public partial class DatastoreCreateOrUpdateOperation : Operation<Datastore>, IOperationSource<Datastore>
    {
        private readonly OperationInternals<Datastore> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DatastoreCreateOrUpdateOperation for mocking. </summary>
        protected DatastoreCreateOrUpdateOperation()
        {
        }

        internal DatastoreCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<Datastore>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DatastoreCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Datastore Value => _operation.Value;

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
        public override ValueTask<Response<Datastore>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Datastore>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Datastore IOperationSource<Datastore>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new Datastore(_operationBase, DatastoreData.DeserializeDatastoreData(document.RootElement));
        }

        async ValueTask<Datastore> IOperationSource<Datastore>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new Datastore(_operationBase, DatastoreData.DeserializeDatastoreData(document.RootElement));
        }
    }
}
