// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.KeyVault
{
    public partial class DeletedManagedHsmResource : IJsonModel<DeletedManagedHsmData>
    {
        void IJsonModel<DeletedManagedHsmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DeletedManagedHsmData IJsonModel<DeletedManagedHsmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DeletedManagedHsmData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DeletedManagedHsmData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DeletedManagedHsmData IPersistableModel<DeletedManagedHsmData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DeletedManagedHsmData>(data, options);
        }

        string IPersistableModel<DeletedManagedHsmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
