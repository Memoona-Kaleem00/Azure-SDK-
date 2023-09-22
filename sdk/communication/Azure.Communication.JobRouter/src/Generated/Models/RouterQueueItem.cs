// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Paged instance of RouterQueue. </summary>
    public partial class RouterQueueItem
    {
        /// <summary> Initializes a new instance of RouterQueueItem. </summary>
        internal RouterQueueItem()
        {
        }

        /// <summary> Initializes a new instance of RouterQueueItem. </summary>
        /// <param name="queue"> A queue that can contain jobs to be routed. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        internal RouterQueueItem(RouterQueue queue, string etag)
        {
            Queue = queue;
            _etag = etag;
        }

        /// <summary> A queue that can contain jobs to be routed. </summary>
        public RouterQueue Queue { get; }
    }
}
