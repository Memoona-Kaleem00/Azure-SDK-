// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.LargeInstance
{
    public partial class LargeInstanceResource : IJsonModel<LargeInstanceData>
    {
        void IJsonModel<LargeInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        LargeInstanceData IJsonModel<LargeInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<LargeInstanceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<LargeInstanceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        LargeInstanceData IPersistableModel<LargeInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<LargeInstanceData>(data, options);
        }

        string IPersistableModel<LargeInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
