// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestWrapper
    {
        internal static ManifestWrapper DeserializeManifestWrapper(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            IReadOnlyList<ManifestListAttributes> manifests = default;
            Optional<OciDescriptor> config = default;
            IReadOnlyList<OciDescriptor> layers = default;
            Optional<OciAnnotations> annotations = default;
            Optional<string> architecture = default;
            Optional<string> name = default;
            Optional<string> tag = default;
            IReadOnlyList<FsLayer> fsLayers = default;
            IReadOnlyList<History> history = default;
            IReadOnlyList<ImageSignature> signatures = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManifestListAttributes> array = new List<ManifestListAttributes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestListAttributes.DeserializeManifestListAttributes(item));
                    }
                    manifests = array;
                    continue;
                }
                if (property.NameEquals("config"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    config = OciDescriptor.DeserializeOciDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OciDescriptor> array = new List<OciDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OciDescriptor.DeserializeOciDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = OciAnnotations.DeserializeOciAnnotations(property.Value);
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fsLayers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FsLayer> array = new List<FsLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FsLayer.DeserializeFsLayer(item));
                    }
                    fsLayers = array;
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<History> array = new List<History>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistry.History.DeserializeHistory(item));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("signatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImageSignature> array = new List<ImageSignature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageSignature.DeserializeImageSignature(item));
                    }
                    signatures = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new ManifestWrapper(Optional.ToNullable(schemaVersion), mediaType.Value, manifests ?? new ChangeTrackingList<ManifestListAttributes>(), config.Value, layers ?? new ChangeTrackingList<OciDescriptor>(), annotations.Value, architecture.Value, name.Value, tag.Value, fsLayers ?? new ChangeTrackingList<FsLayer>(), history ?? new ChangeTrackingList<History>(), signatures ?? new ChangeTrackingList<ImageSignature>());
        }
    }
}
