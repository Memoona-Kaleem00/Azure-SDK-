// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingEndpointResource : IJsonModel<StreamingEndpointData>
    {
        void IJsonModel<StreamingEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        StreamingEndpointData IJsonModel<StreamingEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<StreamingEndpointData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<StreamingEndpointData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        StreamingEndpointData IPersistableModel<StreamingEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<StreamingEndpointData>(data, options);
        }

        string IPersistableModel<StreamingEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
