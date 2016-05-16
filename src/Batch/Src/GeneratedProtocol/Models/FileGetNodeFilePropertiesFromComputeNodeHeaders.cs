// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines headers for GetNodeFilePropertiesFromComputeNode operation.
    /// </summary>
    public partial class FileGetNodeFilePropertiesFromComputeNodeHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FileGetNodeFilePropertiesFromComputeNodeHeaders class.
        /// </summary>
        public FileGetNodeFilePropertiesFromComputeNodeHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FileGetNodeFilePropertiesFromComputeNodeHeaders class.
        /// </summary>
        public FileGetNodeFilePropertiesFromComputeNodeHeaders(string clientRequestId = default(string), string requestId = default(string), string eTag = default(string), DateTime? lastModified = default(DateTime?), DateTime? ocpCreationTime = default(DateTime?), bool? ocpBatchFileIsdirectory = default(bool?), string ocpBatchFileUrl = default(string), string ocpBatchFileMode = default(string), string contentType = default(string), long? contentLength = default(long?))
        {
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            LastModified = lastModified;
            OcpCreationTime = ocpCreationTime;
            OcpBatchFileIsdirectory = ocpBatchFileIsdirectory;
            OcpBatchFileUrl = ocpBatchFileUrl;
            OcpBatchFileMode = ocpBatchFileMode;
            ContentType = contentType;
            ContentLength = contentLength;
        }

        /// <summary>
        /// Gets or sets the ClientRequestId provided by the client during the
        /// request, if present and requested to be returned.
        /// </summary>
        [JsonProperty(PropertyName = "client-request-id")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the value that uniquely identifies a request.
        /// </summary>
        [JsonProperty(PropertyName = "request-id")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the content of the ETag HTTP response header.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the content of the Last-Modified HTTP response header.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "Last-Modified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the file creation time.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "ocp-creation-time")]
        public DateTime? OcpCreationTime { get; set; }

        /// <summary>
        /// Gets or sets whether the object represents a directory.
        /// </summary>
        [JsonProperty(PropertyName = "ocp-batch-file-isdirectory")]
        public bool? OcpBatchFileIsdirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL of the file.
        /// </summary>
        [JsonProperty(PropertyName = "ocp-batch-file-url")]
        public string OcpBatchFileUrl { get; set; }

        /// <summary>
        /// Gets or sets the file mode attribute in octal format.
        /// </summary>
        [JsonProperty(PropertyName = "ocp-batch-file-mode")]
        public string OcpBatchFileMode { get; set; }

        /// <summary>
        /// Gets or sets the content type of the file.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Length")]
        public long? ContentLength { get; set; }

    }
}
