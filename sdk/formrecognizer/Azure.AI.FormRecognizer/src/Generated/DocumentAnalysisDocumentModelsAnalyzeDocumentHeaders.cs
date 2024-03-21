// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    internal partial class DocumentAnalysisDocumentModelsAnalyzeDocumentHeaders
    {
        private readonly Response _response;
        public DocumentAnalysisDocumentModelsAnalyzeDocumentHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL used to track the progress and obtain the result of the analyze operation. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
