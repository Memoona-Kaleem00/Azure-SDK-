// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoDatabaseResource : IJsonModel<KustoDatabaseData>
    {
        void IJsonModel<KustoDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        KustoDatabaseData IJsonModel<KustoDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<KustoDatabaseData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<KustoDatabaseData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        KustoDatabaseData IPersistableModel<KustoDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<KustoDatabaseData>(data, options);
        }

        string IPersistableModel<KustoDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
