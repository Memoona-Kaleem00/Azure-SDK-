// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A class representing the DeploymentScript data model. </summary>
    public partial class DeploymentScriptData : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of DeploymentScriptData. </summary>
        /// <param name="identity"> Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/> or <paramref name="location"/> is null. </exception>
        public DeploymentScriptData(ManagedServiceIdentity identity, string location)
        {
            if (identity == null)
            {
                throw new ArgumentNullException(nameof(identity));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Identity = identity;
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            Kind = new ScriptType("DeploymentScript");
        }

        /// <summary> Initializes a new instance of DeploymentScriptData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="identity"> Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="kind"> Type of the script. </param>
        /// <param name="systemData"> The system metadata related to this resource. </param>
        internal DeploymentScriptData(ResourceGroupResourceIdentifier id, string name, ResourceType type, ManagedServiceIdentity identity, string location, IDictionary<string, string> tags, ScriptType kind, SystemData systemData) : base(id, name, type)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Kind = kind;
            SystemData = systemData;
        }

        /// <summary> Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The location of the ACI and the storage account for the deployment script. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Type of the script. </summary>
        internal ScriptType Kind { get; set; }
        /// <summary> The system metadata related to this resource. </summary>
        public SystemData SystemData { get; }
    }
}
