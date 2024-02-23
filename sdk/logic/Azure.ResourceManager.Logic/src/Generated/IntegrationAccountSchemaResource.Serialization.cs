// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Logic
{
    public partial class IntegrationAccountSchemaResource : IJsonModel<IntegrationAccountSchemaData>
    {
        void IJsonModel<IntegrationAccountSchemaData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        IntegrationAccountSchemaData IJsonModel<IntegrationAccountSchemaData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<IntegrationAccountSchemaData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<IntegrationAccountSchemaData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        IntegrationAccountSchemaData IPersistableModel<IntegrationAccountSchemaData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<IntegrationAccountSchemaData>(data, options);
        }

        string IPersistableModel<IntegrationAccountSchemaData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
