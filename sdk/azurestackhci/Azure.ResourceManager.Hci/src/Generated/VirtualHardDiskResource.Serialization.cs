// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class VirtualHardDiskResource : IJsonModel<VirtualHardDiskData>
    {
        void IJsonModel<VirtualHardDiskData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        VirtualHardDiskData IJsonModel<VirtualHardDiskData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualHardDiskData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<VirtualHardDiskData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        VirtualHardDiskData IPersistableModel<VirtualHardDiskData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualHardDiskData>(data, options);
        }

        string IPersistableModel<VirtualHardDiskData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
