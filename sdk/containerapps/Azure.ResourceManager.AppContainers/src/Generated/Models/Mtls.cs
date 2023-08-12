// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration properties for mutual TLS authentication. </summary>
    internal partial class Mtls
    {
        /// <summary> Initializes a new instance of Mtls. </summary>
        public Mtls()
        {
        }

        /// <summary> Initializes a new instance of Mtls. </summary>
        /// <param name="isMtlsEnabled"> Boolean indicating whether the mutual TLS authentication is enabled. </param>
        internal Mtls(bool? isMtlsEnabled)
        {
            IsMtlsEnabled = isMtlsEnabled;
        }

        /// <summary> Boolean indicating whether the mutual TLS authentication is enabled. </summary>
        public bool? IsMtlsEnabled { get; set; }
    }
}
