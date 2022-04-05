// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> the type of action that should occur when the scale rule fires. </summary>
    public enum ScaleType
    {
        /// <summary> ChangeCount. </summary>
        ChangeCount,
        /// <summary> PercentChangeCount. </summary>
        PercentChangeCount,
        /// <summary> ExactCount. </summary>
        ExactCount,
        /// <summary> ServiceAllowedNextValue. </summary>
        ServiceAllowedNextValue
    }
}
