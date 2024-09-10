// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a task step. </summary>
    public partial class ContainerRegistryFileTaskStep : ContainerRegistryTaskStepProperties
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryFileTaskStep"/>. </summary>
        /// <param name="taskFilePath"> The task template/definition file path relative to the source context. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskFilePath"/> is null. </exception>
        public ContainerRegistryFileTaskStep(string taskFilePath)
        {
            Argument.AssertNotNull(taskFilePath, nameof(taskFilePath));

            TaskFilePath = taskFilePath;
            Values = new ChangeTrackingList<ContainerRegistryTaskOverridableValue>();
            ContainerRegistryTaskStepType = ContainerRegistryTaskStepType.FileTask;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryFileTaskStep"/>. </summary>
        /// <param name="containerRegistryTaskStepType"> The type of the step. </param>
        /// <param name="baseImageDependencies"> List of base image dependencies for a step. </param>
        /// <param name="contextPath"> The URL(absolute or relative) of the source context for the task step. </param>
        /// <param name="contextAccessToken"> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="taskFilePath"> The task template/definition file path relative to the source context. </param>
        /// <param name="valuesFilePath"> The task values/parameters file path relative to the source context. </param>
        /// <param name="values"> The collection of overridable values that can be passed when running a task. </param>
        internal ContainerRegistryFileTaskStep(ContainerRegistryTaskStepType containerRegistryTaskStepType, IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies, string contextPath, string contextAccessToken, IDictionary<string, BinaryData> serializedAdditionalRawData, string taskFilePath, string valuesFilePath, IList<ContainerRegistryTaskOverridableValue> values) : base(containerRegistryTaskStepType, baseImageDependencies, contextPath, contextAccessToken, serializedAdditionalRawData)
        {
            TaskFilePath = taskFilePath;
            ValuesFilePath = valuesFilePath;
            Values = values;
            ContainerRegistryTaskStepType = containerRegistryTaskStepType;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryFileTaskStep"/> for deserialization. </summary>
        internal ContainerRegistryFileTaskStep()
        {
        }

        /// <summary> The task template/definition file path relative to the source context. </summary>
        [WirePath("taskFilePath")]
        public string TaskFilePath { get; set; }
        /// <summary> The task values/parameters file path relative to the source context. </summary>
        [WirePath("valuesFilePath")]
        public string ValuesFilePath { get; set; }
        /// <summary> The collection of overridable values that can be passed when running a task. </summary>
        [WirePath("values")]
        public IList<ContainerRegistryTaskOverridableValue> Values { get; }
    }
}
