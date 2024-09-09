// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The user owned storage for Cognitive Services account.
/// </summary>
public partial class ServiceAccountUserOwnedStorage : ProvisioningConstruct
{
    /// <summary>
    /// Full resource id of a Microsoft.Storage resource.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; set => _resourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// Gets or sets the identity client id.
    /// </summary>
    public BicepValue<Guid> IdentityClientId { get => _identityClientId; set => _identityClientId.Assign(value); }
    private readonly BicepValue<Guid> _identityClientId;

    /// <summary>
    /// Creates a new ServiceAccountUserOwnedStorage.
    /// </summary>
    public ServiceAccountUserOwnedStorage()
    {
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["resourceId"]);
        _identityClientId = BicepValue<Guid>.DefineProperty(this, "IdentityClientId", ["identityClientId"]);
    }
}
