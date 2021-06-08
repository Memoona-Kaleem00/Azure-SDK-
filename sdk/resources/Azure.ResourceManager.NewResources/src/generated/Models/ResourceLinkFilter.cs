// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Resource link filter. </summary>
    internal partial class ResourceLinkFilter
    {
        /// <summary> Initializes a new instance of ResourceLinkFilter. </summary>
        /// <param name="targetId"> The ID of the target resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetId"/> is null. </exception>
        internal ResourceLinkFilter(string targetId)
        {
            if (targetId == null)
            {
                throw new ArgumentNullException(nameof(targetId));
            }

            TargetId = targetId;
        }

        /// <summary> The ID of the target resource. </summary>
        public string TargetId { get; }
    }
}
