// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class NetworkInterfaceResource : IJsonModel<NetworkInterfaceData>
    {
        void IJsonModel<NetworkInterfaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        NetworkInterfaceData IJsonModel<NetworkInterfaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkInterfaceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<NetworkInterfaceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        NetworkInterfaceData IPersistableModel<NetworkInterfaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkInterfaceData>(data, options);
        }

        string IPersistableModel<NetworkInterfaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
