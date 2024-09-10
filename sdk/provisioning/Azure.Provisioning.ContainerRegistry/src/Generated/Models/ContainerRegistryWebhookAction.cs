// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The ContainerRegistryWebhookAction.
/// </summary>
public enum ContainerRegistryWebhookAction
{
    /// <summary>
    /// push.
    /// </summary>
    [DataMember(Name = "push")]
    Push,

    /// <summary>
    /// delete.
    /// </summary>
    [DataMember(Name = "delete")]
    Delete,

    /// <summary>
    /// quarantine.
    /// </summary>
    [DataMember(Name = "quarantine")]
    Quarantine,

    /// <summary>
    /// chart_push.
    /// </summary>
    [DataMember(Name = "chart_push")]
    ChartPush,

    /// <summary>
    /// chart_delete.
    /// </summary>
    [DataMember(Name = "chart_delete")]
    ChartDelete,
}
