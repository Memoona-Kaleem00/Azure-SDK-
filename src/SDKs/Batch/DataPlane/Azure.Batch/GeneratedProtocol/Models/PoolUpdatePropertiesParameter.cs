// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The set of changes to be made to a pool.
    /// </summary>
    public partial class PoolUpdatePropertiesParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolUpdatePropertiesParameter
        /// class.
        /// </summary>
        public PoolUpdatePropertiesParameter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolUpdatePropertiesParameter
        /// class.
        /// </summary>
        /// <param name="certificateReferences">A list of certificates to be
        /// installed on each compute node in the pool.</param>
        /// <param name="applicationPackageReferences">A list of application
        /// packages to be installed on each compute node in the pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the pool as metadata.</param>
        /// <param name="startTask">A task to run on each compute node as it
        /// joins the pool. The task runs when the node is added to the pool or
        /// when the node is restarted.</param>
        public PoolUpdatePropertiesParameter(IList<CertificateReference> certificateReferences, IList<ApplicationPackageReference> applicationPackageReferences, IList<MetadataItem> metadata, StartTask startTask = default(StartTask))
        {
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a task to run on each compute node as it joins the
        /// pool. The task runs when the node is added to the pool or when the
        /// node is restarted.
        /// </summary>
        /// <remarks>
        /// If this element is present, it overwrites any existing start task.
        /// If omitted, any existing start task is removed from the pool.
        /// </remarks>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets a list of certificates to be installed on each compute
        /// node in the pool.
        /// </summary>
        /// <remarks>
        /// This list replaces any existing certificate references configured
        /// on the pool. If you specify an empty collection, any existing
        /// certificate references are removed from the pool. For Windows
        /// compute nodes, the Batch service installs the certificates to the
        /// specified certificate store and location. For Linux compute nodes,
        /// the certificates are stored in a directory inside the task working
        /// directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is
        /// supplied to the task to query for this location. For certificates
        /// with visibility of 'remoteUser', a 'certs' directory is created in
        /// the user's home directory (e.g., /home/{user-name}/certs) and
        /// certificates are placed in that directory.
        /// </remarks>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages to be installed on each
        /// compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The list replaces any existing application package references on
        /// the pool. Changes to application package references affect all new
        /// compute nodes joining the pool, but do not affect compute nodes
        /// that are already in the pool until they are rebooted or reimaged.
        /// If omitted, or if you specify an empty collection, any existing
        /// application packages references are removed from the pool.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// This list replaces any existing metadata configured on the pool. If
        /// omitted, or if you specify an empty collection, any existing
        /// metadata is removed from the pool.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CertificateReferences == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CertificateReferences");
            }
            if (ApplicationPackageReferences == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplicationPackageReferences");
            }
            if (Metadata == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Metadata");
            }
            if (StartTask != null)
            {
                StartTask.Validate();
            }
            if (CertificateReferences != null)
            {
                foreach (var element in CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ApplicationPackageReferences != null)
            {
                foreach (var element1 in ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Metadata != null)
            {
                foreach (var element2 in Metadata)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
