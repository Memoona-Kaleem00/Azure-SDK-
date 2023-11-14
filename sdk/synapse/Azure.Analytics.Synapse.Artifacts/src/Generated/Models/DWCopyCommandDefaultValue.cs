// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Default value. </summary>
    public partial class DWCopyCommandDefaultValue
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DWCopyCommandDefaultValue"/>. </summary>
        public DWCopyCommandDefaultValue()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DWCopyCommandDefaultValue"/>. </summary>
        /// <param name="columnName"> Column name. Type: object (or Expression with resultType string). </param>
        /// <param name="defaultValue"> The default value of the column. Type: object (or Expression with resultType string). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DWCopyCommandDefaultValue(object columnName, object defaultValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ColumnName = columnName;
            DefaultValue = defaultValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Column name. Type: object (or Expression with resultType string). </summary>
        public object ColumnName { get; set; }
        /// <summary> The default value of the column. Type: object (or Expression with resultType string). </summary>
        public object DefaultValue { get; set; }
    }
}
