// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Information about a pipeline run. </summary>
    public partial class DataFactoryPipelineRunInfo
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineRunInfo"/>. </summary>
        internal DataFactoryPipelineRunInfo()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
            RunDimensions = new ChangeTrackingDictionary<string, string>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineRunInfo"/>. </summary>
        /// <param name="runId"> Identifier of a run. </param>
        /// <param name="runGroupId"> Identifier that correlates all the recovery runs of a pipeline run. </param>
        /// <param name="isLatest"> Indicates if the recovered pipeline run is the latest in its group. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="parameters"> The full or partial list of parameter name, value pair used in the pipeline run. </param>
        /// <param name="runDimensions"> Run dimensions emitted by Pipeline run. </param>
        /// <param name="invokedBy"> Entity that started the pipeline run. </param>
        /// <param name="lastUpdatedOn"> The last updated timestamp for the pipeline run event in ISO8601 format. </param>
        /// <param name="runStartOn"> The start time of a pipeline run in ISO8601 format. </param>
        /// <param name="runEndOn"> The end time of a pipeline run in ISO8601 format. </param>
        /// <param name="durationInMs"> The duration of a pipeline run. </param>
        /// <param name="status"> The status of a pipeline run. Possible values: Queued, InProgress, Succeeded, Failed, Canceling, Cancelled. </param>
        /// <param name="message"> The message from a pipeline run. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryPipelineRunInfo(Guid? runId, string runGroupId, bool? isLatest, string pipelineName, IReadOnlyDictionary<string, string> parameters, IReadOnlyDictionary<string, string> runDimensions, DataFactoryPipelineRunEntityInfo invokedBy, DateTimeOffset? lastUpdatedOn, DateTimeOffset? runStartOn, DateTimeOffset? runEndOn, int? durationInMs, string status, string message, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            RunId = runId;
            RunGroupId = runGroupId;
            IsLatest = isLatest;
            PipelineName = pipelineName;
            Parameters = parameters;
            RunDimensions = runDimensions;
            InvokedBy = invokedBy;
            LastUpdatedOn = lastUpdatedOn;
            RunStartOn = runStartOn;
            RunEndOn = runEndOn;
            DurationInMs = durationInMs;
            Status = status;
            Message = message;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Identifier of a run. </summary>
        public Guid? RunId { get; }
        /// <summary> Identifier that correlates all the recovery runs of a pipeline run. </summary>
        public string RunGroupId { get; }
        /// <summary> Indicates if the recovered pipeline run is the latest in its group. </summary>
        public bool? IsLatest { get; }
        /// <summary> The pipeline name. </summary>
        public string PipelineName { get; }
        /// <summary> The full or partial list of parameter name, value pair used in the pipeline run. </summary>
        public IReadOnlyDictionary<string, string> Parameters { get; }
        /// <summary> Run dimensions emitted by Pipeline run. </summary>
        public IReadOnlyDictionary<string, string> RunDimensions { get; }
        /// <summary> Entity that started the pipeline run. </summary>
        public DataFactoryPipelineRunEntityInfo InvokedBy { get; }
        /// <summary> The last updated timestamp for the pipeline run event in ISO8601 format. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The start time of a pipeline run in ISO8601 format. </summary>
        public DateTimeOffset? RunStartOn { get; }
        /// <summary> The end time of a pipeline run in ISO8601 format. </summary>
        public DateTimeOffset? RunEndOn { get; }
        /// <summary> The duration of a pipeline run. </summary>
        public int? DurationInMs { get; }
        /// <summary> The status of a pipeline run. Possible values: Queued, InProgress, Succeeded, Failed, Canceling, Cancelled. </summary>
        public string Status { get; }
        /// <summary> The message from a pipeline run. </summary>
        public string Message { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
