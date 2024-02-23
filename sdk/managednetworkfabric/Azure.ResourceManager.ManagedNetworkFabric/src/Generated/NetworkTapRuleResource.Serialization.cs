// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkTapRuleResource : IJsonModel<NetworkTapRuleData>
    {
        void IJsonModel<NetworkTapRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        NetworkTapRuleData IJsonModel<NetworkTapRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkTapRuleData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<NetworkTapRuleData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        NetworkTapRuleData IPersistableModel<NetworkTapRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkTapRuleData>(data, options);
        }

        string IPersistableModel<NetworkTapRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
