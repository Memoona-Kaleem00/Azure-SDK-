// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> SKU for the resource. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> The SKU name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Sku(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> The SKU name. </param>
        /// <param name="tier"> The SKU tier. </param>
        /// <param name="size"> The SKU size. </param>
        /// <param name="family"> The SKU family. </param>
        /// <param name="model"> The SKU model. </param>
        /// <param name="capacity"> The SKU capacity. </param>
        internal Sku(string name, string tier, string size, string family, string model, int? capacity)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Model = model;
            Capacity = capacity;
        }

        /// <summary> The SKU name. </summary>
        public string Name { get; set; }
        /// <summary> The SKU tier. </summary>
        public string Tier { get; set; }
        /// <summary> The SKU size. </summary>
        public string Size { get; set; }
        /// <summary> The SKU family. </summary>
        public string Family { get; set; }
        /// <summary> The SKU model. </summary>
        public string Model { get; set; }
        /// <summary> The SKU capacity. </summary>
        public int? Capacity { get; set; }
    }
}
