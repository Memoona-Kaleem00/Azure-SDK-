// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Data Type for App Seen. </summary>
    public partial class AppSeenInfoList
    {
        /// <summary> Initializes a new instance of <see cref="AppSeenInfoList"/>. </summary>
        /// <param name="count"> number of rows. </param>
        /// <param name="appSeenList"> array of appSeen. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSeenList"/> is null. </exception>
        internal AppSeenInfoList(int count, IEnumerable<AppSeenInfo> appSeenList)
        {
            Argument.AssertNotNull(appSeenList, nameof(appSeenList));

            Count = count;
            AppSeenList = appSeenList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AppSeenInfoList"/>. </summary>
        /// <param name="count"> number of rows. </param>
        /// <param name="appSeenList"> array of appSeen. </param>
        internal AppSeenInfoList(int count, IReadOnlyList<AppSeenInfo> appSeenList)
        {
            Count = count;
            AppSeenList = appSeenList;
        }

        /// <summary> number of rows. </summary>
        public int Count { get; }
        /// <summary> array of appSeen. </summary>
        public IReadOnlyList<AppSeenInfo> AppSeenList { get; }
    }
}
