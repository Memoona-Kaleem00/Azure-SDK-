// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> Error details. </summary>
    internal partial class ErrorDetails
    {
        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        internal ErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        /// <param name="error"> Error details. </param>
        internal ErrorDetails(ErrorDetailsInternal error)
        {
            Error = error;
        }

        /// <summary> Error details. </summary>
        public ErrorDetailsInternal Error { get; }
    }
}
