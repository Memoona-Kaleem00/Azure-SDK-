// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Spark;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkBatchJob. </summary>
    public partial class SparkBatchJob
    {
        /// <summary> Initializes a new instance of <see cref="SparkBatchJob"/>. </summary>
        /// <param name="id"> The session Id. </param>
        internal SparkBatchJob(int id)
        {
            Errors = new ChangeTrackingList<SparkServiceError>();
            Tags = new ChangeTrackingDictionary<string, string>();
            Id = id;
            AppInfo = new ChangeTrackingDictionary<string, string>();
            LogLines = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkBatchJob"/>. </summary>
        /// <param name="livyInfo"></param>
        /// <param name="name"> The batch name. </param>
        /// <param name="workspaceName"> The workspace name. </param>
        /// <param name="sparkPoolName"> The Spark pool name. </param>
        /// <param name="submitterName"> The submitter name. </param>
        /// <param name="submitterId"> The submitter identifier. </param>
        /// <param name="artifactId"> The artifact identifier. </param>
        /// <param name="jobType"> The job type. </param>
        /// <param name="result"> The Spark batch job result. </param>
        /// <param name="scheduler"> The scheduler information. </param>
        /// <param name="plugin"> The plugin information. </param>
        /// <param name="errors"> The error information. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="id"> The session Id. </param>
        /// <param name="appId"> The application id of this session. </param>
        /// <param name="appInfo"> The detailed application info. </param>
        /// <param name="state"> The batch state. </param>
        /// <param name="logLines"> The log lines. </param>
        internal SparkBatchJob(SparkBatchJobState livyInfo, string name, string workspaceName, string sparkPoolName, string submitterName, string submitterId, string artifactId, SparkJobType? jobType, SparkBatchJobResultType? result, SparkScheduler scheduler, SparkServicePlugin plugin, IReadOnlyList<SparkServiceError> errors, IReadOnlyDictionary<string, string> tags, int id, string appId, IReadOnlyDictionary<string, string> appInfo, LivyStates? state, IReadOnlyList<string> logLines)
        {
            LivyInfo = livyInfo;
            Name = name;
            WorkspaceName = workspaceName;
            SparkPoolName = sparkPoolName;
            SubmitterName = submitterName;
            SubmitterId = submitterId;
            ArtifactId = artifactId;
            JobType = jobType;
            Result = result;
            Scheduler = scheduler;
            Plugin = plugin;
            Errors = errors;
            Tags = tags;
            Id = id;
            AppId = appId;
            AppInfo = appInfo;
            State = state;
            LogLines = logLines;
        }

        /// <summary> Gets the livy info. </summary>
        public SparkBatchJobState LivyInfo { get; }
        /// <summary> The batch name. </summary>
        public string Name { get; }
        /// <summary> The workspace name. </summary>
        public string WorkspaceName { get; }
        /// <summary> The Spark pool name. </summary>
        public string SparkPoolName { get; }
        /// <summary> The submitter name. </summary>
        public string SubmitterName { get; }
        /// <summary> The submitter identifier. </summary>
        public string SubmitterId { get; }
        /// <summary> The artifact identifier. </summary>
        public string ArtifactId { get; }
        /// <summary> The job type. </summary>
        public SparkJobType? JobType { get; }
        /// <summary> The Spark batch job result. </summary>
        public SparkBatchJobResultType? Result { get; }
        /// <summary> The scheduler information. </summary>
        public SparkScheduler Scheduler { get; }
        /// <summary> The plugin information. </summary>
        public SparkServicePlugin Plugin { get; }
        /// <summary> The error information. </summary>
        public IReadOnlyList<SparkServiceError> Errors { get; }
        /// <summary> The tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> The session Id. </summary>
        public int Id { get; }
        /// <summary> The application id of this session. </summary>
        public string AppId { get; }
        /// <summary> The detailed application info. </summary>
        public IReadOnlyDictionary<string, string> AppInfo { get; }
        /// <summary> The batch state. </summary>
        public LivyStates? State { get; }
        /// <summary> The log lines. </summary>
        public IReadOnlyList<string> LogLines { get; }
    }
}
