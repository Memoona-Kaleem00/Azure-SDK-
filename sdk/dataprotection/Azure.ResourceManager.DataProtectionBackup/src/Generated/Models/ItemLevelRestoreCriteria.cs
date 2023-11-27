// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Class to contain criteria for item level restore
    /// Please note <see cref="ItemLevelRestoreCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ItemPathBasedRestoreCriteria"/>, <see cref="KubernetesClusterRestoreCriteria"/>, <see cref="KubernetesPVRestoreCriteria"/>, <see cref="KubernetesStorageClassRestoreCriteria"/> and <see cref="RangeBasedItemLevelRestoreCriteria"/>.
    /// </summary>
    public abstract partial class ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of <see cref="ItemLevelRestoreCriteria"/>. </summary>
        protected ItemLevelRestoreCriteria()
        {
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
