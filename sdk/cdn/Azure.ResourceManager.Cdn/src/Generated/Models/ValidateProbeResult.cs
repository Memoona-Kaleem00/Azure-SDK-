// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of the validate probe API. </summary>
    public partial class ValidateProbeResult
    {
        /// <summary> Initializes a new instance of <see cref="ValidateProbeResult"/>. </summary>
        internal ValidateProbeResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ValidateProbeResult"/>. </summary>
        /// <param name="isValid"> Indicates whether the probe URL is accepted or not. </param>
        /// <param name="errorCode"> Specifies the error code when the probe url is not accepted. </param>
        /// <param name="message"> The detailed error message describing why the probe URL is not accepted. </param>
        internal ValidateProbeResult(bool? isValid, string errorCode, string message)
        {
            IsValid = isValid;
            ErrorCode = errorCode;
            Message = message;
        }

        /// <summary> Indicates whether the probe URL is accepted or not. </summary>
        public bool? IsValid { get; }
        /// <summary> Specifies the error code when the probe url is not accepted. </summary>
        public string ErrorCode { get; }
        /// <summary> The detailed error message describing why the probe URL is not accepted. </summary>
        public string Message { get; }
    }
}
