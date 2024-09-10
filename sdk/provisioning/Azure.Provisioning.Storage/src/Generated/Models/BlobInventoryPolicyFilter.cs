// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// An object that defines the blob inventory rule filter conditions. For
/// &apos;Blob&apos; definition.objectType all filter properties are
/// applicable, &apos;blobTypes&apos; is required and others are optional. For
/// &apos;Container&apos; definition.objectType only prefixMatch is applicable
/// and is optional.
/// </summary>
public partial class BlobInventoryPolicyFilter : ProvisioningConstruct
{
    /// <summary>
    /// An array of strings with maximum 10 blob prefixes to be included in the
    /// inventory.
    /// </summary>
    public BicepList<string> IncludePrefix { get => _includePrefix; set => _includePrefix.Assign(value); }
    private readonly BicepList<string> _includePrefix;

    /// <summary>
    /// An array of strings with maximum 10 blob prefixes to be excluded from
    /// the inventory.
    /// </summary>
    public BicepList<string> ExcludePrefix { get => _excludePrefix; set => _excludePrefix.Assign(value); }
    private readonly BicepList<string> _excludePrefix;

    /// <summary>
    /// An array of predefined enum values. Valid values include blockBlob,
    /// appendBlob, pageBlob. Hns accounts does not support pageBlobs. This
    /// field is required when definition.objectType property is set to
    /// &apos;Blob&apos;.
    /// </summary>
    public BicepList<string> BlobTypes { get => _blobTypes; set => _blobTypes.Assign(value); }
    private readonly BicepList<string> _blobTypes;

    /// <summary>
    /// Includes blob versions in blob inventory when value is set to true. The
    /// definition.schemaFields values &apos;VersionId and
    /// IsCurrentVersion&apos; are required if this property is set to true,
    /// else they must be excluded.
    /// </summary>
    public BicepValue<bool> IncludeBlobVersions { get => _includeBlobVersions; set => _includeBlobVersions.Assign(value); }
    private readonly BicepValue<bool> _includeBlobVersions;

    /// <summary>
    /// Includes blob snapshots in blob inventory when value is set to true.
    /// The definition.schemaFields value &apos;Snapshot&apos; is required if
    /// this property is set to true, else it must be excluded.
    /// </summary>
    public BicepValue<bool> IncludeSnapshots { get => _includeSnapshots; set => _includeSnapshots.Assign(value); }
    private readonly BicepValue<bool> _includeSnapshots;

    /// <summary>
    /// For &apos;Container&apos; definition.objectType the
    /// definition.schemaFields must include &apos;Deleted, Version,
    /// DeletedTime and RemainingRetentionDays&apos;. For &apos;Blob&apos;
    /// definition.objectType and HNS enabled storage accounts the
    /// definition.schemaFields must include &apos;DeletionId, Deleted,
    /// DeletedTime and RemainingRetentionDays&apos; and for Hns disabled
    /// accounts the definition.schemaFields must include &apos;Deleted and
    /// RemainingRetentionDays&apos;, else it must be excluded.
    /// </summary>
    public BicepValue<bool> IncludeDeleted { get => _includeDeleted; set => _includeDeleted.Assign(value); }
    private readonly BicepValue<bool> _includeDeleted;

    /// <summary>
    /// Creates a new BlobInventoryPolicyFilter.
    /// </summary>
    public BlobInventoryPolicyFilter()
    {
        _includePrefix = BicepList<string>.DefineProperty(this, "IncludePrefix", ["prefixMatch"]);
        _excludePrefix = BicepList<string>.DefineProperty(this, "ExcludePrefix", ["excludePrefix"]);
        _blobTypes = BicepList<string>.DefineProperty(this, "BlobTypes", ["blobTypes"]);
        _includeBlobVersions = BicepValue<bool>.DefineProperty(this, "IncludeBlobVersions", ["includeBlobVersions"]);
        _includeSnapshots = BicepValue<bool>.DefineProperty(this, "IncludeSnapshots", ["includeSnapshots"]);
        _includeDeleted = BicepValue<bool>.DefineProperty(this, "IncludeDeleted", ["includeDeleted"]);
    }
}
