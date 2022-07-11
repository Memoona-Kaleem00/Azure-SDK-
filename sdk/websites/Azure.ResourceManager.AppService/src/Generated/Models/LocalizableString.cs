// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Localizable string object containing the name and a localized value.
    /// Serialized Name: LocalizableString
    /// </summary>
    public partial class LocalizableString
    {
        /// <summary> Initializes a new instance of LocalizableString. </summary>
        internal LocalizableString()
        {
        }

        /// <summary> Initializes a new instance of LocalizableString. </summary>
        /// <param name="value">
        /// Non-localized name.
        /// Serialized Name: LocalizableString.value
        /// </param>
        /// <param name="localizedValue">
        /// Localized name.
        /// Serialized Name: LocalizableString.localizedValue
        /// </param>
        internal LocalizableString(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary>
        /// Non-localized name.
        /// Serialized Name: LocalizableString.value
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Localized name.
        /// Serialized Name: LocalizableString.localizedValue
        /// </summary>
        public string LocalizedValue { get; }
    }
}
