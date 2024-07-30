// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the SiteContainer data model.
    /// Container of a site
    /// </summary>
    public partial class SiteContainerData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteContainerData"/>. </summary>
        public SiteContainerData()
        {
            VolumeMounts = new ChangeTrackingList<SiteContainerVolumeMount>();
            EnvironmentVariables = new ChangeTrackingList<WebAppEnvironmentVariable>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="image"> Image Name. </param>
        /// <param name="targetPort"> Target Port. </param>
        /// <param name="isMain"> &lt;code&gt;true&lt;/code&gt; if the container is the main site container; &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="startUpCommand"> StartUp Command. </param>
        /// <param name="authType"> Auth Type. </param>
        /// <param name="userName"> User Name. </param>
        /// <param name="passwordSecret"> Password Secret. </param>
        /// <param name="userManagedIdentityClientId"> UserManagedIdentity ClientId. </param>
        /// <param name="createdOn"> Created Time. </param>
        /// <param name="lastModifiedOn"> Last Modified Time. </param>
        /// <param name="volumeMounts"> List of volume mounts. </param>
        /// <param name="environmentVariables"> List of environment variables. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteContainerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string image, string targetPort, bool? isMain, string startUpCommand, SiteContainerAuthType? authType, string userName, string passwordSecret, string userManagedIdentityClientId, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, IList<SiteContainerVolumeMount> volumeMounts, IList<WebAppEnvironmentVariable> environmentVariables, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Image = image;
            TargetPort = targetPort;
            IsMain = isMain;
            StartUpCommand = startUpCommand;
            AuthType = authType;
            UserName = userName;
            PasswordSecret = passwordSecret;
            UserManagedIdentityClientId = userManagedIdentityClientId;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            VolumeMounts = volumeMounts;
            EnvironmentVariables = environmentVariables;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Image Name. </summary>
        [WirePath("properties.image")]
        public string Image { get; set; }
        /// <summary> Target Port. </summary>
        [WirePath("properties.targetPort")]
        public string TargetPort { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the container is the main site container; &lt;code&gt;false&lt;/code&gt; otherwise. </summary>
        [WirePath("properties.isMain")]
        public bool? IsMain { get; set; }
        /// <summary> StartUp Command. </summary>
        [WirePath("properties.startUpCommand")]
        public string StartUpCommand { get; set; }
        /// <summary> Auth Type. </summary>
        [WirePath("properties.authType")]
        public SiteContainerAuthType? AuthType { get; set; }
        /// <summary> User Name. </summary>
        [WirePath("properties.userName")]
        public string UserName { get; set; }
        /// <summary> Password Secret. </summary>
        [WirePath("properties.passwordSecret")]
        public string PasswordSecret { get; set; }
        /// <summary> UserManagedIdentity ClientId. </summary>
        [WirePath("properties.userManagedIdentityClientId")]
        public string UserManagedIdentityClientId { get; set; }
        /// <summary> Created Time. </summary>
        [WirePath("properties.createdTime")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last Modified Time. </summary>
        [WirePath("properties.lastModifiedTime")]
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> List of volume mounts. </summary>
        [WirePath("properties.volumeMounts")]
        public IList<SiteContainerVolumeMount> VolumeMounts { get; }
        /// <summary> List of environment variables. </summary>
        [WirePath("properties.environmentVariables")]
        public IList<WebAppEnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
