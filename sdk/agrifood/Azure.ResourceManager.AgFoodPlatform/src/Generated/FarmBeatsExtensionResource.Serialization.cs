// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class FarmBeatsExtensionResource : IJsonModel<FarmBeatsExtensionData>
    {
        void IJsonModel<FarmBeatsExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        FarmBeatsExtensionData IJsonModel<FarmBeatsExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FarmBeatsExtensionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<FarmBeatsExtensionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        FarmBeatsExtensionData IPersistableModel<FarmBeatsExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FarmBeatsExtensionData>(data, options);
        }

        string IPersistableModel<FarmBeatsExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
