﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.TypeSpec
{
    internal class NotNullWhenAttribute : Attribute
    {
        public NotNullWhenAttribute(bool v)
        {
            V = v;
        }

        public bool V { get; }
    }
}