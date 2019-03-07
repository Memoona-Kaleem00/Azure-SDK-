﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Indicates that the public properties of a model type should be serialized as camel-case in order to match
    /// the field names of an Azure Search index.
    /// </summary>
    /// <remarks>
    /// Types without this attribute are expected to have property names that exactly match their corresponding
    /// fields names in Azure Search. Otherwise, it would not be possible to use instances of the type to populate
    /// the index.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
    public class SerializePropertyNamesAsCamelCaseAttribute : Attribute
    {
        /// <summary>
        /// Indicates whether the given type is annotated with SerializePropertyNamesAsCamelCaseAttribute.
        /// </summary>
        /// <typeparam name="T">The type to test.</typeparam>
        /// <returns>true if the given type is annotated with SerializePropertyNamesAsCamelCaseAttribute,
        /// false otherwise.</returns>
        public static bool IsDefinedOnType<T>() =>
            typeof(T)
                .GetTypeInfo()
                .GetCustomAttributes(typeof(SerializePropertyNamesAsCamelCaseAttribute), inherit: true)
                .Any();
    }
}
