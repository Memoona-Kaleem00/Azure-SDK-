// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using System.Linq;

    /// <summary>
    /// The deployment status.
    /// </summary>
    public partial class AKSServiceResponseDeploymentStatus : AKSReplicaStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AKSServiceResponseDeploymentStatus class.
        /// </summary>
        public AKSServiceResponseDeploymentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AKSServiceResponseDeploymentStatus class.
        /// </summary>
        /// <param name="desiredReplicas">The desired number of
        /// replicas.</param>
        /// <param name="updatedReplicas">The number of updated
        /// replicas.</param>
        /// <param name="availableReplicas">The number of available
        /// replicas.</param>
        /// <param name="error">The error details.</param>
        public AKSServiceResponseDeploymentStatus(int? desiredReplicas = default(int?), int? updatedReplicas = default(int?), int? availableReplicas = default(int?), AKSReplicaStatusError error = default(AKSReplicaStatusError))
            : base(desiredReplicas, updatedReplicas, availableReplicas, error)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
