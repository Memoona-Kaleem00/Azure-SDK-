// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class ListHandlesResponse : IXmlSerializable, IPersistableModel<ListHandlesResponse>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
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

        internal static ListHandlesResponse DeserializeListHandlesResponse(XElement element, ModelReaderWriterOptions options = null)
        {
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

        BinaryData IPersistableModel<ListHandlesResponse>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<ListHandlesResponse>;
            bool isValid = options.Format == "J" && implementsJson || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            ((IXmlSerializable)this).Write(writer, null);
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

        ListHandlesResponse IPersistableModel<ListHandlesResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ListHandlesResponse)} does not support '{options.Format}' format.");
            }

            return DeserializeListHandlesResponse(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<ListHandlesResponse>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
