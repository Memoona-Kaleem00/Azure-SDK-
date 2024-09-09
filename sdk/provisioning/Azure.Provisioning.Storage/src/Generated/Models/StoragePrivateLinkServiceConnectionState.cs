// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// A collection of information about the state of the connection between
/// service consumer and provider.
/// </summary>
public partial class StoragePrivateLinkServiceConnectionState : ProvisioningConstruct
{
    /// <summary>
    /// Indicates whether the connection has been Approved/Rejected/Removed by
    /// the owner of the service.
    /// </summary>
    public BicepValue<StoragePrivateEndpointServiceConnectionStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<StoragePrivateEndpointServiceConnectionStatus> _status;

    /// <summary>
    /// The reason for approval/rejection of the connection.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// A message indicating if changes on the service provider require any
    /// updates on the consumer.
    /// </summary>
    public BicepValue<string> ActionRequired { get => _actionRequired; set => _actionRequired.Assign(value); }
    private readonly BicepValue<string> _actionRequired;

    /// <summary>
    /// Creates a new StoragePrivateLinkServiceConnectionState.
    /// </summary>
    public StoragePrivateLinkServiceConnectionState()
    {
        _status = BicepValue<StoragePrivateEndpointServiceConnectionStatus>.DefineProperty(this, "Status", ["status"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _actionRequired = BicepValue<string>.DefineProperty(this, "ActionRequired", ["actionRequired"]);
    }
}
