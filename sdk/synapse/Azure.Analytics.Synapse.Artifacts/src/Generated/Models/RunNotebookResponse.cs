// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Run notebook response. </summary>
    public partial class RunNotebookResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RunNotebookResponse"/>. </summary>
        internal RunNotebookResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RunNotebookResponse"/>. </summary>
        /// <param name="message"> Response message. </param>
        /// <param name="result"> Result of run notebook. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RunNotebookResponse(string message, RunNotebookResult result, Dictionary<string, BinaryData> rawData)
        {
            Message = message;
            Result = result;
            _rawData = rawData;
        }

        /// <summary> Response message. </summary>
        public string Message { get; }
        /// <summary> Result of run notebook. </summary>
        public RunNotebookResult Result { get; }
    }
}
