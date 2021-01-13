// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The AssetReferenceBase. </summary>
    public partial class AssetReferenceBase
    {
        /// <summary> Initializes a new instance of AssetReferenceBase. </summary>
        public AssetReferenceBase()
        {
        }

        /// <summary> Initializes a new instance of AssetReferenceBase. </summary>
        /// <param name="referenceType"> Specifies the type of asset reference. </param>
        internal AssetReferenceBase(ReferenceType referenceType)
        {
            ReferenceType = referenceType;
        }

        /// <summary> Specifies the type of asset reference. </summary>
        internal ReferenceType ReferenceType { get; set; }
    }
}
