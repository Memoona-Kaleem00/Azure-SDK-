// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Session properties. </summary>
    public partial class NotebookSessionProperties
    {
        /// <summary> Initializes a new instance of <see cref="NotebookSessionProperties"/>. </summary>
        /// <param name="driverMemory"> Amount of memory to use for the driver process. </param>
        /// <param name="driverCores"> Number of cores to use for the driver. </param>
        /// <param name="executorMemory"> Amount of memory to use per executor process. </param>
        /// <param name="executorCores"> Number of cores to use for each executor. </param>
        /// <param name="numExecutors"> Number of executors to launch for this session. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="driverMemory"/> or <paramref name="executorMemory"/> is null. </exception>
        public NotebookSessionProperties(string driverMemory, int driverCores, string executorMemory, int executorCores, int numExecutors)
        {
            Argument.AssertNotNull(driverMemory, nameof(driverMemory));
            Argument.AssertNotNull(executorMemory, nameof(executorMemory));

            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            NumExecutors = numExecutors;
        }

        /// <summary> Amount of memory to use for the driver process. </summary>
        public string DriverMemory { get; set; }
        /// <summary> Number of cores to use for the driver. </summary>
        public int DriverCores { get; set; }
        /// <summary> Amount of memory to use per executor process. </summary>
        public string ExecutorMemory { get; set; }
        /// <summary> Number of cores to use for each executor. </summary>
        public int ExecutorCores { get; set; }
        /// <summary> Number of executors to launch for this session. </summary>
        public int NumExecutors { get; set; }
    }
}
