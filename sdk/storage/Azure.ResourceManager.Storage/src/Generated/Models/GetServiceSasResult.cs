// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The List service SAS credentials operation response. </summary>
    public partial class GetServiceSasResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GetServiceSasResult"/>. </summary>
        internal GetServiceSasResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GetServiceSasResult"/>. </summary>
        /// <param name="serviceSasToken"> List service SAS credentials of specific resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetServiceSasResult(string serviceSasToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceSasToken = serviceSasToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List service SAS credentials of specific resource. </summary>
        public string ServiceSasToken { get; }
    }
}
