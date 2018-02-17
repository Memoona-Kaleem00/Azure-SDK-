// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the result of an individual indexer execution.
    /// </summary>
    public partial class IndexerExecutionResult
    {
        /// <summary>
        /// Initializes a new instance of the IndexerExecutionResult class.
        /// </summary>
        public IndexerExecutionResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IndexerExecutionResult class.
        /// </summary>
        /// <param name="status">The outcome of this indexer execution.
        /// Possible values include: 'transientFailure', 'success',
        /// 'inProgress', 'reset'</param>
        /// <param name="errorMessage">The error message indicating the
        /// top-level error, if any.</param>
        /// <param name="startTime">The start time of this indexer
        /// execution.</param>
        /// <param name="endTime">The end time of this indexer execution, if
        /// the execution has already completed.</param>
        /// <param name="errors">The item-level indexing errors.</param>
        /// <param name="itemCount">The number of items that were processed
        /// during this indexer execution. This includes both successfully
        /// processed items and items where indexing was attempted but
        /// failed.</param>
        /// <param name="failedItemCount">The number of items that failed to be
        /// indexed during this indexer execution.</param>
        /// <param name="initialTrackingState">Change tracking state with which
        /// an indexer execution started.</param>
        /// <param name="finalTrackingState">Change tracking state with which
        /// an indexer execution finished.</param>
        public IndexerExecutionResult(IndexerExecutionStatus status = default(IndexerExecutionStatus), string errorMessage = default(string), System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), IList<ItemError> errors = default(IList<ItemError>), int itemCount = default(int), int failedItemCount = default(int), string initialTrackingState = default(string), string finalTrackingState = default(string))
        {
            Status = status;
            ErrorMessage = errorMessage;
            StartTime = startTime;
            EndTime = endTime;
            Errors = errors;
            ItemCount = itemCount;
            FailedItemCount = failedItemCount;
            InitialTrackingState = initialTrackingState;
            FinalTrackingState = finalTrackingState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the outcome of this indexer execution. Possible values
        /// include: 'transientFailure', 'success', 'inProgress', 'reset'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public IndexerExecutionStatus Status { get; private set; }

        /// <summary>
        /// Gets the error message indicating the top-level error, if any.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets the start time of this indexer execution.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTimeOffset? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time of this indexer execution, if the execution has
        /// already completed.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTimeOffset? EndTime { get; private set; }

        /// <summary>
        /// Gets the item-level indexing errors.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ItemError> Errors { get; private set; }

        /// <summary>
        /// Gets the number of items that were processed during this indexer
        /// execution. This includes both successfully processed items and
        /// items where indexing was attempted but failed.
        /// </summary>
        [JsonProperty(PropertyName = "itemsProcessed")]
        public int ItemCount { get; private set; }

        /// <summary>
        /// Gets the number of items that failed to be indexed during this
        /// indexer execution.
        /// </summary>
        [JsonProperty(PropertyName = "itemsFailed")]
        public int FailedItemCount { get; private set; }

        /// <summary>
        /// Gets change tracking state with which an indexer execution started.
        /// </summary>
        [JsonProperty(PropertyName = "initialTrackingState")]
        public string InitialTrackingState { get; private set; }

        /// <summary>
        /// Gets change tracking state with which an indexer execution
        /// finished.
        /// </summary>
        [JsonProperty(PropertyName = "finalTrackingState")]
        public string FinalTrackingState { get; private set; }

    }
}
