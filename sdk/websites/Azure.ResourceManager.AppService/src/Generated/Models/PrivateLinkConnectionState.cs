// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The state of a private link connection. </summary>
    public partial class PrivateLinkConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionState"/>. </summary>
        public PrivateLinkConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionState"/>. </summary>
        /// <param name="status"> Status of a private link connection. </param>
        /// <param name="description"> Description of a private link connection. </param>
        /// <param name="actionsRequired"> ActionsRequired for a private link connection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkConnectionState(string status, string description, string actionsRequired, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _rawData = rawData;
        }

        /// <summary> Status of a private link connection. </summary>
        public string Status { get; set; }
        /// <summary> Description of a private link connection. </summary>
        public string Description { get; set; }
        /// <summary> ActionsRequired for a private link connection. </summary>
        public string ActionsRequired { get; set; }
    }
}
