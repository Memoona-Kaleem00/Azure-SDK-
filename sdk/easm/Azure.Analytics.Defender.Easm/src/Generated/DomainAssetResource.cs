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
        /// <param name="asset"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="asset"/> is null. </exception>
        internal DomainAssetResource(DomainAsset asset)
        {
            Argument.AssertNotNull(asset, nameof(asset));

            Kind = "domain";
            Asset = asset;
        }

        /// <summary> Initializes a new instance of <see cref="DomainAssetResource"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="uuid"></param>
        /// <param name="createdDate"></param>
        /// <param name="updatedDate"></param>
        /// <param name="state"></param>
        /// <param name="externalId"></param>
        /// <param name="labels"></param>
        /// <param name="wildcard"></param>
        /// <param name="discoGroupName"></param>
        /// <param name="auditTrail"></param>
        /// <param name="reason"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="asset"></param>
        internal DomainAssetResource(string kind, string id, string name, string displayName, Guid? uuid, DateTimeOffset? createdDate, DateTimeOffset? updatedDate, AssetState? state, string externalId, IReadOnlyList<string> labels, bool? wildcard, string discoGroupName, IReadOnlyList<AuditTrailItem> auditTrail, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData, DomainAsset asset) : base(kind, id, name, displayName, uuid, createdDate, updatedDate, state, externalId, labels, wildcard, discoGroupName, auditTrail, reason, serializedAdditionalRawData)
        {
            Asset = asset;
        }

        /// <summary> Initializes a new instance of <see cref="DomainAssetResource"/> for deserialization. </summary>
        internal DomainAssetResource()
        {
        }

        /// <summary> Gets the asset. </summary>
        public DomainAsset Asset { get; }
    }
}
