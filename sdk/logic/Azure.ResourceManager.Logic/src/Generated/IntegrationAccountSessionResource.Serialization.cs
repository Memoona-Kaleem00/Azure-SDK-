// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Logic
{
    public partial class IntegrationAccountSessionResource : IJsonModel<IntegrationAccountSessionData>
    {
        void IJsonModel<IntegrationAccountSessionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        IntegrationAccountSessionData IJsonModel<IntegrationAccountSessionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<IntegrationAccountSessionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<IntegrationAccountSessionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        IntegrationAccountSessionData IPersistableModel<IntegrationAccountSessionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<IntegrationAccountSessionData>(data, options);
        }

        string IPersistableModel<IntegrationAccountSessionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
