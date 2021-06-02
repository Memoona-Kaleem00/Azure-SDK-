// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Name and Type of the Resource. </summary>
    internal partial class ResourceName
    {
        /// <summary> Initializes a new instance of ResourceName. </summary>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="type"> The type of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="type"/> is null. </exception>
        internal ResourceName(string name, string type)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            Name = name;
            Type = type;
        }

        /// <summary> Name of the resource. </summary>
        public string Name { get; }
        /// <summary> The type of the resource. </summary>
        public string Type { get; }
    }
}
