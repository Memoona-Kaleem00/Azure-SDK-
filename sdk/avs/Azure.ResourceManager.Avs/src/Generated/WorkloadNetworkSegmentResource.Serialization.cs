// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class WorkloadNetworkSegmentResource : IJsonModel<WorkloadNetworkSegmentData>
    {
        void IJsonModel<WorkloadNetworkSegmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        WorkloadNetworkSegmentData IJsonModel<WorkloadNetworkSegmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<WorkloadNetworkSegmentData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<WorkloadNetworkSegmentData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        WorkloadNetworkSegmentData IPersistableModel<WorkloadNetworkSegmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<WorkloadNetworkSegmentData>(data, options);
        }

        string IPersistableModel<WorkloadNetworkSegmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
