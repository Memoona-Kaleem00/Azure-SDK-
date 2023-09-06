// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Function key info. </summary>
    public partial class WebAppKeyInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebAppKeyInfo"/>. </summary>
        public WebAppKeyInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppKeyInfo"/>. </summary>
        /// <param name="properties"> Properties of function key info. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppKeyInfo(WebAppKeyInfoProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Properties of function key info. </summary>
        public WebAppKeyInfoProperties Properties { get; set; }
    }
}
