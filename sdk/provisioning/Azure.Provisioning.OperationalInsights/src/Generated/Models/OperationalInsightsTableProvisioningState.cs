// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// Table&apos;s current provisioning state. If set to &apos;updating&apos;,
/// indicates a resource lock due to ongoing operation, forbidding any update
/// to the table until the ongoing operation is concluded.
/// </summary>
public enum OperationalInsightsTableProvisioningState
{
    /// <summary>
    /// Table schema is still being built and updated, table is currently
    /// locked for any changes till the procedure is done.
    /// </summary>
    Updating,

    /// <summary>
    /// Table schema is stable and without changes, table data is being updated.
    /// </summary>
    InProgress,

    /// <summary>
    /// Table state is stable and without changes, table is unlocked and open
    /// for new updates.
    /// </summary>
    Succeeded,

    /// <summary>
    /// Table state is deleting.
    /// </summary>
    Deleting,
}
