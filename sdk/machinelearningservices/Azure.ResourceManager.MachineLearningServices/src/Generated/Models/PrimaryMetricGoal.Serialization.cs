// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal static class PrimaryMetricGoalExtensions
    {
        public static string ToSerialString(this PrimaryMetricGoal value) => value switch
        {
            PrimaryMetricGoal.Minimize => "Minimize",
            PrimaryMetricGoal.Maximize => "Maximize",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PrimaryMetricGoal value.")
        };

        public static PrimaryMetricGoal ToPrimaryMetricGoal(this string value)
        {
            if (string.Equals(value, "Minimize", StringComparison.InvariantCultureIgnoreCase)) return PrimaryMetricGoal.Minimize;
            if (string.Equals(value, "Maximize", StringComparison.InvariantCultureIgnoreCase)) return PrimaryMetricGoal.Maximize;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PrimaryMetricGoal value.");
        }
    }
}
