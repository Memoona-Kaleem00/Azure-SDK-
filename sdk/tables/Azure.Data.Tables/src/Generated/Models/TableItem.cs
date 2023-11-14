// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Data.Tables.Models
{
    /// <summary> The properties for the table response. </summary>
    public partial class TableItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TableItem"/>. </summary>
        internal TableItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TableItem"/>. </summary>
        /// <param name="name"> The name of the table. </param>
        /// <param name="odataType"> The odata type of the table. </param>
        /// <param name="odataId"> The id of the table. </param>
        /// <param name="odataEditLink"> The edit link of the table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TableItem(string name, string odataType, string odataId, string odataEditLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            OdataType = odataType;
            OdataId = odataId;
            OdataEditLink = odataEditLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
