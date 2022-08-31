// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The expansion result values. </summary>
    public partial class BookmarkExpandResponseValue
    {
        /// <summary> Initializes a new instance of BookmarkExpandResponseValue. </summary>
        internal BookmarkExpandResponseValue()
        {
            Entities = new ChangeTrackingList<EntityData>();
            Edges = new ChangeTrackingList<ConnectedEntity>();
        }

        /// <summary> Initializes a new instance of BookmarkExpandResponseValue. </summary>
        /// <param name="entities">
        /// Array of the expansion result entities.
        /// Please note <see cref="EntityData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccountEntity"/>, <see cref="AzureResourceEntity"/>, <see cref="HuntingBookmark"/>, <see cref="CloudApplicationEntity"/>, <see cref="DnsEntity"/>, <see cref="FileEntity"/>, <see cref="FileHashEntity"/>, <see cref="HostEntity"/>, <see cref="IoTDeviceEntity"/>, <see cref="IPEntity"/>, <see cref="MailClusterEntity"/>, <see cref="MailMessageEntity"/>, <see cref="MailboxEntity"/>, <see cref="MalwareEntity"/>, <see cref="NicEntity"/>, <see cref="ProcessEntity"/>, <see cref="RegistryKeyEntity"/>, <see cref="RegistryValueEntity"/>, <see cref="SecurityAlert"/>, <see cref="SecurityGroupEntity"/>, <see cref="SubmissionMailEntity"/> and <see cref="UrlEntity"/>.
        /// </param>
        /// <param name="edges"> Array of expansion result connected entities. </param>
        internal BookmarkExpandResponseValue(IReadOnlyList<EntityData> entities, IReadOnlyList<ConnectedEntity> edges)
        {
            Entities = entities;
            Edges = edges;
        }

        /// <summary>
        /// Array of the expansion result entities.
        /// Please note <see cref="EntityData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccountEntity"/>, <see cref="AzureResourceEntity"/>, <see cref="HuntingBookmark"/>, <see cref="CloudApplicationEntity"/>, <see cref="DnsEntity"/>, <see cref="FileEntity"/>, <see cref="FileHashEntity"/>, <see cref="HostEntity"/>, <see cref="IoTDeviceEntity"/>, <see cref="IPEntity"/>, <see cref="MailClusterEntity"/>, <see cref="MailMessageEntity"/>, <see cref="MailboxEntity"/>, <see cref="MalwareEntity"/>, <see cref="NicEntity"/>, <see cref="ProcessEntity"/>, <see cref="RegistryKeyEntity"/>, <see cref="RegistryValueEntity"/>, <see cref="SecurityAlert"/>, <see cref="SecurityGroupEntity"/>, <see cref="SubmissionMailEntity"/> and <see cref="UrlEntity"/>.
        /// </summary>
        public IReadOnlyList<EntityData> Entities { get; }
        /// <summary> Array of expansion result connected entities. </summary>
        public IReadOnlyList<ConnectedEntity> Edges { get; }
    }
}
