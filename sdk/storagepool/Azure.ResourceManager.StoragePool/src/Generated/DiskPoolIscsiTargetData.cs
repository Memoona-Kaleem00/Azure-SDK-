// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary>
    /// A class representing the DiskPoolIscsiTarget data model.
    /// Response for iSCSI Target requests.
    /// </summary>
    public partial class DiskPoolIscsiTargetData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetData"/>. </summary>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="status"> Operational status of the iSCSI Target. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetIqn"/> is null. </exception>
        public DiskPoolIscsiTargetData(DiskPoolIscsiTargetAclMode aclMode, string targetIqn, DiskPoolIscsiTargetProvisioningState provisioningState, StoragePoolOperationalStatus status)
        {
            Argument.AssertNotNull(targetIqn, nameof(targetIqn));

            ManagedByExtended = new ChangeTrackingList<string>();
            AclMode = aclMode;
            StaticAcls = new ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl>();
            Luns = new ChangeTrackingList<ManagedDiskIscsiLun>();
            TargetIqn = targetIqn;
            ProvisioningState = provisioningState;
            Status = status;
            Endpoints = new ChangeTrackingList<string>();
            Sessions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="status"> Operational status of the iSCSI Target. </param>
        /// <param name="endpoints"> List of private IPv4 addresses to connect to the iSCSI Target. </param>
        /// <param name="port"> The port used by iSCSI Target portal group. </param>
        /// <param name="sessions"> List of identifiers for active sessions on the iSCSI target. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskPoolIscsiTargetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedBy, IReadOnlyList<string> managedByExtended, DiskPoolIscsiTargetAclMode aclMode, IList<DiskPoolIscsiTargetPortalGroupAcl> staticAcls, IList<ManagedDiskIscsiLun> luns, string targetIqn, DiskPoolIscsiTargetProvisioningState provisioningState, StoragePoolOperationalStatus status, IList<string> endpoints, int? port, IReadOnlyList<string> sessions, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            AclMode = aclMode;
            StaticAcls = staticAcls;
            Luns = luns;
            TargetIqn = targetIqn;
            ProvisioningState = provisioningState;
            Status = status;
            Endpoints = endpoints;
            Port = port;
            Sessions = sessions;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetData"/> for deserialization. </summary>
        internal DiskPoolIscsiTargetData()
        {
        }

        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IReadOnlyList<string> ManagedByExtended { get; }
        /// <summary> Mode for Target connectivity. </summary>
        public DiskPoolIscsiTargetAclMode AclMode { get; set; }
        /// <summary> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </summary>
        public IList<DiskPoolIscsiTargetPortalGroupAcl> StaticAcls { get; }
        /// <summary> List of LUNs to be exposed through iSCSI Target. </summary>
        public IList<ManagedDiskIscsiLun> Luns { get; }
        /// <summary> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </summary>
        public string TargetIqn { get; set; }
        /// <summary> State of the operation on the resource. </summary>
        public DiskPoolIscsiTargetProvisioningState ProvisioningState { get; }
        /// <summary> Operational status of the iSCSI Target. </summary>
        public StoragePoolOperationalStatus Status { get; set; }
        /// <summary> List of private IPv4 addresses to connect to the iSCSI Target. </summary>
        public IList<string> Endpoints { get; }
        /// <summary> The port used by iSCSI Target portal group. </summary>
        public int? Port { get; set; }
        /// <summary> List of identifiers for active sessions on the iSCSI target. </summary>
        public IReadOnlyList<string> Sessions { get; }
    }
}
