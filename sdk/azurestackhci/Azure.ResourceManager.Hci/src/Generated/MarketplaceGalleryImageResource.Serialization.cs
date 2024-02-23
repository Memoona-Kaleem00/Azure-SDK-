// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class MarketplaceGalleryImageResource : IJsonModel<MarketplaceGalleryImageData>
    {
        void IJsonModel<MarketplaceGalleryImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MarketplaceGalleryImageData IJsonModel<MarketplaceGalleryImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MarketplaceGalleryImageData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MarketplaceGalleryImageData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MarketplaceGalleryImageData IPersistableModel<MarketplaceGalleryImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MarketplaceGalleryImageData>(data, options);
        }

        string IPersistableModel<MarketplaceGalleryImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
