// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> JIT approver definition. </summary>
    public partial class JitApproverDefinition
    {
        /// <summary> Initializes a new instance of JitApproverDefinition. </summary>
        /// <param name="id"> The approver service principal Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public JitApproverDefinition(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of JitApproverDefinition. </summary>
        /// <param name="id"> The approver service principal Id. </param>
        /// <param name="jitApproverType"> The approver type. </param>
        /// <param name="displayName"> The approver display name. </param>
        internal JitApproverDefinition(string id, JitApproverType? jitApproverType, string displayName)
        {
            Id = id;
            JitApproverType = jitApproverType;
            DisplayName = displayName;
        }

        /// <summary> The approver service principal Id. </summary>
        public string Id { get; set; }
        /// <summary> The approver type. </summary>
        public JitApproverType? JitApproverType { get; set; }
        /// <summary> The approver display name. </summary>
        public string DisplayName { get; set; }
    }
}
