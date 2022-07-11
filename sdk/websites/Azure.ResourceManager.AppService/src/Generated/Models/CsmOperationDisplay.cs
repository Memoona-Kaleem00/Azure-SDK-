// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Meta data about operation used for display in portal.
    /// Serialized Name: CsmOperationDisplay
    /// </summary>
    public partial class CsmOperationDisplay
    {
        /// <summary> Initializes a new instance of CsmOperationDisplay. </summary>
        internal CsmOperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of CsmOperationDisplay. </summary>
        /// <param name="provider"> Serialized Name: CsmOperationDisplay.provider. </param>
        /// <param name="resource"> Serialized Name: CsmOperationDisplay.resource. </param>
        /// <param name="operation"> Serialized Name: CsmOperationDisplay.operation. </param>
        /// <param name="description"> Serialized Name: CsmOperationDisplay.description. </param>
        internal CsmOperationDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> Serialized Name: CsmOperationDisplay.provider. </summary>
        public string Provider { get; }
        /// <summary> Serialized Name: CsmOperationDisplay.resource. </summary>
        public string Resource { get; }
        /// <summary> Serialized Name: CsmOperationDisplay.operation. </summary>
        public string Operation { get; }
        /// <summary> Serialized Name: CsmOperationDisplay.description. </summary>
        public string Description { get; }
    }
}
