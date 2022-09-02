// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Mount target properties. </summary>
    public partial class NetAppVolumeMountTarget
    {
        /// <summary> Initializes a new instance of NetAppVolumeMountTarget. </summary>
        /// <param name="fileSystemId"> UUID v4 used to identify the MountTarget. </param>
        internal NetAppVolumeMountTarget(Guid fileSystemId)
        {
            FileSystemId = fileSystemId;
        }

        /// <summary> Initializes a new instance of NetAppVolumeMountTarget. </summary>
        /// <param name="mountTargetId"> UUID v4 used to identify the MountTarget. </param>
        /// <param name="fileSystemId"> UUID v4 used to identify the MountTarget. </param>
        /// <param name="ipAddress"> The mount target&apos;s IPv4 address. </param>
        /// <param name="smbServerFqdn"> The SMB server&apos;s Fully Qualified Domain Name, FQDN. </param>
        internal NetAppVolumeMountTarget(Guid? mountTargetId, Guid fileSystemId, IPAddress ipAddress, string smbServerFqdn)
        {
            MountTargetId = mountTargetId;
            FileSystemId = fileSystemId;
            IPAddress = ipAddress;
            SmbServerFqdn = smbServerFqdn;
        }

        /// <summary> UUID v4 used to identify the MountTarget. </summary>
        public Guid? MountTargetId { get; }
        /// <summary> UUID v4 used to identify the MountTarget. </summary>
        public Guid FileSystemId { get; }
        /// <summary> The mount target&apos;s IPv4 address. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The SMB server&apos;s Fully Qualified Domain Name, FQDN. </summary>
        public string SmbServerFqdn { get; }
    }
}
