// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters of a script block.
    /// </summary>
    public partial class ScriptActivityParameter
    {
        /// <summary>
        /// Initializes a new instance of the ScriptActivityParameter class.
        /// </summary>
        public ScriptActivityParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptActivityParameter class.
        /// </summary>
        /// <param name="name">The name of the parameter. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="type">The type of the parameter. Possible values
        /// include: 'Boolean', 'DateTime', 'DateTimeOffset', 'Decimal',
        /// 'Double', 'Guid', 'Int16', 'Int32', 'Int64', 'Single', 'String',
        /// 'Timespan'</param>
        /// <param name="value">The value of the parameter.</param>
        /// <param name="direction">The direction of the parameter. Possible
        /// values include: 'Input', 'Output', 'InputOutput'</param>
        /// <param name="size">The size of the output direction
        /// parameter.</param>
        public ScriptActivityParameter(object name = default(object), string type = default(string), object value = default(object), string direction = default(string), int? size = default(int?))
        {
            Name = name;
            Type = type;
            Value = value;
            Direction = direction;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the parameter. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public object Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the parameter. Possible values include:
        /// 'Boolean', 'DateTime', 'DateTimeOffset', 'Decimal', 'Double',
        /// 'Guid', 'Int16', 'Int32', 'Int64', 'Single', 'String', 'Timespan'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the value of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the direction of the parameter. Possible values
        /// include: 'Input', 'Output', 'InputOutput'
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the size of the output direction parameter.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

    }
}
