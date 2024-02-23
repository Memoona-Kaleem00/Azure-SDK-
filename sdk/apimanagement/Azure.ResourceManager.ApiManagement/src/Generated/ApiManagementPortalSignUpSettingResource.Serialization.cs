// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementPortalSignUpSettingResource : IJsonModel<ApiManagementPortalSignUpSettingData>
    {
        void IJsonModel<ApiManagementPortalSignUpSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ApiManagementPortalSignUpSettingData IJsonModel<ApiManagementPortalSignUpSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ApiManagementPortalSignUpSettingData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ApiManagementPortalSignUpSettingData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ApiManagementPortalSignUpSettingData IPersistableModel<ApiManagementPortalSignUpSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ApiManagementPortalSignUpSettingData>(data, options);
        }

        string IPersistableModel<ApiManagementPortalSignUpSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
