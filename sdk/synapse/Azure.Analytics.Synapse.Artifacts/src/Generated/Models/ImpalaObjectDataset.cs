// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Impala server dataset. </summary>
    public partial class ImpalaObjectDataset : Dataset
    {
        /// <summary> Initializes a new instance of ImpalaObjectDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        public ImpalaObjectDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "ImpalaObject";
        }

        /// <summary> Initializes a new instance of ImpalaObjectDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="tableName"> This property will be retired. Please consider using schema + table properties instead. </param>
        /// <param name="table"> The table name of the Impala. Type: string (or Expression with resultType string). </param>
        /// <param name="schemaTypePropertiesSchema"> The schema name of the Impala. Type: string (or Expression with resultType string). </param>
        internal ImpalaObjectDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object tableName, object table, object schemaTypePropertiesSchema) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            TableName = tableName;
            Table = table;
            SchemaTypePropertiesSchema = schemaTypePropertiesSchema;
            Type = type ?? "ImpalaObject";
        }

        /// <summary> This property will be retired. Please consider using schema + table properties instead. </summary>
        public object TableName { get; set; }
        /// <summary> The table name of the Impala. Type: string (or Expression with resultType string). </summary>
        public object Table { get; set; }
        /// <summary> The schema name of the Impala. Type: string (or Expression with resultType string). </summary>
        public object SchemaTypePropertiesSchema { get; set; }
    }
}
