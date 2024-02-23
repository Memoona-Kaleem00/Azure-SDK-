// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Media
{
    public partial class MediaLiveOutputResource : IJsonModel<MediaLiveOutputData>
    {
        void IJsonModel<MediaLiveOutputData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MediaLiveOutputData IJsonModel<MediaLiveOutputData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MediaLiveOutputData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MediaLiveOutputData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MediaLiveOutputData IPersistableModel<MediaLiveOutputData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MediaLiveOutputData>(data, options);
        }

        string IPersistableModel<MediaLiveOutputData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
