// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppConfiguration
{
    public partial class AppConfigurationPrivateEndpointConnectionResource : IJsonModel<AppConfigurationPrivateEndpointConnectionData>
    {
        void IJsonModel<AppConfigurationPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AppConfigurationPrivateEndpointConnectionData IJsonModel<AppConfigurationPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AppConfigurationPrivateEndpointConnectionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AppConfigurationPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AppConfigurationPrivateEndpointConnectionData IPersistableModel<AppConfigurationPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AppConfigurationPrivateEndpointConnectionData>(data, options);
        }

        string IPersistableModel<AppConfigurationPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
