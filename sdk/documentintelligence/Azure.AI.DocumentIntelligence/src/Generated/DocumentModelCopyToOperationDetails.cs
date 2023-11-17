// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Get Operation response object. </summary>
    public partial class DocumentModelCopyToOperationDetails : OperationDetails
    {
        /// <summary> Initializes a new instance of DocumentModelCopyToOperationDetails. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal DocumentModelCopyToOperationDetails(string operationId, OperationStatus status, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, Uri resourceLocation) : base(operationId, status, createdDateTime, lastUpdatedDateTime, resourceLocation)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(resourceLocation, nameof(resourceLocation));

            Kind = OperationKind.DocumentModelCopyTo;
        }

        /// <summary> Initializes a new instance of DocumentModelCopyToOperationDetails. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="apiVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="error"> Encountered error. </param>
        /// <param name="result"> Operation result upon success. </param>
        internal DocumentModelCopyToOperationDetails(string operationId, OperationStatus status, int? percentCompleted, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, OperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, DocumentIntelligenceError error, DocumentModelDetails result) : base(operationId, status, percentCompleted, createdDateTime, lastUpdatedDateTime, kind, resourceLocation, apiVersion, tags, error)
        {
            Result = result;
        }

        /// <summary> Operation result upon success. </summary>
        public DocumentModelDetails Result { get; }
    }
}
