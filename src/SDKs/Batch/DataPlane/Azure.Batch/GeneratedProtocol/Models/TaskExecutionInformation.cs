// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about the execution of a task.
    /// </summary>
    public partial class TaskExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the TaskExecutionInformation class.
        /// </summary>
        public TaskExecutionInformation() { }

        /// <summary>
        /// Initializes a new instance of the TaskExecutionInformation class.
        /// </summary>
        /// <param name="retryCount">The number of times the task has been
        /// retried by the Batch service.</param>
        /// <param name="requeueCount">The number of times the task has been
        /// requeued by the Batch service as the result of a user
        /// request.</param>
        /// <param name="startTime">The time at which the task started
        /// running.</param>
        /// <param name="endTime">The time at which the task completed.</param>
        /// <param name="exitCode">The exit code of the program specified on
        /// the task command line.</param>
        /// <param name="failureInfo">Information describing the task failure,
        /// if any.</param>
        /// <param name="lastRetryTime">The most recent time at which a retry
        /// of the task started running.</param>
        /// <param name="lastRequeueTime">The most recent time at which the
        /// task has been requeued by the Batch service as the result of a user
        /// request.</param>
        /// <param name="result">The result of the task execution.</param>
        public TaskExecutionInformation(int retryCount, int requeueCount, System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), int? exitCode = default(int?), TaskFailureInformation failureInfo = default(TaskFailureInformation), System.DateTime? lastRetryTime = default(System.DateTime?), System.DateTime? lastRequeueTime = default(System.DateTime?), TaskExecutionResult? result = default(TaskExecutionResult?))
        {
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            FailureInfo = failureInfo;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
            RequeueCount = requeueCount;
            LastRequeueTime = lastRequeueTime;
            Result = result;
        }

        /// <summary>
        /// Gets or sets the time at which the task started running.
        /// </summary>
        /// <remarks>
        /// 'Running' corresponds to the running state, so if the task
        /// specifies resource files or application packages, then the start
        /// time reflects the time at which the task started downloading or
        /// deploying these. If the task has been restarted or retried, this is
        /// the most recent time at which the task started running. This
        /// property is present only for tasks that are in the running or
        /// completed state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the task completed.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the Completed state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the task
        /// command line.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the completed state. In
        /// general, the exit code for a process reflects the specific
        /// convention implemented by the application developer for that
        /// process. If you use the exit code value to make decisions in your
        /// code, be sure that you know the exit code convention used by the
        /// application process. However, if the Batch service terminates the
        /// task (due to timeout, or user termination via the API) you may see
        /// an operating system-defined exit code.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets information describing the task failure, if any.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the completed state and
        /// encountered a failure.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "failureInfo")]
        public TaskFailureInformation FailureInfo { get; set; }

        /// <summary>
        /// Gets or sets the number of times the task has been retried by the
        /// Batch service.
        /// </summary>
        /// <remarks>
        /// The number of times the task has been retried by the Batch service.
        /// Task application failures (non-zero exit code) are retried,
        /// pre-processing errors (the task could not be run) and file upload
        /// errors are not retried. The Batch service will retry the task up to
        /// the limit specified by the constraints.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retryCount")]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which a retry of the task
        /// started running.
        /// </summary>
        /// <remarks>
        /// This element is present only if the task was retried (i.e.
        /// retryCount is nonzero). If present, this is typically the same as
        /// startTime, but may be different if the task has been restarted for
        /// reasons other than retry; for example, if the compute node was
        /// rebooted during a retry, then the startTime is updated but the
        /// lastRetryTime is not.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRetryTime")]
        public System.DateTime? LastRetryTime { get; set; }

        /// <summary>
        /// Gets or sets the number of times the task has been requeued by the
        /// Batch service as the result of a user request.
        /// </summary>
        /// <remarks>
        /// When the user removes nodes from a pool (by resizing/shrinking the
        /// pool) or when the job is being disabled, the user can specify that
        /// running tasks on the nodes be requeued for execution. This count
        /// tracks how many times the task has been requeued for these reasons.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "requeueCount")]
        public int RequeueCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which the task has been
        /// requeued by the Batch service as the result of a user request.
        /// </summary>
        /// <remarks>
        /// This property is set only if the requeueCount is nonzero.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRequeueTime")]
        public System.DateTime? LastRequeueTime { get; set; }

        /// <summary>
        /// Gets or sets the result of the task execution.
        /// </summary>
        /// <remarks>
        /// If the value is 'failed', then the details of the failure can be
        /// found in the failureInfo property. Possible values include:
        /// 'success', 'failure'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "result")]
        public TaskExecutionResult? Result { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.FailureInfo != null)
            {
                this.FailureInfo.Validate();
            }
        }
    }
}
