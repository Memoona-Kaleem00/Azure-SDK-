// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// A pipeline activity.
    /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetDatasetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="DataFactoryScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SynapseSparkJobDefinitionActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="SynapseNotebookActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
    /// </summary>
    public partial class PipelineActivity
    {
        /// <summary> Initializes a new instance of <see cref="PipelineActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PipelineActivity(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            DependsOn = new ChangeTrackingList<PipelineActivityDependency>();
            UserProperties = new ChangeTrackingList<PipelineActivityUserProperty>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="PipelineActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties)
        {
            Name = name;
            ActivityType = activityType;
            Description = description;
            State = state;
            OnInactiveMarkAs = onInactiveMarkAs;
            DependsOn = dependsOn;
            UserProperties = userProperties;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Activity name. </summary>
        public string Name { get; set; }
        /// <summary> Type of activity. </summary>
        internal string ActivityType { get; set; }
        /// <summary> Activity description. </summary>
        public string Description { get; set; }
        /// <summary> Activity state. This is an optional property and if not provided, the state will be Active by default. </summary>
        public PipelineActivityState? State { get; set; }
        /// <summary> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </summary>
        public ActivityOnInactiveMarkAs? OnInactiveMarkAs { get; set; }
        /// <summary> Activity depends on condition. </summary>
        public IList<PipelineActivityDependency> DependsOn { get; }
        /// <summary> Activity user properties. </summary>
        public IList<PipelineActivityUserProperty> UserProperties { get; }
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
