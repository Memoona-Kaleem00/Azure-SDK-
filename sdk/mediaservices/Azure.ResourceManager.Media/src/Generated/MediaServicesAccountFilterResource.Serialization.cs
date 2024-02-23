// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Media
{
    public partial class MediaServicesAccountFilterResource : IJsonModel<MediaServicesAccountFilterData>
    {
        void IJsonModel<MediaServicesAccountFilterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MediaServicesAccountFilterData IJsonModel<MediaServicesAccountFilterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MediaServicesAccountFilterData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MediaServicesAccountFilterData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MediaServicesAccountFilterData IPersistableModel<MediaServicesAccountFilterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MediaServicesAccountFilterData>(data, options);
        }

        string IPersistableModel<MediaServicesAccountFilterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
