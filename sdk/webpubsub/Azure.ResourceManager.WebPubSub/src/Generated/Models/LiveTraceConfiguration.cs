// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Live trace configuration of a Microsoft.SignalRService resource. </summary>
    public partial class LiveTraceConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LiveTraceConfiguration"/>. </summary>
        /// <param name="enabled">
        /// Indicates whether or not enable live trace.
        /// When it's set to true, live trace client can connect to the service.
        /// Otherwise, live trace client can't connect to the service, so that you are unable to receive any log, no matter what you configure in "categories".
        /// Available values: true, false.
        /// Case insensitive.
        /// </param>
        /// <param name="categories"> Gets or sets the list of category configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveTraceConfiguration(string enabled, IList<LiveTraceCategory> categories, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            Categories = categories;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
