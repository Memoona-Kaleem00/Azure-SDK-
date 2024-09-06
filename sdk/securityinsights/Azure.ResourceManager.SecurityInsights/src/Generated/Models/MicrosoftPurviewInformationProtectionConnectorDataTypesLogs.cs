// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Logs data type. </summary>
    internal partial class MicrosoftPurviewInformationProtectionConnectorDataTypesLogs : DataConnectorDataTypeCommon
    {
        /// <summary> Initializes a new instance of <see cref="MicrosoftPurviewInformationProtectionConnectorDataTypesLogs"/>. </summary>
        /// <param name="state"> Describe whether this data type connection is enabled or not. </param>
        public MicrosoftPurviewInformationProtectionConnectorDataTypesLogs(SecurityInsightsDataTypeConnectionState state) : base(state)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftPurviewInformationProtectionConnectorDataTypesLogs"/>. </summary>
        /// <param name="state"> Describe whether this data type connection is enabled or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MicrosoftPurviewInformationProtectionConnectorDataTypesLogs(SecurityInsightsDataTypeConnectionState state, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(state, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftPurviewInformationProtectionConnectorDataTypesLogs"/> for deserialization. </summary>
        internal MicrosoftPurviewInformationProtectionConnectorDataTypesLogs()
        {
        }
    }
}
