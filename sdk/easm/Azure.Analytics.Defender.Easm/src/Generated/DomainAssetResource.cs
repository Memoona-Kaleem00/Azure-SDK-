// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The DomainAssetResource. </summary>
    public partial class DomainAssetResource : AssetResource
    {
        /// <summary> Initializes a new instance of <see cref="DomainAssetResource"/>. </summary>
        /// <param name="asset"> asset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="asset"/> is null. </exception>
        internal DomainAssetResource(DomainAsset asset)
        {
            Argument.AssertNotNull(asset, nameof(asset));

            Kind = "domain";
            Asset = asset;
        }

        /// <summary> Initializes a new instance of <see cref="DomainAssetResource"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="id"> The system generated unique id for the resource. </param>
        /// <param name="name"> The caller provided unique name for the resource. </param>
        /// <param name="displayName"> The name that can be used for display purposes. </param>
        /// <param name="uuid"> Global UUID for the asset. </param>
        /// <param name="createdDate"> The date this asset was first added to this workspace. </param>
        /// <param name="updatedDate"> The date this asset was last updated for this workspace. </param>
        /// <param name="state"></param>
        /// <param name="externalId"> An optional customer provided identifier for this asset. </param>
        /// <param name="labels"> Customer labels assigned to this asset. </param>
        /// <param name="wildcard"> An indicator of whether this asset represents a wildcard rollup of assets on this domain. </param>
        /// <param name="discoGroupName"> The name of the DiscoGroup that brought added this asset to the workspace. </param>
        /// <param name="auditTrail"> The history of how this asset was pulled into the workspace through the discovery process. </param>
        /// <param name="reason"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="asset"> asset. </param>
        internal DomainAssetResource(string kind, string id, string name, string displayName, Guid? uuid, DateTimeOffset? createdDate, DateTimeOffset? updatedDate, AssetState? state, string externalId, IReadOnlyList<string> labels, bool? wildcard, string discoGroupName, IReadOnlyList<AuditTrailItem> auditTrail, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData, DomainAsset asset) : base(kind, id, name, displayName, uuid, createdDate, updatedDate, state, externalId, labels, wildcard, discoGroupName, auditTrail, reason, serializedAdditionalRawData)
        {
            Asset = asset;
        }

        /// <summary> Initializes a new instance of <see cref="DomainAssetResource"/> for deserialization. </summary>
        internal DomainAssetResource()
        {
        }

        /// <summary> asset. </summary>
        public DomainAsset Asset { get; }
    }
}
