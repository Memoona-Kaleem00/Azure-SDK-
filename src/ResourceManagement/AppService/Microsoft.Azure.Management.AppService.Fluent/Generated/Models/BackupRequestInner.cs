// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Description of a backup which will be performed.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class BackupRequestInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the BackupRequestInner class.
        /// </summary>
        public BackupRequestInner() { }

        /// <summary>
        /// Initializes a new instance of the BackupRequestInner class.
        /// </summary>
        /// <param name="backupRequestName">Name of the backup.</param>
        /// <param name="enabled">True if the backup schedule is enabled (must
        /// be included in that case), false if the backup schedule should be
        /// disabled.</param>
        /// <param name="storageAccountUrl">SAS URL to the container.</param>
        /// <param name="backupSchedule">Schedule for the backup if it is
        /// executed periodically.</param>
        /// <param name="databases">Databases included in the backup.</param>
        /// <param name="backupRequestType">Type of the backup. Possible
        /// values include: 'Default', 'Clone', 'Relocation'</param>
        public BackupRequestInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string backupRequestName = default(string), bool? enabled = default(bool?), string storageAccountUrl = default(string), BackupSchedule backupSchedule = default(BackupSchedule), System.Collections.Generic.IList<DatabaseBackupSetting> databases = default(System.Collections.Generic.IList<DatabaseBackupSetting>), BackupRestoreOperationType? backupRequestType = default(BackupRestoreOperationType?))
            : base(location, id, name, type, tags)
        {
            BackupRequestName = backupRequestName;
            Enabled = enabled;
            StorageAccountUrl = storageAccountUrl;
            BackupSchedule = backupSchedule;
            Databases = databases;
            BackupRequestType = backupRequestType;
        }

        /// <summary>
        /// Gets or sets name of the backup.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.name")]
        public string BackupRequestName { get; set; }

        /// <summary>
        /// Gets or sets true if the backup schedule is enabled (must be
        /// included in that case), false if the backup schedule should be
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets SAS URL to the container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountUrl")]
        public string StorageAccountUrl { get; set; }

        /// <summary>
        /// Gets or sets schedule for the backup if it is executed
        /// periodically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backupSchedule")]
        public BackupSchedule BackupSchedule { get; set; }

        /// <summary>
        /// Gets or sets databases included in the backup.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databases")]
        public System.Collections.Generic.IList<DatabaseBackupSetting> Databases { get; set; }

        /// <summary>
        /// Gets or sets type of the backup. Possible values include:
        /// 'Default', 'Clone', 'Relocation'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.type")]
        public BackupRestoreOperationType? BackupRequestType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.BackupSchedule != null)
            {
                this.BackupSchedule.Validate();
            }
            if (this.Databases != null)
            {
                foreach (var element in this.Databases)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
