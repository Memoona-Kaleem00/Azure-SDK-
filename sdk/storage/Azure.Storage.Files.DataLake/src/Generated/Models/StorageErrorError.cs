// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The service error response object. </summary>
    internal partial class StorageErrorError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageErrorError"/>. </summary>
        internal StorageErrorError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageErrorError"/>. </summary>
        /// <param name="code"> The service error code. </param>
        /// <param name="message"> The service error message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageErrorError(string code, string message, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> The service error code. </summary>
        public string Code { get; }
        /// <summary> The service error message. </summary>
        public string Message { get; }
    }
}
