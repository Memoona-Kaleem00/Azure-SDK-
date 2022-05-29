// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A class representing the optional parameters in GetAll method. </summary>
    public partial class ComponentVersionGetAllOptions
    {
        /// <summary> Initializes a new instance of ComponentVersionGetAllOptions. </summary>
        public ComponentVersionGetAllOptions()
        {
        }

        /// <summary> Ordering of list. </summary>
        public string OrderBy { get; set; }
        /// <summary> Maximum number of records to return. </summary>
        public int? Top { get; set; }
        /// <summary> Continuation token for pagination. </summary>
        public string Skip { get; set; }
        /// <summary> View type for including/excluding (for example) archived entities. </summary>
        public ListViewType? ListViewType { get; set; }
    }
}
