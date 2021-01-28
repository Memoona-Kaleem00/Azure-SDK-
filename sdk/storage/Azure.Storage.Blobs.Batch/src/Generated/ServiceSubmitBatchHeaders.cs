// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Storage.Blobs.Batch
{
    internal class ServiceSubmitBatchHeaders
    {
        private readonly Response _response;
        public ServiceSubmitBatchHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The media type of the body of the response. For batch requests, this is multipart/mixed; boundary=batchresponse_GUID. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
