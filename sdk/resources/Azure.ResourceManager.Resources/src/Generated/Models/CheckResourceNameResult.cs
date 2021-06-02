// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources
{
    /// <summary> Resource Name valid if not a reserved word, does not contain a reserved word and does not start with a reserved word. </summary>
    internal partial class CheckResourceNameResult
    {
        /// <summary> Initializes a new instance of CheckResourceNameResult. </summary>
        internal CheckResourceNameResult()
        {
        }

        /// <summary> Name of Resource. </summary>
        public string Name { get; }
        /// <summary> Type of Resource. </summary>
        public string Type { get; }
        /// <summary> Is the resource name Allowed or Reserved. </summary>
        public ResourceNameStatus? Status { get; }
    }
}
