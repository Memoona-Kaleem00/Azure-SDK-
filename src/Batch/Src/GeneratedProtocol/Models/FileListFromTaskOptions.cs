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
    /// Additional parameters for the File_ListFromTask operation.
    /// </summary>
    public partial class FileListFromTaskOptions
    {
        /// <summary>
        /// Initializes a new instance of the FileListFromTaskOptions class.
        /// </summary>
        public FileListFromTaskOptions() { }

        /// <summary>
        /// Initializes a new instance of the FileListFromTaskOptions class.
        /// </summary>
        public FileListFromTaskOptions(string filter = default(string), int? maxResults = default(int?), int? timeout = default(int?), string clientRequestId = default(string), bool? returnClientRequestId = default(bool?), DateTime? ocpDate = default(DateTime?))
        {
            Filter = filter;
            MaxResults = maxResults;
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
        }

        /// <summary>
        /// Gets or sets an OData $filter clause.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to return in the response.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Gets or sets the maximum time that the server can spend processing
        /// the request, in seconds. The default is 30 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the caller-generated request identity, in the form of
        /// a GUID with no decoration such as curly braces, e.g.
        /// 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets whether the server should return the
        /// client-request-id identifier in the response.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public bool? ReturnClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the time the request was issued. If not specified,
        /// this header will be automatically populated with the current
        /// system clock time.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "")]
        public DateTime? OcpDate { get; set; }

    }
}
