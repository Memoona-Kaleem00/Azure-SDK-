// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics.Internal
{
    /// <summary> The TasksStateTasksCustomEntityRecognitionTasksItem. </summary>
    internal partial class CustomEntityRecognitionTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of CustomEntityRecognitionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal CustomEntityRecognitionTasksItem(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of CustomEntityRecognitionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="taskName"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        internal CustomEntityRecognitionTasksItem(DateTimeOffset lastUpdateDateTime, string taskName, TextAnalyticsOperationStatus status, CustomEntitiesResult results) : base(lastUpdateDateTime, taskName, status)
        {
            Results = results;
        }

        public CustomEntitiesResult Results { get; }
    }
}
