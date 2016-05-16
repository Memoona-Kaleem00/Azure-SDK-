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
    /// Parameters for a ComputeNodeOperations.Reimage request.
    /// </summary>
    public partial class NodeReimageParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeReimageParameter class.
        /// </summary>
        public NodeReimageParameter() { }

        /// <summary>
        /// Initializes a new instance of the NodeReimageParameter class.
        /// </summary>
        public NodeReimageParameter(ComputeNodeReimageOption? nodeReimageOption = default(ComputeNodeReimageOption?))
        {
            NodeReimageOption = nodeReimageOption;
        }

        /// <summary>
        /// Gets or sets when to reimage the compute node and what to do with
        /// currently running tasks. The default value is requeue. Possible
        /// values include: 'requeue', 'terminate', 'taskcompletion',
        /// 'retaineddata'
        /// </summary>
        [JsonProperty(PropertyName = "nodeReimageOption")]
        public ComputeNodeReimageOption? NodeReimageOption { get; set; }

    }
}
