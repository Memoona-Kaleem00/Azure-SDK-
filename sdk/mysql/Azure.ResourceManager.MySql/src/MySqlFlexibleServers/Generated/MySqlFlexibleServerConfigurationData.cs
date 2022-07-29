// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary> A class representing the MySqlFlexibleServerConfiguration data model. </summary>
    public partial class MySqlFlexibleServerConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurationData. </summary>
        public MySqlFlexibleServerConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <param name="isReadOnly"> If is the configuration read only. </param>
        /// <param name="isConfigPendingRestart"> If is the configuration pending restart or not. </param>
        /// <param name="isDynamicConfig"> If is the configuration dynamic. </param>
        internal MySqlFlexibleServerConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string value, string description, string defaultValue, string dataType, string allowedValues, MySqlFlexibleServerConfigurationSource? source, MySqlFlexibleServerConfigReadOnlyState? isReadOnly, MySqlFlexibleServerConfigPendingRestartState? isConfigPendingRestart, MySqlFlexibleServerConfigDynamicState? isDynamicConfig) : base(id, name, resourceType, systemData)
        {
            Value = value;
            Description = description;
            DefaultValue = defaultValue;
            DataType = dataType;
            AllowedValues = allowedValues;
            Source = source;
            IsReadOnly = isReadOnly;
            IsConfigPendingRestart = isConfigPendingRestart;
            IsDynamicConfig = isDynamicConfig;
        }

        /// <summary> Value of the configuration. </summary>
        public string Value { get; set; }
        /// <summary> Description of the configuration. </summary>
        public string Description { get; }
        /// <summary> Default value of the configuration. </summary>
        public string DefaultValue { get; }
        /// <summary> Data type of the configuration. </summary>
        public string DataType { get; }
        /// <summary> Allowed values of the configuration. </summary>
        public string AllowedValues { get; }
        /// <summary> Source of the configuration. </summary>
        public MySqlFlexibleServerConfigurationSource? Source { get; set; }
        /// <summary> If is the configuration read only. </summary>
        public MySqlFlexibleServerConfigReadOnlyState? IsReadOnly { get; }
        /// <summary> If is the configuration pending restart or not. </summary>
        public MySqlFlexibleServerConfigPendingRestartState? IsConfigPendingRestart { get; }
        /// <summary> If is the configuration dynamic. </summary>
        public MySqlFlexibleServerConfigDynamicState? IsDynamicConfig { get; }
    }
}
