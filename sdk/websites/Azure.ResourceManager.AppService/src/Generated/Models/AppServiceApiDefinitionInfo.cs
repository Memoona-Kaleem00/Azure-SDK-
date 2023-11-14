// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Information about the formal API definition for the app. </summary>
    internal partial class AppServiceApiDefinitionInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceApiDefinitionInfo"/>. </summary>
        public AppServiceApiDefinitionInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceApiDefinitionInfo"/>. </summary>
        /// <param name="uri"> The URL of the API definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceApiDefinitionInfo(Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URL of the API definition. </summary>
        public Uri Uri { get; set; }
    }
}
