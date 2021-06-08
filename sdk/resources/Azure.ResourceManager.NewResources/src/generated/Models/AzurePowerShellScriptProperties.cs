// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Properties of the Azure PowerShell script object. </summary>
    internal partial class AzurePowerShellScriptProperties : DeploymentScriptPropertiesBase
    {
        /// <summary> Initializes a new instance of AzurePowerShellScriptProperties. </summary>
        /// <param name="azPowerShellVersion"> Azure PowerShell module version to be used. </param>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azPowerShellVersion"/> is null. </exception>
        internal AzurePowerShellScriptProperties(string azPowerShellVersion, TimeSpan retentionInterval)
        {
            if (azPowerShellVersion == null)
            {
                throw new ArgumentNullException(nameof(azPowerShellVersion));
            }

            AzPowerShellVersion = azPowerShellVersion;
            SupportingScriptUris = new ChangeTrackingList<string>();
            EnvironmentVariables = new ChangeTrackingList<EnvironmentVariable>();
            RetentionInterval = retentionInterval;
        }

        /// <summary> Azure PowerShell module version to be used. </summary>
        public string AzPowerShellVersion { get; }
        /// <summary> Uri for the script. This is the entry point for the external script. </summary>
        public string PrimaryScriptUri { get; }
        /// <summary> Supporting files for the external script. </summary>
        public IReadOnlyList<string> SupportingScriptUris { get; }
        /// <summary> Script body. </summary>
        public string ScriptContent { get; }
        /// <summary> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location &apos;West US 2&apos;. </summary>
        public string Arguments { get; }
        /// <summary> The environment variables to pass over to the script. </summary>
        public IReadOnlyList<EnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </summary>
        public string ForceUpdateTag { get; }
        /// <summary> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </summary>
        public TimeSpan RetentionInterval { get; }
        /// <summary> Maximum allowed script execution time specified in ISO 8601 format. Default value is P1D. </summary>
        public TimeSpan? Timeout { get; }
    }
}
