// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownAssetReferenceBase. </summary>
    internal partial class UnknownAssetReferenceBase : AssetReferenceBase
    {
        /// <summary> Initializes a new instance of UnknownAssetReferenceBase. </summary>
        /// <param name="referenceType"> [Required] Specifies the type of asset reference. </param>
        internal UnknownAssetReferenceBase(ReferenceType referenceType) : base(referenceType)
        {
            ReferenceType = referenceType;
        }
    }
}
