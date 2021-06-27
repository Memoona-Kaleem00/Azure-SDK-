// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Guest configuration assignment properties.
    /// </summary>
    public partial class GuestConfigurationAssignmentProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GuestConfigurationAssignmentProperties class.
        /// </summary>
        public GuestConfigurationAssignmentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GuestConfigurationAssignmentProperties class.
        /// </summary>
        /// <param name="targetResourceId">VM resource Id.</param>
        /// <param name="guestConfiguration">The guest configuration to
        /// assign.</param>
        /// <param name="complianceStatus">A value indicating compliance status
        /// of the machine for the assigned guest configuration. Possible
        /// values include: 'Compliant', 'NonCompliant', 'Pending'</param>
        /// <param name="lastComplianceStatusChecked">Date and time when last
        /// compliance status was checked.</param>
        /// <param name="latestReportId">Id of the latest report for the guest
        /// configuration assignment. </param>
        /// <param name="latestAssignmentReport">Last reported guest
        /// configuration assignment report.</param>
        /// <param name="context">The source which initiated the guest
        /// configuration assignment. Ex: Azure Policy</param>
        /// <param name="assignmentHash">Combined hash of the configuration
        /// package and parameters.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response. Possible values include: 'Succeeded',
        /// 'Failed', 'Canceled', 'Created'</param>
        /// <param name="resourceType">Type of the resource - VMSS / VM</param>
        /// <param name="vmssVMList">The list of VM Compliance data for
        /// VMSS</param>
        public GuestConfigurationAssignmentProperties(string targetResourceId = default(string), GuestConfigurationNavigation guestConfiguration = default(GuestConfigurationNavigation), string complianceStatus = default(string), System.DateTime? lastComplianceStatusChecked = default(System.DateTime?), string latestReportId = default(string), AssignmentReport latestAssignmentReport = default(AssignmentReport), string context = default(string), string assignmentHash = default(string), string provisioningState = default(string), string resourceType = default(string), IList<VMSSVMInfo> vmssVMList = default(IList<VMSSVMInfo>))
        {
            TargetResourceId = targetResourceId;
            GuestConfiguration = guestConfiguration;
            ComplianceStatus = complianceStatus;
            LastComplianceStatusChecked = lastComplianceStatusChecked;
            LatestReportId = latestReportId;
            LatestAssignmentReport = latestAssignmentReport;
            Context = context;
            AssignmentHash = assignmentHash;
            ProvisioningState = provisioningState;
            ResourceType = resourceType;
            VmssVMList = vmssVMList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets VM resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; private set; }

        /// <summary>
        /// Gets or sets the guest configuration to assign.
        /// </summary>
        [JsonProperty(PropertyName = "guestConfiguration")]
        public GuestConfigurationNavigation GuestConfiguration { get; set; }

        /// <summary>
        /// Gets a value indicating compliance status of the machine for the
        /// assigned guest configuration. Possible values include: 'Compliant',
        /// 'NonCompliant', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "complianceStatus")]
        public string ComplianceStatus { get; private set; }

        /// <summary>
        /// Gets date and time when last compliance status was checked.
        /// </summary>
        [JsonProperty(PropertyName = "lastComplianceStatusChecked")]
        public System.DateTime? LastComplianceStatusChecked { get; private set; }

        /// <summary>
        /// Gets id of the latest report for the guest configuration
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "latestReportId")]
        public string LatestReportId { get; private set; }

        /// <summary>
        /// Gets or sets last reported guest configuration assignment report.
        /// </summary>
        [JsonProperty(PropertyName = "latestAssignmentReport")]
        public AssignmentReport LatestAssignmentReport { get; set; }

        /// <summary>
        /// Gets or sets the source which initiated the guest configuration
        /// assignment. Ex: Azure Policy
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets combined hash of the configuration package and parameters.
        /// </summary>
        [JsonProperty(PropertyName = "assignmentHash")]
        public string AssignmentHash { get; private set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// Possible values include: 'Succeeded', 'Failed', 'Canceled',
        /// 'Created'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets type of the resource - VMSS / VM
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets or sets the list of VM Compliance data for VMSS
        /// </summary>
        [JsonProperty(PropertyName = "vmssVMList")]
        public IList<VMSSVMInfo> VmssVMList { get; set; }

    }
}
