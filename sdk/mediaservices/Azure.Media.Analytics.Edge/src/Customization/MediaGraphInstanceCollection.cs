﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary>
    /// Extensions methods to MediaGraphInstanceCollection to add serialization and deserialization.
    /// </summary>
    public partial class MediaGraphInstanceCollection
    {
        /// <summary>
        ///  Deserialize MediaGraphInstance.
        /// </summary>
        /// <param name="json">The json to be deserialized.</param>
        /// <returns> Deserialized Graph Instance Collection. </returns>
        public static MediaGraphInstanceCollection Deserialize(string json)
        {
            JsonElement element = JsonDocument.Parse(json).RootElement;
            return DeserializeMediaGraphInstanceCollection(element);
        }

        /// <summary>
        ///  Serialize MediaGraphInstanceCollection.
        /// </summary>
        /// <returns>
        /// Serialized Graph Instance Collection.
        /// </returns>
        public string Serialize()
        {
            return SerializeMediaGraphInstanceCollectionInternal(this);
        }

        /// <summary>
        ///  Deserialize MediaGraphInstance.
        /// </summary>
        /// <param name="serializable">The UTF8 serializer.</param>
        /// <returns> Deserialized Graph Instance Collection. </returns>
        internal static string SerializeMediaGraphInstanceCollectionInternal(IUtf8JsonSerializable serializable)
        {
            using var memoryStream = new MemoryStream();

            using (var writer = new Utf8JsonWriter(memoryStream))
            {
                serializable.Write(writer);
            }

            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }
}
