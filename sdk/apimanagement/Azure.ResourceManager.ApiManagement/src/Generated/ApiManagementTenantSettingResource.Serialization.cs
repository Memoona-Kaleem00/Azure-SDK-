// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementTenantSettingResource : IJsonModel<ApiManagementTenantSettingData>
    {
        void IJsonModel<ApiManagementTenantSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ApiManagementTenantSettingData IJsonModel<ApiManagementTenantSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ApiManagementTenantSettingData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ApiManagementTenantSettingData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ApiManagementTenantSettingData IPersistableModel<ApiManagementTenantSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ApiManagementTenantSettingData>(data, options);
        }

        string IPersistableModel<ApiManagementTenantSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
