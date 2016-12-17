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
    /// A setting difference between two deployment slots of an app.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SlotDifferenceInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SlotDifferenceInner class.
        /// </summary>
        public SlotDifferenceInner() { }

        /// <summary>
        /// Initializes a new instance of the SlotDifferenceInner class.
        /// </summary>
        /// <param name="slotDifferenceType">Type of the difference:
        /// Information, Warning or Error.</param>
        /// <param name="settingType">The type of the setting: General,
        /// AppSetting or ConnectionString.</param>
        /// <param name="diffRule">Rule that describes how to process the
        /// setting difference during a slot swap.</param>
        /// <param name="settingName">Name of the setting.</param>
        /// <param name="valueInCurrentSlot">Value of the setting in the
        /// current slot.</param>
        /// <param name="valueInTargetSlot">Value of the setting in the target
        /// slot.</param>
        /// <param name="description">Description of the setting
        /// difference.</param>
        public SlotDifferenceInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string slotDifferenceType = default(string), string settingType = default(string), string diffRule = default(string), string settingName = default(string), string valueInCurrentSlot = default(string), string valueInTargetSlot = default(string), string description = default(string))
            : base(location, id, name, type, tags)
        {
            SlotDifferenceType = slotDifferenceType;
            SettingType = settingType;
            DiffRule = diffRule;
            SettingName = settingName;
            ValueInCurrentSlot = valueInCurrentSlot;
            ValueInTargetSlot = valueInTargetSlot;
            Description = description;
        }

        /// <summary>
        /// Gets type of the difference: Information, Warning or Error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.type")]
        public string SlotDifferenceType { get; private set; }

        /// <summary>
        /// Gets the type of the setting: General, AppSetting or
        /// ConnectionString.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.settingType")]
        public string SettingType { get; private set; }

        /// <summary>
        /// Gets rule that describes how to process the setting difference
        /// during a slot swap.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.diffRule")]
        public string DiffRule { get; private set; }

        /// <summary>
        /// Gets name of the setting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.settingName")]
        public string SettingName { get; private set; }

        /// <summary>
        /// Gets value of the setting in the current slot.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.valueInCurrentSlot")]
        public string ValueInCurrentSlot { get; private set; }

        /// <summary>
        /// Gets value of the setting in the target slot.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.valueInTargetSlot")]
        public string ValueInTargetSlot { get; private set; }

        /// <summary>
        /// Gets description of the setting difference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

    }
}
