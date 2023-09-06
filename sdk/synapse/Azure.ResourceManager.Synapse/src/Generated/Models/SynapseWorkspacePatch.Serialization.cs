// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseWorkspacePatch : IUtf8JsonSerializable, IModelJsonSerializable<SynapseWorkspacePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseWorkspacePatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseWorkspacePatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspacePatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlAdministratorLoginPassword))
            {
                writer.WritePropertyName("sqlAdministratorLoginPassword"u8);
                writer.WriteStringValue(SqlAdministratorLoginPassword);
            }
            if (Optional.IsDefined(ManagedVirtualNetworkSettings))
            {
                writer.WritePropertyName("managedVirtualNetworkSettings"u8);
                if (ManagedVirtualNetworkSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SynapseManagedVirtualNetworkSettings>)ManagedVirtualNetworkSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(WorkspaceRepositoryConfiguration))
            {
                writer.WritePropertyName("workspaceRepositoryConfiguration"u8);
                if (WorkspaceRepositoryConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SynapseWorkspaceRepositoryConfiguration>)WorkspaceRepositoryConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PurviewConfiguration))
            {
                writer.WritePropertyName("purviewConfiguration"u8);
                if (PurviewConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurviewConfiguration>)PurviewConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                if (Encryption is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SynapseEncryptionDetails>)Encryption).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SynapseWorkspacePatch DeserializeSynapseWorkspacePatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<string> sqlAdministratorLoginPassword = default;
            Optional<SynapseManagedVirtualNetworkSettings> managedVirtualNetworkSettings = default;
            Optional<SynapseWorkspaceRepositoryConfiguration> workspaceRepositoryConfiguration = default;
            Optional<PurviewConfiguration> purviewConfiguration = default;
            Optional<string> provisioningState = default;
            Optional<SynapseEncryptionDetails> encryption = default;
            Optional<WorkspacePublicNetworkAccess> publicNetworkAccess = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sqlAdministratorLoginPassword"u8))
                        {
                            sqlAdministratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetworkSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedVirtualNetworkSettings = SynapseManagedVirtualNetworkSettings.DeserializeSynapseManagedVirtualNetworkSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceRepositoryConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceRepositoryConfiguration = SynapseWorkspaceRepositoryConfiguration.DeserializeSynapseWorkspaceRepositoryConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("purviewConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purviewConfiguration = PurviewConfiguration.DeserializePurviewConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = SynapseEncryptionDetails.DeserializeSynapseEncryptionDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new WorkspacePublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseWorkspacePatch(Optional.ToDictionary(tags), identity, sqlAdministratorLoginPassword.Value, managedVirtualNetworkSettings.Value, workspaceRepositoryConfiguration.Value, purviewConfiguration.Value, provisioningState.Value, encryption.Value, Optional.ToNullable(publicNetworkAccess), rawData);
        }

        SynapseWorkspacePatch IModelJsonSerializable<SynapseWorkspacePatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspacePatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseWorkspacePatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseWorkspacePatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspacePatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseWorkspacePatch IModelSerializable<SynapseWorkspacePatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspacePatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseWorkspacePatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseWorkspacePatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseWorkspacePatch"/> to convert. </param>
        public static implicit operator RequestContent(SynapseWorkspacePatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseWorkspacePatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseWorkspacePatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseWorkspacePatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
