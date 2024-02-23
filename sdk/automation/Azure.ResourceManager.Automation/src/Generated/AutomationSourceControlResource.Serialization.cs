// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationSourceControlResource : IJsonModel<AutomationSourceControlData>
    {
        void IJsonModel<AutomationSourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AutomationSourceControlData IJsonModel<AutomationSourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AutomationSourceControlData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AutomationSourceControlData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AutomationSourceControlData IPersistableModel<AutomationSourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AutomationSourceControlData>(data, options);
        }

        string IPersistableModel<AutomationSourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
