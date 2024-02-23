// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.BotService
{
    public partial class BotChannelResource : IJsonModel<BotChannelData>
    {
        void IJsonModel<BotChannelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        BotChannelData IJsonModel<BotChannelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<BotChannelData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<BotChannelData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        BotChannelData IPersistableModel<BotChannelData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<BotChannelData>(data, options);
        }

        string IPersistableModel<BotChannelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
