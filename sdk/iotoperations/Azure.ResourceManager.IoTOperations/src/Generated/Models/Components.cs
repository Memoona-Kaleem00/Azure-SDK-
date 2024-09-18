// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> The configuration for components of the AIO Instance. </summary>
    public partial class Components
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

        /// <summary> Initializes a new instance of <see cref="Components"/>. </summary>
        public Components()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Components"/>. </summary>
        /// <param name="adr"> The properties of the ADR instance. </param>
        /// <param name="akri"> The properties of the AKRI instance. </param>
        /// <param name="connectors"> The properties of the connectors instance. </param>
        /// <param name="dataflows"> The properties of the dataflows instance. </param>
        /// <param name="schemaRegistry"> The properties of the device provisioning instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Components(AdrProperties adr, AkriInstanceProperties akri, ConnectorInstanceProperties connectors, DataflowInstanceProperties dataflows, SchemaRegistryInstanceProperties schemaRegistry, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Adr = adr;
            Akri = akri;
            Connectors = connectors;
            Dataflows = dataflows;
            SchemaRegistry = schemaRegistry;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The properties of the ADR instance. </summary>
        internal AdrProperties Adr { get; set; }
        /// <summary> This determines if the ADR service is enabled. </summary>
        public OperationalMode? AdrState
        {
            get => Adr is null ? default(OperationalMode?) : Adr.State;
            set
            {
                Adr = value.HasValue ? new AdrProperties(value.Value) : null;
            }
        }

        /// <summary> The properties of the AKRI instance. </summary>
        internal AkriInstanceProperties Akri { get; set; }
        /// <summary> This determines if the AKRI service is enabled. </summary>
        public OperationalMode? AkriState
        {
            get => Akri is null ? default(OperationalMode?) : Akri.State;
            set
            {
                Akri = value.HasValue ? new AkriInstanceProperties(value.Value) : null;
            }
        }

        /// <summary> The properties of the connectors instance. </summary>
        internal ConnectorInstanceProperties Connectors { get; set; }
        /// <summary> This determines if the Connector service is enabled. </summary>
        public OperationalMode? ConnectorsState
        {
            get => Connectors is null ? default(OperationalMode?) : Connectors.State;
            set
            {
                Connectors = value.HasValue ? new ConnectorInstanceProperties(value.Value) : null;
            }
        }

        /// <summary> The properties of the dataflows instance. </summary>
        internal DataflowInstanceProperties Dataflows { get; set; }
        /// <summary> This determines if the Dataflow service is enabled. </summary>
        public OperationalMode? DataflowsState
        {
            get => Dataflows is null ? default(OperationalMode?) : Dataflows.State;
            set
            {
                Dataflows = value.HasValue ? new DataflowInstanceProperties(value.Value) : null;
            }
        }

        /// <summary> The properties of the device provisioning instance. </summary>
        internal SchemaRegistryInstanceProperties SchemaRegistry { get; set; }
        /// <summary> This determines if the Schema Registry service is enabled. </summary>
        public OperationalMode? SchemaRegistryState
        {
            get => SchemaRegistry is null ? default(OperationalMode?) : SchemaRegistry.State;
            set
            {
                SchemaRegistry = value.HasValue ? new SchemaRegistryInstanceProperties(value.Value) : null;
            }
        }
    }
}
