// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GoogleBigQueryLinkedServiceConverter))]
    public partial class GoogleBigQueryLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, ParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<object> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("project"u8);
            writer.WriteObjectValue(Project);
            if (AdditionalProjects != null)
            {
                writer.WritePropertyName("additionalProjects"u8);
                writer.WriteObjectValue(AdditionalProjects);
            }
            if (RequestGoogleDriveScope != null)
            {
                writer.WritePropertyName("requestGoogleDriveScope"u8);
                writer.WriteObjectValue(RequestGoogleDriveScope);
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            if (RefreshToken != null)
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteObjectValue(RefreshToken);
            }
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteObjectValue(ClientId);
            }
            if (ClientSecret != null)
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteObjectValue(ClientSecret);
            }
            if (Email != null)
            {
                writer.WritePropertyName("email"u8);
                writer.WriteObjectValue(Email);
            }
            if (KeyFilePath != null)
            {
                writer.WritePropertyName("keyFilePath"u8);
                writer.WriteObjectValue(KeyFilePath);
            }
            if (TrustedCertPath != null)
            {
                writer.WritePropertyName("trustedCertPath"u8);
                writer.WriteObjectValue(TrustedCertPath);
            }
            if (UseSystemTrustStore != null)
            {
                writer.WritePropertyName("useSystemTrustStore"u8);
                writer.WriteObjectValue(UseSystemTrustStore);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static GoogleBigQueryLinkedService DeserializeGoogleBigQueryLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object project = default;
            object additionalProjects = default;
            object requestGoogleDriveScope = default;
            GoogleBigQueryAuthenticationType authenticationType = default;
            SecretBase refreshToken = default;
            object clientId = default;
            SecretBase clientSecret = default;
            object email = default;
            object keyFilePath = default;
            object trustedCertPath = default;
            object useSystemTrustStore = default;
            object encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("project"u8))
                        {
                            project = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("additionalProjects"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalProjects = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("requestGoogleDriveScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestGoogleDriveScope = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            authenticationType = new GoogleBigQueryAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("refreshToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshToken = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecret = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            email = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("keyFilePath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyFilePath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedCertPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useSystemTrustStore = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GoogleBigQueryLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
                additionalProperties,
                project,
                additionalProjects,
                requestGoogleDriveScope,
                authenticationType,
                refreshToken,
                clientId,
                clientSecret,
                email,
                keyFilePath,
                trustedCertPath,
                useSystemTrustStore,
                encryptedCredential);
        }

        internal partial class GoogleBigQueryLinkedServiceConverter : JsonConverter<GoogleBigQueryLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, GoogleBigQueryLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GoogleBigQueryLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGoogleBigQueryLinkedService(document.RootElement);
            }
        }
    }
}
