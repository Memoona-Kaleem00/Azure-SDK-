// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> The ErrorInformation. </summary>
    public partial class FormRecognizerError
    {
        /// <summary> Initializes a new instance of FormRecognizerError. </summary>
        /// <param name="code"> . </param>
        /// <param name="message"> . </param>
        internal FormRecognizerError(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }
    }
}
