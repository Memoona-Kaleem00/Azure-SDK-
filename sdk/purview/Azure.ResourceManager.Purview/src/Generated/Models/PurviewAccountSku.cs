// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The Sku. </summary>
    public partial class PurviewAccountSku
    {
        /// <summary> Initializes a new instance of PurviewAccountSku. </summary>
        internal PurviewAccountSku()
        {
        }

        /// <summary> Initializes a new instance of PurviewAccountSku. </summary>
        /// <param name="capacity"> Gets or sets the sku capacity. </param>
        /// <param name="name"> Gets or sets the sku name. </param>
        internal PurviewAccountSku(int? capacity, Name? name)
        {
            Capacity = capacity;
            Name = name;
        }

        /// <summary> Gets or sets the sku capacity. </summary>
        public int? Capacity { get; }
        /// <summary> Gets or sets the sku name. </summary>
        public Name? Name { get; }
    }
}
