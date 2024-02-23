// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class ScriptCmdletResource : IJsonModel<ScriptCmdletData>
    {
        void IJsonModel<ScriptCmdletData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ScriptCmdletData IJsonModel<ScriptCmdletData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ScriptCmdletData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ScriptCmdletData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ScriptCmdletData IPersistableModel<ScriptCmdletData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ScriptCmdletData>(data, options);
        }

        string IPersistableModel<ScriptCmdletData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
