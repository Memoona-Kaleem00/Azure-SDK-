// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.BillingBenefits
{
    public partial class BillingBenefitsSavingsPlanOrderAliasResource : IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>
    {
        void IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        BillingBenefitsSavingsPlanOrderAliasData IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<BillingBenefitsSavingsPlanOrderAliasData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        BillingBenefitsSavingsPlanOrderAliasData IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<BillingBenefitsSavingsPlanOrderAliasData>(data, options);
        }

        string IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
