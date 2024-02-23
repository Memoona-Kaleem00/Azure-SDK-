// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CognitiveServices
{
    public partial class CommitmentPlanAccountAssociationResource : IJsonModel<CommitmentPlanAccountAssociationData>
    {
        void IJsonModel<CommitmentPlanAccountAssociationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CommitmentPlanAccountAssociationData IJsonModel<CommitmentPlanAccountAssociationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CommitmentPlanAccountAssociationData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CommitmentPlanAccountAssociationData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CommitmentPlanAccountAssociationData IPersistableModel<CommitmentPlanAccountAssociationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CommitmentPlanAccountAssociationData>(data, options);
        }

        string IPersistableModel<CommitmentPlanAccountAssociationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
