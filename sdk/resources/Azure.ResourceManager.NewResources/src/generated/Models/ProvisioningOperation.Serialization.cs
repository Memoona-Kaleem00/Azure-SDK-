// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NewResources
{
    internal static partial class ProvisioningOperationExtensions
    {
        public static string ToSerialString(this ProvisioningOperation value) => value switch
        {
            ProvisioningOperation.NotSpecified => "NotSpecified",
            ProvisioningOperation.Create => "Create",
            ProvisioningOperation.Delete => "Delete",
            ProvisioningOperation.Waiting => "Waiting",
            ProvisioningOperation.AzureAsyncOperationWaiting => "AzureAsyncOperationWaiting",
            ProvisioningOperation.ResourceCacheWaiting => "ResourceCacheWaiting",
            ProvisioningOperation.Action => "Action",
            ProvisioningOperation.Read => "Read",
            ProvisioningOperation.EvaluateDeploymentOutput => "EvaluateDeploymentOutput",
            ProvisioningOperation.DeploymentCleanup => "DeploymentCleanup",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningOperation value.")
        };

        public static ProvisioningOperation ToProvisioningOperation(this string value)
        {
            if (string.Equals(value, "NotSpecified", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.NotSpecified;
            if (string.Equals(value, "Create", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.Create;
            if (string.Equals(value, "Delete", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.Delete;
            if (string.Equals(value, "Waiting", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.Waiting;
            if (string.Equals(value, "AzureAsyncOperationWaiting", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.AzureAsyncOperationWaiting;
            if (string.Equals(value, "ResourceCacheWaiting", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.ResourceCacheWaiting;
            if (string.Equals(value, "Action", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.Action;
            if (string.Equals(value, "Read", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.Read;
            if (string.Equals(value, "EvaluateDeploymentOutput", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.EvaluateDeploymentOutput;
            if (string.Equals(value, "DeploymentCleanup", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningOperation.DeploymentCleanup;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningOperation value.");
        }
    }
}
