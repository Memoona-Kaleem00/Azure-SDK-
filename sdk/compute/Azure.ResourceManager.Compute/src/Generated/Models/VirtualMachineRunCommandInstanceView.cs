// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a virtual machine run command. </summary>
    public partial class VirtualMachineRunCommandInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineRunCommandInstanceView. </summary>
        internal VirtualMachineRunCommandInstanceView()
        {
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of VirtualMachineRunCommandInstanceView. </summary>
        /// <param name="executionState"> Script execution status. </param>
        /// <param name="executionMessage"> Communicate script configuration errors or execution messages. </param>
        /// <param name="exitCode"> Exit code returned from script execution. </param>
        /// <param name="output"> Script output stream. </param>
        /// <param name="error"> Script error stream. </param>
        /// <param name="startTime"> Script start time. </param>
        /// <param name="endTime"> Script end time. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal VirtualMachineRunCommandInstanceView(ExecutionState? executionState, string executionMessage, int? exitCode, string output, string error, DateTimeOffset? startTime, DateTimeOffset? endTime, IReadOnlyList<InstanceViewStatus> statuses)
        {
            ExecutionState = executionState;
            ExecutionMessage = executionMessage;
            ExitCode = exitCode;
            Output = output;
            Error = error;
            StartTime = startTime;
            EndTime = endTime;
            Statuses = statuses;
        }

        /// <summary> Script execution status. </summary>
        public ExecutionState? ExecutionState { get; }
        /// <summary> Communicate script configuration errors or execution messages. </summary>
        public string ExecutionMessage { get; }
        /// <summary> Exit code returned from script execution. </summary>
        public int? ExitCode { get; }
        /// <summary> Script output stream. </summary>
        public string Output { get; }
        /// <summary> Script error stream. </summary>
        public string Error { get; }
        /// <summary> Script start time. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> Script end time. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
