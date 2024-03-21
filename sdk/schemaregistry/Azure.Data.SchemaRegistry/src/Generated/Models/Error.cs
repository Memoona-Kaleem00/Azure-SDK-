// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> An error response returned from Azure Schema Registry service. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of <see cref="Error"/>. </summary>
        /// <param name="errorValue"> Error response returned from Azure Schema Registry service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorValue"/> is null. </exception>
        internal Error(ErrorDetail errorValue)
        {
            Argument.AssertNotNull(errorValue, nameof(errorValue));

            ErrorValue = errorValue;
        }

        /// <summary> Error response returned from Azure Schema Registry service. </summary>
        public ErrorDetail ErrorValue { get; }
    }
}
