// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class ListHandlesResponse : IXmlSerializable, IModelSerializable<ListHandlesResponse>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "EnumerationResults");
            writer.WriteStartElement("NextMarker");
            writer.WriteValue(NextMarker);
            writer.WriteEndElement();
            if (Optional.IsCollectionDefined(HandleList))
            {
                writer.WriteStartElement("Entries");
                foreach (var item in HandleList)
                {
                    writer.WriteObjectValue(item, "Handle");
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static ListHandlesResponse DeserializeListHandlesResponse(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string nextMarker = default;
            IReadOnlyList<HandleItem> handleList = default;
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            if (element.Element("Entries") is XElement entriesElement)
            {
                var array = new List<HandleItem>();
                foreach (var e in entriesElement.Elements("Handle"))
                {
                    array.Add(HandleItem.DeserializeHandleItem(e));
                }
                handleList = array;
            }
            return new ListHandlesResponse(handleList, nextMarker, default);
        }

        BinaryData IModelSerializable<ListHandlesResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListHandlesResponse>(this, options.Format);

            options ??= ModelSerializerOptions.DefaultWireOptions;
            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            Serialize(writer, null, options);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        ListHandlesResponse IModelSerializable<ListHandlesResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListHandlesResponse>(this, options.Format);

            return DeserializeListHandlesResponse(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="ListHandlesResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListHandlesResponse"/> to convert. </param>
        public static implicit operator RequestContent(ListHandlesResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListHandlesResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListHandlesResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeListHandlesResponse(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
