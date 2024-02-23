// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Authorization
{
    public partial class DenyAssignmentResource : IJsonModel<DenyAssignmentData>
    {
        void IJsonModel<DenyAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DenyAssignmentData IJsonModel<DenyAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DenyAssignmentData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DenyAssignmentData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DenyAssignmentData IPersistableModel<DenyAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DenyAssignmentData>(data, options);
        }

        string IPersistableModel<DenyAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
