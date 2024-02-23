// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagementPartner
{
    public partial class PartnerResponseResource : IJsonModel<PartnerResponseData>
    {
        void IJsonModel<PartnerResponseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PartnerResponseData IJsonModel<PartnerResponseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PartnerResponseData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PartnerResponseData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PartnerResponseData IPersistableModel<PartnerResponseData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PartnerResponseData>(data, options);
        }

        string IPersistableModel<PartnerResponseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
