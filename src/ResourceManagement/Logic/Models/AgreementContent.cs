// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account agreement content.
    /// </summary>
    public partial class AgreementContent
    {
        /// <summary>
        /// Initializes a new instance of the AgreementContent class.
        /// </summary>
        public AgreementContent()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgreementContent class.
        /// </summary>
        /// <param name="aS2">The AS2 agreement content.</param>
        /// <param name="x12">The X12 agreement content.</param>
        /// <param name="edifact">The EDIFACT agreement content.</param>
        public AgreementContent(AS2AgreementContent aS2 = default(AS2AgreementContent), X12AgreementContent x12 = default(X12AgreementContent), EdifactAgreementContent edifact = default(EdifactAgreementContent))
        {
            AS2 = aS2;
            X12 = x12;
            Edifact = edifact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the AS2 agreement content.
        /// </summary>
        [JsonProperty(PropertyName = "aS2")]
        public AS2AgreementContent AS2 { get; set; }

        /// <summary>
        /// Gets or sets the X12 agreement content.
        /// </summary>
        [JsonProperty(PropertyName = "x12")]
        public X12AgreementContent X12 { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT agreement content.
        /// </summary>
        [JsonProperty(PropertyName = "edifact")]
        public EdifactAgreementContent Edifact { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AS2 != null)
            {
                AS2.Validate();
            }
            if (X12 != null)
            {
                X12.Validate();
            }
            if (Edifact != null)
            {
                Edifact.Validate();
            }
        }
    }
}
