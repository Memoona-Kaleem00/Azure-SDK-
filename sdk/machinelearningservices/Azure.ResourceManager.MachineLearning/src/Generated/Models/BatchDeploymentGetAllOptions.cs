// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A class representing the optional parameters in GetAll method. </summary>
    public partial class BatchDeploymentGetAllOptions
    {
        /// <summary> Initializes a new instance of BatchDeploymentGetAllOptions. </summary>
        public BatchDeploymentGetAllOptions()
        {
        }

        /// <summary> Ordering of list. </summary>
        public string OrderBy { get; set; }
        /// <summary> Top of list. </summary>
        public int? Top { get; set; }
        /// <summary> Continuation token for pagination. </summary>
        public string Skip { get; set; }
    }
}
