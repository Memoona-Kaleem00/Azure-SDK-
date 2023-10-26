// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Unknown version of ScoringFunction. </summary>
    internal partial class UnknownScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of UnknownScoringFunction. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to "Linear". </param>
        internal UnknownScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation) : base(type, fieldName, boost, interpolation)
        {
            Type = type ?? "Unknown";
        }
    }
}
