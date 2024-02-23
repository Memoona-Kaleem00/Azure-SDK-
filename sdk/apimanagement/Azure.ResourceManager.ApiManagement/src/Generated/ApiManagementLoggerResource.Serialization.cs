// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementLoggerResource : IJsonModel<ApiManagementLoggerData>
    {
        void IJsonModel<ApiManagementLoggerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ApiManagementLoggerData IJsonModel<ApiManagementLoggerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ApiManagementLoggerData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ApiManagementLoggerData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ApiManagementLoggerData IPersistableModel<ApiManagementLoggerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ApiManagementLoggerData>(data, options);
        }

        string IPersistableModel<ApiManagementLoggerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
