// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment slot parameters.
    /// </summary>
    public partial class CsmSlotEntityInner
    {
        /// <summary>
        /// Initializes a new instance of the CsmSlotEntityInner class.
        /// </summary>
        public CsmSlotEntityInner() { }

        /// <summary>
        /// Initializes a new instance of the CsmSlotEntityInner class.
        /// </summary>
        /// <param name="targetSlot">Destination deployment slot during swap
        /// operation.</param>
        /// <param name="preserveVnet"><code>true</code> to preserve Virtual
        /// Network to the slot during swap; otherwise,
        /// <code>false</code>.</param>
        public CsmSlotEntityInner(string targetSlot, bool preserveVnet)
        {
            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
        }

        /// <summary>
        /// Gets or sets destination deployment slot during swap operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetSlot")]
        public string TargetSlot { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; to preserve Virtual
        /// Network to the slot during swap; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preserveVnet")]
        public bool PreserveVnet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetSlot == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TargetSlot");
            }
        }
    }
}
