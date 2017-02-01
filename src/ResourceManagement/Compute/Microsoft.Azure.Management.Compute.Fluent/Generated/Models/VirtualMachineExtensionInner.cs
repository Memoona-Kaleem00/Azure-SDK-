// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Extension.
    /// </summary>
    [JsonTransformation]
    public partial class VirtualMachineExtensionInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtensionInner
        /// class.
        /// </summary>
        public VirtualMachineExtensionInner() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtensionInner
        /// class.
        /// </summary>
        /// <param name="forceUpdateTag">How the extension handler should be
        /// forced to update even if the extension configuration has not
        /// changed.</param>
        /// <param name="publisher">The name of the extension handler
        /// publisher.</param>
        /// <param name="virtualMachineExtensionType">The type of the extension
        /// handler.</param>
        /// <param name="typeHandlerVersion">The type version of the extension
        /// handler.</param>
        /// <param name="autoUpgradeMinorVersion">Whether the extension handler
        /// should be automatically upgraded across minor versions.</param>
        /// <param name="settings">Json formatted public settings for the
        /// extension.</param>
        /// <param name="protectedSettings">Json formatted protected settings
        /// for the extension.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">The virtual machine extension instance
        /// view.</param>
        public VirtualMachineExtensionInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string forceUpdateTag = default(string), string publisher = default(string), string virtualMachineExtensionType = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string), VirtualMachineExtensionInstanceView instanceView = default(VirtualMachineExtensionInstanceView))
            : base(location, id, name, type, tags)
        {
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            VirtualMachineExtensionType = virtualMachineExtensionType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
        }

        /// <summary>
        /// Gets or sets how the extension handler should be forced to update
        /// even if the extension configuration has not changed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the type of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string VirtualMachineExtensionType { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets whether the extension handler should be automatically
        /// upgraded across minor versions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets json formatted public settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets json formatted protected settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets or sets the virtual machine extension instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineExtensionInstanceView InstanceView { get; set; }

    }
}

