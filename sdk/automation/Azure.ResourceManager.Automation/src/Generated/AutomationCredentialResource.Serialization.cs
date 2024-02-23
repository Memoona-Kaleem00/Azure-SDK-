// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationCredentialResource : IJsonModel<AutomationCredentialData>
    {
        void IJsonModel<AutomationCredentialData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AutomationCredentialData IJsonModel<AutomationCredentialData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AutomationCredentialData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AutomationCredentialData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AutomationCredentialData IPersistableModel<AutomationCredentialData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AutomationCredentialData>(data, options);
        }

        string IPersistableModel<AutomationCredentialData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
