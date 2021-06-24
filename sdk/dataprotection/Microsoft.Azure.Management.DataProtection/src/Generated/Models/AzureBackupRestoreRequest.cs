// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AzureBackupRestoreRequest
    /// </summary>
    /// <remarks>
    /// Azure backup restore request
    /// </remarks>
    [Newtonsoft.Json.JsonObject("AzureBackupRestoreRequest")]
    public partial class AzureBackupRestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the AzureBackupRestoreRequest class.
        /// </summary>
        public AzureBackupRestoreRequest()
        {
            RestoreTargetInfo = new RestoreTargetInfoBase();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBackupRestoreRequest class.
        /// </summary>
        /// <param name="restoreTargetInfo">Gets or sets the restore target
        /// information.</param>
        /// <param name="sourceDataStoreType">Gets or sets the type of the
        /// source data store. Possible values include: 'ArchiveStore',
        /// 'SnapshotStore', 'VaultStore'</param>
        public AzureBackupRestoreRequest(RestoreTargetInfoBase restoreTargetInfo, string sourceDataStoreType)
        {
            RestoreTargetInfo = restoreTargetInfo;
            SourceDataStoreType = sourceDataStoreType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the restore target information.
        /// </summary>
        [JsonProperty(PropertyName = "restoreTargetInfo")]
        public RestoreTargetInfoBase RestoreTargetInfo { get; set; }

        /// <summary>
        /// Gets or sets the type of the source data store. Possible values
        /// include: 'ArchiveStore', 'SnapshotStore', 'VaultStore'
        /// </summary>
        [JsonProperty(PropertyName = "sourceDataStoreType")]
        public string SourceDataStoreType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RestoreTargetInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RestoreTargetInfo");
            }
            if (SourceDataStoreType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceDataStoreType");
            }
        }
    }
}
