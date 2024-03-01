// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.IotHub
{
    public partial class IotHubPrivateEndpointConnectionResource : IJsonModel<IotHubPrivateEndpointConnectionData>
    {
        void IJsonModel<IotHubPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<IotHubPrivateEndpointConnectionData>)Data).Write(writer, options);

        IotHubPrivateEndpointConnectionData IJsonModel<IotHubPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<IotHubPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<IotHubPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        IotHubPrivateEndpointConnectionData IPersistableModel<IotHubPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<IotHubPrivateEndpointConnectionData>(data, options);

        string IPersistableModel<IotHubPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<IotHubPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}
