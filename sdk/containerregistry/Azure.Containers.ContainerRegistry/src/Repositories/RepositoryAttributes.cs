﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    public partial class RepositoryAttributes
    {
        // TODO: why are these nullable?  We should figure out how to make then not nullable
        // TODO: Should these be settable?

        [CodeGenMember("DeleteEnabled")]
        public bool? CanDelete { get; set; }

        [CodeGenMember("WriteEnabled")]
        public bool? CanWrite { get; set; }

        [CodeGenMember("ListEnabled")]
        public bool? CanList { get; set; }

        [CodeGenMember("ReadEnabled")]
        public bool? CanRead { get; set; }
    }
}
