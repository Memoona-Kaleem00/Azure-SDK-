// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about a server Blob Auditing policy operation
    /// result.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlobAuditingOperationResult : SqlTypedSubResource
    {
        /// <summary>
        /// Initializes a new instance of the BlobAuditingOperationResult
        /// class.
        /// </summary>
        public BlobAuditingOperationResult() { }

        /// <summary>
        /// Initializes a new instance of the BlobAuditingOperationResult
        /// class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="type">Resource type</param>
        /// <param name="operationId">Specifies the Blob Auditing operation
        /// ID</param>
        /// <param name="state">Specifies the state of the Blob Auditing
        /// operation.</param>
        /// <param name="startTime">Specifies the start time of the Blob
        /// Auditing operation.</param>
        public BlobAuditingOperationResult(string name = default(string), string id = default(string), string type = default(string), string operationId = default(string), string state = default(string), string startTime = default(string))
            : base(name, id, type)
        {
            OperationId = operationId;
            State = state;
            StartTime = startTime;
        }

        /// <summary>
        /// Gets or sets specifies the Blob Auditing operation ID
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets specifies the state of the Blob Auditing operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets specifies the start time of the Blob Auditing
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public string StartTime { get; set; }

    }
}
