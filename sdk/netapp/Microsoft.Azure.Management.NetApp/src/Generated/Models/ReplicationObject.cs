// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Replication properties
    /// </summary>
    public partial class ReplicationObject
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationObject class.
        /// </summary>
        public ReplicationObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReplicationObject class.
        /// </summary>
        /// <param name="replicationSchedule">Schedule. Possible values
        /// include: '_10minutely', 'hourly', 'daily'</param>
        /// <param name="remoteVolumeResourceId">The resource ID of the remote
        /// volume.</param>
        /// <param name="replicationId">Id</param>
        /// <param name="endpointType">Indicates whether the local volume is
        /// the source or destination for the Volume Replication. Possible
        /// values include: 'src', 'dst'</param>
        /// <param name="remoteVolumeRegion">The remote region for the other
        /// end of the Volume Replication.</param>
        public ReplicationObject(string replicationSchedule, string remoteVolumeResourceId, string replicationId = default(string), string endpointType = default(string), string remoteVolumeRegion = default(string))
        {
            ReplicationId = replicationId;
            EndpointType = endpointType;
            ReplicationSchedule = replicationSchedule;
            RemoteVolumeResourceId = remoteVolumeResourceId;
            RemoteVolumeRegion = remoteVolumeRegion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id
        /// </summary>
        [JsonProperty(PropertyName = "replicationId")]
        public string ReplicationId { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the local volume is the source or
        /// destination for the Volume Replication. Possible values include:
        /// 'src', 'dst'
        /// </summary>
        [JsonProperty(PropertyName = "endpointType")]
        public string EndpointType { get; set; }

        /// <summary>
        /// Gets or sets schedule. Possible values include: '_10minutely',
        /// 'hourly', 'daily'
        /// </summary>
        [JsonProperty(PropertyName = "replicationSchedule")]
        public string ReplicationSchedule { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the remote volume.
        /// </summary>
        [JsonProperty(PropertyName = "remoteVolumeResourceId")]
        public string RemoteVolumeResourceId { get; set; }

        /// <summary>
        /// Gets or sets the remote region for the other end of the Volume
        /// Replication.
        /// </summary>
        [JsonProperty(PropertyName = "remoteVolumeRegion")]
        public string RemoteVolumeRegion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReplicationSchedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReplicationSchedule");
            }
            if (RemoteVolumeResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemoteVolumeResourceId");
            }
        }
    }
}
