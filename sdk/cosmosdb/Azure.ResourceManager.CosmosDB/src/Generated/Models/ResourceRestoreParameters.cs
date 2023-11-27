// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to indicate the information about the restore. </summary>
    public partial class ResourceRestoreParameters : RestoreParametersBase
    {
        /// <summary> Initializes a new instance of <see cref="ResourceRestoreParameters"/>. </summary>
        public ResourceRestoreParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceRestoreParameters"/>. </summary>
        /// <param name="restoreSource"> The id of the restorable database account from which the restore has to be initiated. For example: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}. </param>
        /// <param name="restoreTimestampInUtc"> Time to which the account has to be restored (ISO-8601 format). </param>
        internal ResourceRestoreParameters(string restoreSource, DateTimeOffset? restoreTimestampInUtc) : base(restoreSource, restoreTimestampInUtc)
        {
        }
    }
}
