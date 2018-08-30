// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of managed integration runtime operation result.
    /// </summary>
    public partial class ManagedIntegrationRuntimeOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedIntegrationRuntimeOperationResult class.
        /// </summary>
        public ManagedIntegrationRuntimeOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedIntegrationRuntimeOperationResult class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="type">The operation type. Could be start or
        /// stop.</param>
        /// <param name="startTime">The start time of the operation.</param>
        /// <param name="result">The operation result.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="parameters">Managed integration runtime error
        /// parameters.</param>
        /// <param name="activityId">The activity id for the operation
        /// request.</param>
        public ManagedIntegrationRuntimeOperationResult(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string type = default(string), System.DateTime? startTime = default(System.DateTime?), string result = default(string), string errorCode = default(string), IList<string> parameters = default(IList<string>), string activityId = default(string))
        {
            AdditionalProperties = additionalProperties;
            Type = type;
            StartTime = startTime;
            Result = result;
            ErrorCode = errorCode;
            Parameters = parameters;
            ActivityId = activityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets the operation type. Could be start or stop.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the start time of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the operation result.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; private set; }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; private set; }

        /// <summary>
        /// Gets managed integration runtime error parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<string> Parameters { get; private set; }

        /// <summary>
        /// Gets the activity id for the operation request.
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; private set; }

    }
}
