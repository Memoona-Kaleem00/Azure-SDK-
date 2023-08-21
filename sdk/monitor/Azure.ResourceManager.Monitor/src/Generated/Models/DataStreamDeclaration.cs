// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Declaration of a custom stream. </summary>
    public partial class DataStreamDeclaration
    {
        /// <summary> Initializes a new instance of DataStreamDeclaration. </summary>
        public DataStreamDeclaration()
        {
            Columns = new Core.ChangeTrackingList<DataColumnDefinition>();
        }

        /// <summary> Initializes a new instance of DataStreamDeclaration. </summary>
        /// <param name="columns"> List of columns used by data in this stream. </param>
        internal DataStreamDeclaration(IList<DataColumnDefinition> columns)
        {
            Columns = columns;
        }

        /// <summary> List of columns used by data in this stream. </summary>
        public IList<DataColumnDefinition> Columns { get; }
    }
}
