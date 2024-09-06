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
    /// <summary> Represents OfficeIRM (Microsoft Insider Risk Management) data connector. </summary>
    public partial class OfficeIRMDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="OfficeIRMDataConnector"/>. </summary>
        public OfficeIRMDataConnector()
        {
            Kind = DataConnectorKind.OfficeIRM;
        }

        /// <summary> Initializes a new instance of <see cref="OfficeIRMDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="alerts"> Alerts data type connection. </param>
        internal OfficeIRMDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId, DataConnectorDataTypeCommon alerts) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            Alerts = alerts;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        [WirePath("properties.tenantId")]
        public Guid? TenantId { get; set; }
        /// <summary> Alerts data type connection. </summary>
        internal DataConnectorDataTypeCommon Alerts { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        [WirePath("properties.alerts.state")]
        public SecurityInsightsDataTypeConnectionState? AlertsState
        {
            get => Alerts is null ? default(SecurityInsightsDataTypeConnectionState?) : Alerts.State;
            set
            {
                Alerts = value.HasValue ? new DataConnectorDataTypeCommon(value.Value) : null;
            }
        }
    }
}
