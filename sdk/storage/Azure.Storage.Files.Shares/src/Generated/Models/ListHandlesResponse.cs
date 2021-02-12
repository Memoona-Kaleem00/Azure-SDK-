// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> An enumeration of handles. </summary>
    internal partial class ListHandlesResponse
    {
        /// <summary> Initializes a new instance of ListHandlesResponse. </summary>
        /// <param name="nextMarker"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextMarker"/> is null. </exception>
        internal ListHandlesResponse(string nextMarker)
        {
            if (nextMarker == null)
            {
                throw new ArgumentNullException(nameof(nextMarker));
            }

            HandleList = new ChangeTrackingList<ShareFileHandle>();
            NextMarker = nextMarker;
        }

        /// <summary> Initializes a new instance of ListHandlesResponse. </summary>
        /// <param name="handleList"> . </param>
        /// <param name="nextMarker"> . </param>
        internal ListHandlesResponse(IReadOnlyList<ShareFileHandle> handleList, string nextMarker)
        {
            HandleList = handleList;
            NextMarker = nextMarker;
        }

        public IReadOnlyList<ShareFileHandle> HandleList { get; }
        public string NextMarker { get; }
    }
}
