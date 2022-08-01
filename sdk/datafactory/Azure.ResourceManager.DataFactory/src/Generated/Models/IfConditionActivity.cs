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
    /// This activity evaluates a boolean expression and executes either the activities under the ifTrueActivities property or the ifFalseActivities property depending on the result of the expression.
    /// Serialized Name: IfConditionActivity
    /// </summary>
    public partial class IfConditionActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of IfConditionActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="expression">
        /// An expression that would evaluate to Boolean. This is used to determine the block of activities (ifTrueActivities or ifFalseActivities) that will be executed.
        /// Serialized Name: IfConditionActivity.typeProperties.expression
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="expression"/> is null. </exception>
        public IfConditionActivity(string name, Expression expression) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            Expression = expression;
            IfTrueActivities = new ChangeTrackingList<PipelineActivity>();
            IfFalseActivities = new ChangeTrackingList<PipelineActivity>();
            ActivityType = "IfCondition";
        }

        /// <summary> Initializes a new instance of IfConditionActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="activityType">
        /// Type of activity.
        /// Serialized Name: Activity.type
        /// </param>
        /// <param name="description">
        /// Activity description.
        /// Serialized Name: Activity.description
        /// </param>
        /// <param name="dependsOn">
        /// Activity depends on condition.
        /// Serialized Name: Activity.dependsOn
        /// </param>
        /// <param name="userProperties">
        /// Activity user properties.
        /// Serialized Name: Activity.userProperties
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="expression">
        /// An expression that would evaluate to Boolean. This is used to determine the block of activities (ifTrueActivities or ifFalseActivities) that will be executed.
        /// Serialized Name: IfConditionActivity.typeProperties.expression
        /// </param>
        /// <param name="ifTrueActivities">
        /// List of activities to execute if expression is evaluated to true. This is an optional property and if not provided, the activity will exit without any action.
        /// Serialized Name: IfConditionActivity.typeProperties.ifTrueActivities
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </param>
        /// <param name="ifFalseActivities">
        /// List of activities to execute if expression is evaluated to false. This is an optional property and if not provided, the activity will exit without any action.
        /// Serialized Name: IfConditionActivity.typeProperties.ifFalseActivities
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </param>
        internal IfConditionActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, Expression expression, IList<PipelineActivity> ifTrueActivities, IList<PipelineActivity> ifFalseActivities) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            Expression = expression;
            IfTrueActivities = ifTrueActivities;
            IfFalseActivities = ifFalseActivities;
            ActivityType = activityType ?? "IfCondition";
        }

        /// <summary>
        /// An expression that would evaluate to Boolean. This is used to determine the block of activities (ifTrueActivities or ifFalseActivities) that will be executed.
        /// Serialized Name: IfConditionActivity.typeProperties.expression
        /// </summary>
        public Expression Expression { get; set; }
        /// <summary>
        /// List of activities to execute if expression is evaluated to true. This is an optional property and if not provided, the activity will exit without any action.
        /// Serialized Name: IfConditionActivity.typeProperties.ifTrueActivities
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </summary>
        public IList<PipelineActivity> IfTrueActivities { get; }
        /// <summary>
        /// List of activities to execute if expression is evaluated to false. This is an optional property and if not provided, the activity will exit without any action.
        /// Serialized Name: IfConditionActivity.typeProperties.ifFalseActivities
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </summary>
        public IList<PipelineActivity> IfFalseActivities { get; }
    }
}
