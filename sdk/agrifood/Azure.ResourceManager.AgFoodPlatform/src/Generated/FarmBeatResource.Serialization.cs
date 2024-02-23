// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class FarmBeatResource : IJsonModel<FarmBeatData>
    {
        void IJsonModel<FarmBeatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        FarmBeatData IJsonModel<FarmBeatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FarmBeatData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<FarmBeatData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        FarmBeatData IPersistableModel<FarmBeatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FarmBeatData>(data, options);
        }

        string IPersistableModel<FarmBeatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
