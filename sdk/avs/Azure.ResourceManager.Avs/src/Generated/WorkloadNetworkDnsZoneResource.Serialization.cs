// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class WorkloadNetworkDnsZoneResource : IJsonModel<WorkloadNetworkDnsZoneData>
    {
        void IJsonModel<WorkloadNetworkDnsZoneData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        WorkloadNetworkDnsZoneData IJsonModel<WorkloadNetworkDnsZoneData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<WorkloadNetworkDnsZoneData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<WorkloadNetworkDnsZoneData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        WorkloadNetworkDnsZoneData IPersistableModel<WorkloadNetworkDnsZoneData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<WorkloadNetworkDnsZoneData>(data, options);
        }

        string IPersistableModel<WorkloadNetworkDnsZoneData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
