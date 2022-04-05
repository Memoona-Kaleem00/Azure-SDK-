// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> Error details. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="errorValue"> Error details. </param>
        internal Error(ErrorDetailsInternal errorValue)
        {
            ErrorValue = errorValue;
        }

        /// <summary> Error details. </summary>
        public ErrorDetailsInternal ErrorValue { get; }
    }
}
