// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storagetasks;

namespace Azure.ResourceManager.Storagetasks.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmStoragetasksModelFactory
    {
        /// <summary> Initializes a new instance of StorageTaskData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identity of the resource. </param>
        /// <param name="taskVersion"> Storage task version. </param>
        /// <param name="enabled"> Storage Task is enabled when set to true and disabled when set to false. </param>
        /// <param name="description"> Text that describes the purpose of the storage task. </param>
        /// <param name="action"> The storage task action that is executed. </param>
        /// <param name="provisioningState"> Represents the provisioning state of the storage task. </param>
        /// <param name="creationTimeInUtc"> The creation date and time of the storage task in UTC. </param>
        /// <returns> A new <see cref="Storagetasks.StorageTaskData"/> instance for mocking. </returns>
        public static StorageTaskData StorageTaskData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, long? taskVersion = null, bool? enabled = null, string description = null, StorageTaskAction action = null, ProvisioningState? provisioningState = null, DateTimeOffset? creationTimeInUtc = null)
        {
            tags ??= new Dictionary<string, string>();

            return new StorageTaskData(id, name, resourceType, systemData, tags, location, identity, taskVersion, enabled, description, action, provisioningState, creationTimeInUtc);
        }

        /// <summary> Initializes a new instance of StorageTaskReportInstance. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Storage task execution report for a run instance. </param>
        /// <returns> A new <see cref="Models.StorageTaskReportInstance"/> instance for mocking. </returns>
        public static StorageTaskReportInstance StorageTaskReportInstance(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, StorageTaskReportProperties properties = null)
        {
            return new StorageTaskReportInstance(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of StorageTaskReportProperties. </summary>
        /// <param name="taskAssignmentId"> Represents the Storage Task Assignment Id associated with the storage task that provided an execution context. </param>
        /// <param name="storageAccountId"> Represents the Storage Account Id where the storage task definition was applied and executed. </param>
        /// <param name="startTime"> Start time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison operators can be used as described for DateTime properties in https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators. </param>
        /// <param name="finishTime"> End time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison operators can be used as described for DateTime properties in https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators. </param>
        /// <param name="objectsTargetedCount"> Total number of objects that meet the condition as defined in the storage task assignment execution context. Filter options such as objectsTargetedCount gt 50 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators. </param>
        /// <param name="objectsOperatedOnCount"> Total number of objects that meet the storage tasks condition and were operated upon. Filter options such as objectsOperatedOnCount ge 100 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators. </param>
        /// <param name="objectFailedCount"> Total number of objects where task operation failed when was attempted. Filter options such as objectFailedCount eq 0 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators. </param>
        /// <param name="objectsSucceededCount"> Total number of objects where task operation succeeded when was attempted.Filter options such as objectsSucceededCount gt 150 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators. </param>
        /// <param name="runStatusError"> Well known Azure Storage error code that represents the error encountered during execution of the run instance. </param>
        /// <param name="runStatusEnum"> Represents the status of the execution. </param>
        /// <param name="summaryReportPath"> Full path to the verbose report stored in the reporting container as specified in the assignment execution context for the storage account. </param>
        /// <param name="taskId"> Storage Task Arm Id. </param>
        /// <param name="taskVersion"> Storage Task Version. </param>
        /// <param name="runResult"> Represents the overall result of the execution for the run instance. </param>
        /// <returns> A new <see cref="Models.StorageTaskReportProperties"/> instance for mocking. </returns>
        public static StorageTaskReportProperties StorageTaskReportProperties(ResourceIdentifier taskAssignmentId = null, ResourceIdentifier storageAccountId = null, string startTime = null, string finishTime = null, string objectsTargetedCount = null, string objectsOperatedOnCount = null, string objectFailedCount = null, string objectsSucceededCount = null, string runStatusError = null, RunStatusEnum? runStatusEnum = null, string summaryReportPath = null, ResourceIdentifier taskId = null, string taskVersion = null, RunResult? runResult = null)
        {
            return new StorageTaskReportProperties(taskAssignmentId, storageAccountId, startTime, finishTime, objectsTargetedCount, objectsOperatedOnCount, objectFailedCount, objectsSucceededCount, runStatusError, runStatusEnum, summaryReportPath, taskId, taskVersion, runResult);
        }

        /// <summary> Initializes a new instance of StorageTaskPreviewBlobProperties. </summary>
        /// <param name="name"> property for the container name. </param>
        /// <param name="properties"> properties key value pairs to be tested for a match against the provided condition. </param>
        /// <param name="metadata"> metadata key value pairs to be tested for a match against the provided condition. </param>
        /// <param name="tags"> tags key value pairs to be tested for a match against the provided condition. </param>
        /// <param name="matchedBlock"> Represents the condition block name that matched blob properties. </param>
        /// <returns> A new <see cref="Models.StorageTaskPreviewBlobProperties"/> instance for mocking. </returns>
        public static StorageTaskPreviewBlobProperties StorageTaskPreviewBlobProperties(string name = null, IEnumerable<StorageTaskPreviewKeyValueProperties> properties = null, IEnumerable<StorageTaskPreviewKeyValueProperties> metadata = null, IEnumerable<StorageTaskPreviewKeyValueProperties> tags = null, MatchedBlockName? matchedBlock = null)
        {
            properties ??= new List<StorageTaskPreviewKeyValueProperties>();
            metadata ??= new List<StorageTaskPreviewKeyValueProperties>();
            tags ??= new List<StorageTaskPreviewKeyValueProperties>();

            return new StorageTaskPreviewBlobProperties(name, properties?.ToList(), metadata?.ToList(), tags?.ToList(), matchedBlock);
        }
    }
}
