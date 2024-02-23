// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Media
{
    public partial class MediaAssetResource : IJsonModel<MediaAssetData>
    {
        void IJsonModel<MediaAssetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MediaAssetData IJsonModel<MediaAssetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MediaAssetData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MediaAssetData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MediaAssetData IPersistableModel<MediaAssetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MediaAssetData>(data, options);
        }

        string IPersistableModel<MediaAssetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
