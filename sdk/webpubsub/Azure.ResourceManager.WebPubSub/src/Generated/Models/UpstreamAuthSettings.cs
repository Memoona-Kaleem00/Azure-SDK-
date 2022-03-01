// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Upstream auth settings. </summary>
    public partial class UpstreamAuthSettings
    {
        /// <summary> Initializes a new instance of UpstreamAuthSettings. </summary>
        public UpstreamAuthSettings()
        {
        }

        /// <summary> Initializes a new instance of UpstreamAuthSettings. </summary>
        /// <param name="type"> Gets or sets the type of auth. None or ManagedIdentity is supported now. </param>
        /// <param name="managedIdentity"> Gets or sets the managed identity settings. It&apos;s required if the auth type is set to ManagedIdentity. </param>
        internal UpstreamAuthSettings(UpstreamAuthType? type, ManagedIdentitySettings managedIdentity)
        {
            Type = type;
            ManagedIdentity = managedIdentity;
        }

        /// <summary> Gets or sets the type of auth. None or ManagedIdentity is supported now. </summary>
        public UpstreamAuthType? Type { get; set; }
        /// <summary> Gets or sets the managed identity settings. It&apos;s required if the auth type is set to ManagedIdentity. </summary>
        internal ManagedIdentitySettings ManagedIdentity { get; set; }
        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        public string ManagedIdentityResource
        {
            get => ManagedIdentity is null ? default : ManagedIdentity.Resource;
            set
            {
                if (ManagedIdentity is null)
                    ManagedIdentity = new ManagedIdentitySettings();
                ManagedIdentity.Resource = value;
            }
        }
    }
}
