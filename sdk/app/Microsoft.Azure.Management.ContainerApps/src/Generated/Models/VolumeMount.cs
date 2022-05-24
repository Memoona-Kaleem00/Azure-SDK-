// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Volume mount for the Container App.
    /// </summary>
    public partial class VolumeMount
    {
        /// <summary>
        /// Initializes a new instance of the VolumeMount class.
        /// </summary>
        public VolumeMount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeMount class.
        /// </summary>
        /// <param name="volumeName">This must match the Name of a
        /// Volume.</param>
        /// <param name="mountPath">Path within the container at which the
        /// volume should be mounted.Must not contain ':'.</param>
        public VolumeMount(string volumeName = default(string), string mountPath = default(string))
        {
            VolumeName = volumeName;
            MountPath = mountPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this must match the Name of a Volume.
        /// </summary>
        [JsonProperty(PropertyName = "volumeName")]
        public string VolumeName { get; set; }

        /// <summary>
        /// Gets or sets path within the container at which the volume should
        /// be mounted.Must not contain ':'.
        /// </summary>
        [JsonProperty(PropertyName = "mountPath")]
        public string MountPath { get; set; }

    }
}
