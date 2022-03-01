// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery sharing profile update.
    /// </summary>
    public partial class SharingUpdate : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SharingUpdate class.
        /// </summary>
        public SharingUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharingUpdate class.
        /// </summary>
        /// <param name="operationType">This property allows you to specify the
        /// operation type of gallery sharing update. &lt;br&gt;&lt;br&gt;
        /// Possible values are: &lt;br&gt;&lt;br&gt; **Add**
        /// &lt;br&gt;&lt;br&gt; **Remove** &lt;br&gt;&lt;br&gt; **Reset**.
        /// Possible values include: 'Add', 'Remove', 'Reset',
        /// 'EnableCommunity'</param>
        /// <param name="groups">A list of sharing profile groups.</param>
        public SharingUpdate(string operationType, IList<SharingProfileGroup> groups = default(IList<SharingProfileGroup>))
        {
            OperationType = operationType;
            Groups = groups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this property allows you to specify the operation type
        /// of gallery sharing update. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// Possible values are: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Add**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Remove**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Reset**. Possible values
        /// include: 'Add', 'Remove', 'Reset', 'EnableCommunity'
        /// </summary>
        [JsonProperty(PropertyName = "operationType")]
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or sets a list of sharing profile groups.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<SharingProfileGroup> Groups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OperationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperationType");
            }
        }
    }
}
