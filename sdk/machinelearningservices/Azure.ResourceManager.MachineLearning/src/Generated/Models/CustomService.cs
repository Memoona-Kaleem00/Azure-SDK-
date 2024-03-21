// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Specifies the custom service configuration. </summary>
    public partial class CustomService
    {
        /// <summary> Initializes a new instance of <see cref="CustomService"/>. </summary>
        public CustomService()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, EnvironmentVariable>();
            Endpoints = new ChangeTrackingList<ContainerEndpoint>();
            Volumes = new ChangeTrackingList<VolumeDefinition>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomService"/>. </summary>
        /// <param name="name"> Name of the Custom Service. </param>
        /// <param name="image"> Describes the Image Specifications. </param>
        /// <param name="environmentVariables"> Environment Variable for the container. </param>
        /// <param name="docker"> Describes the docker settings for the image. </param>
        /// <param name="endpoints"> Configuring the endpoints for the container. </param>
        /// <param name="volumes"> Configuring the volumes for the container. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CustomService(string name, ImageSetting image, IDictionary<string, EnvironmentVariable> environmentVariables, DockerSetting docker, IList<ContainerEndpoint> endpoints, IList<VolumeDefinition> volumes, IDictionary<string, BinaryData> additionalProperties)
        {
            Name = name;
            Image = image;
            EnvironmentVariables = environmentVariables;
            Docker = docker;
            Endpoints = endpoints;
            Volumes = volumes;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the Custom Service. </summary>
        public string Name { get; set; }
        /// <summary> Describes the Image Specifications. </summary>
        public ImageSetting Image { get; set; }
        /// <summary> Environment Variable for the container. </summary>
        public IDictionary<string, EnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> Describes the docker settings for the image. </summary>
        public DockerSetting Docker { get; set; }
        /// <summary> Configuring the endpoints for the container. </summary>
        public IList<ContainerEndpoint> Endpoints { get; }
        /// <summary> Configuring the volumes for the container. </summary>
        public IList<VolumeDefinition> Volumes { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
