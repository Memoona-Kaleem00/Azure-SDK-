// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The MoveRPAcrossTiersContent. </summary>
    public partial class MoveRPAcrossTiersContent
    {
        /// <summary> Initializes a new instance of MoveRPAcrossTiersContent. </summary>
        public MoveRPAcrossTiersContent()
        {
        }

        /// <summary> Gets the class type. </summary>
        public string ObjectType { get; set; }
        /// <summary> Source tier from where RP needs to be moved. </summary>
        public RecoveryPointTierType? SourceTierType { get; set; }
        /// <summary> Target tier where RP needs to be moved. </summary>
        public RecoveryPointTierType? TargetTierType { get; set; }
    }
}
