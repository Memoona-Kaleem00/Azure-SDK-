// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A LongTermRetentionBackup operation result resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LongTermRetentionBackupOperationResult : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LongTermRetentionBackupOperationResult class.
        /// </summary>
        public LongTermRetentionBackupOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LongTermRetentionBackupOperationResult class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="requestId">Request Id.</param>
        /// <param name="operationType">Operation type.</param>
        /// <param name="fromBackupResourceId">Source backup resource
        /// id</param>
        /// <param name="toBackupResourceId">Target backup resource id</param>
        /// <param name="targetBackupStorageRedundancy">The storage redundancy
        /// type of the copied backup. Possible values include: 'Geo', 'Local',
        /// 'Zone'</param>
        /// <param name="status">Operation status</param>
        /// <param name="message">Progress message</param>
        public LongTermRetentionBackupOperationResult(string id = default(string), string name = default(string), string type = default(string), System.Guid? requestId = default(System.Guid?), string operationType = default(string), string fromBackupResourceId = default(string), string toBackupResourceId = default(string), BackupStorageRedundancy? targetBackupStorageRedundancy = default(BackupStorageRedundancy?), string status = default(string), string message = default(string))
            : base(id, name, type)
        {
            RequestId = requestId;
            OperationType = operationType;
            FromBackupResourceId = fromBackupResourceId;
            ToBackupResourceId = toBackupResourceId;
            TargetBackupStorageRedundancy = targetBackupStorageRedundancy;
            Status = status;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets request Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestId")]
        public System.Guid? RequestId { get; private set; }

        /// <summary>
        /// Gets operation type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationType")]
        public string OperationType { get; private set; }

        /// <summary>
        /// Gets source backup resource id
        /// </summary>
        [JsonProperty(PropertyName = "properties.fromBackupResourceId")]
        public string FromBackupResourceId { get; private set; }

        /// <summary>
        /// Gets target backup resource id
        /// </summary>
        [JsonProperty(PropertyName = "properties.toBackupResourceId")]
        public string ToBackupResourceId { get; private set; }

        /// <summary>
        /// Gets the storage redundancy type of the copied backup. Possible
        /// values include: 'Geo', 'Local', 'Zone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetBackupStorageRedundancy")]
        public BackupStorageRedundancy? TargetBackupStorageRedundancy { get; private set; }

        /// <summary>
        /// Gets operation status
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets progress message
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; private set; }

    }
}
