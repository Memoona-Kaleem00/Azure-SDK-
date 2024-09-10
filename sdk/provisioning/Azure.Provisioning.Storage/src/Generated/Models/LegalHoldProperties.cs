// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The LegalHold property of a blob container.
/// </summary>
public partial class LegalHoldProperties : ProvisioningConstruct
{
    /// <summary>
    /// The hasLegalHold public property is set to true by SRP if there are at
    /// least one existing tag. The hasLegalHold public property is set to
    /// false by SRP if all existing legal hold tags are cleared out. There
    /// can be a maximum of 1000 blob containers with hasLegalHold=true for a
    /// given account.
    /// </summary>
    public BicepValue<bool> HasLegalHold { get => _hasLegalHold; }
    private readonly BicepValue<bool> _hasLegalHold;

    /// <summary>
    /// The list of LegalHold tags of a blob container.
    /// </summary>
    public BicepList<LegalHoldTag> Tags { get => _tags; }
    private readonly BicepList<LegalHoldTag> _tags;

    /// <summary>
    /// Protected append blob writes history.
    /// </summary>
    public BicepValue<ProtectedAppendWritesHistory> ProtectedAppendWritesHistory { get => _protectedAppendWritesHistory; }
    private readonly BicepValue<ProtectedAppendWritesHistory> _protectedAppendWritesHistory;

    /// <summary>
    /// Creates a new LegalHoldProperties.
    /// </summary>
    public LegalHoldProperties()
    {
        _hasLegalHold = BicepValue<bool>.DefineProperty(this, "HasLegalHold", ["hasLegalHold"], isOutput: true);
        _tags = BicepList<LegalHoldTag>.DefineProperty(this, "Tags", ["tags"], isOutput: true);
        _protectedAppendWritesHistory = BicepValue<ProtectedAppendWritesHistory>.DefineProperty(this, "ProtectedAppendWritesHistory", ["protectedAppendWritesHistory"], isOutput: true);
    }
}
