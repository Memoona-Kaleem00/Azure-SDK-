// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Batch
{
    /// <summary>
    /// Contains constants for interacting with the Azure Batch service.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The prefix used when creating automatically named containers or blobs as part of file staging.
        /// </summary>
        public const string DefaultConveniencePrefix = "mab-";

        /// <summary>
        /// The name of the standard output file generated by a task or start task on a compute node.
        /// </summary>
        public const string StandardOutFileName = "stdout.txt";

        /// <summary>
        /// The name of the standard error file generated by a task or start task on a compute node.
        /// </summary>
        public const string StandardErrorFileName = "stderr.txt";

        /// <summary>
        /// The maximum number of tasks that the client will include in a single AddTaskCollection request,
        /// when adding multiple tasks to a job.
        /// </summary>
        public const int MaxTasksInSingleAddTaskCollectionRequest = 100;
        
        /// <summary>
        /// The default amount of time to wait for a response from the Batch service before automatically cancelling the 
        /// request.
        /// </summary>
        public static readonly TimeSpan DefaultSingleRestRequestClientTimeout = TimeSpan.FromSeconds(60);

        /// <summary>
        /// The default amount of time to wait for a response from the Batch service before automatically cancelling the 
        /// request. This is used for "long running" requests such as get file and bulk add task.
        /// </summary>
        public static readonly TimeSpan DefaultLongRestRequestClientTimeout = TimeSpan.FromSeconds(180);
    }

    internal static class InternalConstants
    {
        /// <summary>
        /// The value to use for UserAgent header.
        /// </summary>
        internal const string UserAgentProductName = "AzBatch";

        internal const string ClientRequestIdHeader = "client-request-id";

        internal const string RequestIdHeader = "request-id";
    }
}
