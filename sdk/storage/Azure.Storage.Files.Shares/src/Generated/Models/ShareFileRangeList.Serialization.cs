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
    internal partial class ShareFileRangeList : IXmlSerializable, IModelSerializable<ShareFileRangeList>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Ranges");
            if (Optional.IsCollectionDefined(Ranges))
            {
                foreach (var item in Ranges)
                {
                    writer.WriteObjectValue(item, "Range");
                }
            }
            if (Optional.IsCollectionDefined(ClearRanges))
            {
                foreach (var item in ClearRanges)
                {
                    writer.WriteObjectValue(item, "ClearRange");
                }
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static ShareFileRangeList DeserializeShareFileRangeList(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            IReadOnlyList<FileRange> ranges = default;
            IReadOnlyList<ClearRange> clearRanges = default;
            var array = new List<FileRange>();
            foreach (var e in element.Elements("Range"))
            {
                array.Add(FileRange.DeserializeFileRange(e));
            }
            ranges = array;
            var array0 = new List<ClearRange>();
            foreach (var e in element.Elements("ClearRange"))
            {
                array0.Add(ClearRange.DeserializeClearRange(e));
            }
            clearRanges = array0;
            return new ShareFileRangeList(ranges, clearRanges, default);
        }

        BinaryData IModelSerializable<ShareFileRangeList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareFileRangeList>(this, options.Format);

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

        ShareFileRangeList IModelSerializable<ShareFileRangeList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareFileRangeList>(this, options.Format);

            return DeserializeShareFileRangeList(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="ShareFileRangeList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ShareFileRangeList"/> to convert. </param>
        public static implicit operator RequestContent(ShareFileRangeList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ShareFileRangeList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ShareFileRangeList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeShareFileRangeList(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
