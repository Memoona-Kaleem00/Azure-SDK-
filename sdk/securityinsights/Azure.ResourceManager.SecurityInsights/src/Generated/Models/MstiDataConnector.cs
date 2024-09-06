// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Microsoft Threat Intelligence data connector. </summary>
    public partial class MstiDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="MstiDataConnector"/>. </summary>
        public MstiDataConnector()
        {
            Kind = DataConnectorKind.MicrosoftThreatIntelligence;
        }

        /// <summary> Initializes a new instance of <see cref="MstiDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="microsoftEmergingThreatFeed"> Data type for Microsoft Threat Intelligence Platforms data connector. </param>
        internal MstiDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId, MstiDataConnectorDataTypesMicrosoftEmergingThreatFeed microsoftEmergingThreatFeed) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            MicrosoftEmergingThreatFeed = microsoftEmergingThreatFeed;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        [WirePath("properties.tenantId")]
        public Guid? TenantId { get; set; }
        /// <summary> Data type for Microsoft Threat Intelligence Platforms data connector. </summary>
        [WirePath("properties.microsoftEmergingThreatFeed")]
        public MstiDataConnectorDataTypesMicrosoftEmergingThreatFeed MicrosoftEmergingThreatFeed { get; set; }
    }
}
