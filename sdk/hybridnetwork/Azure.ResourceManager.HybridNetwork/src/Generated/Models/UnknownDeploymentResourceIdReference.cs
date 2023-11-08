// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownDeploymentResourceIdReference. </summary>
    internal partial class UnknownDeploymentResourceIdReference : DeploymentResourceIdReference
    {
        /// <summary> Initializes a new instance of UnknownDeploymentResourceIdReference. </summary>
        /// <param name="idType"> The resource reference arm id type. </param>
        internal UnknownDeploymentResourceIdReference(IdType idType) : base(idType)
        {
            IdType = idType;
        }
    }
}
