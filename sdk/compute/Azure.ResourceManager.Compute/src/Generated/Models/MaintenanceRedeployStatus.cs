// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Maintenance Operation Status. </summary>
    public partial class MaintenanceRedeployStatus
    {
        /// <summary> Initializes a new instance of MaintenanceRedeployStatus. </summary>
        public MaintenanceRedeployStatus()
        {
        }

        /// <summary> Initializes a new instance of MaintenanceRedeployStatus. </summary>
        /// <param name="isCustomerInitiatedMaintenanceAllowed"> True, if customer is allowed to perform Maintenance. </param>
        /// <param name="preMaintenanceWindowStartTime"> Start Time for the Pre Maintenance Window. </param>
        /// <param name="preMaintenanceWindowEndTime"> End Time for the Pre Maintenance Window. </param>
        /// <param name="maintenanceWindowStartTime"> Start Time for the Maintenance Window. </param>
        /// <param name="maintenanceWindowEndTime"> End Time for the Maintenance Window. </param>
        /// <param name="lastOperationResultCode"> The Last Maintenance Operation Result Code. </param>
        /// <param name="lastOperationMessage"> Message returned for the last Maintenance Operation. </param>
        internal MaintenanceRedeployStatus(bool? isCustomerInitiatedMaintenanceAllowed, DateTimeOffset? preMaintenanceWindowStartTime, DateTimeOffset? preMaintenanceWindowEndTime, DateTimeOffset? maintenanceWindowStartTime, DateTimeOffset? maintenanceWindowEndTime, MaintenanceOperationResultCodeTypes? lastOperationResultCode, string lastOperationMessage)
        {
            IsCustomerInitiatedMaintenanceAllowed = isCustomerInitiatedMaintenanceAllowed;
            PreMaintenanceWindowStartTime = preMaintenanceWindowStartTime;
            PreMaintenanceWindowEndTime = preMaintenanceWindowEndTime;
            MaintenanceWindowStartTime = maintenanceWindowStartTime;
            MaintenanceWindowEndTime = maintenanceWindowEndTime;
            LastOperationResultCode = lastOperationResultCode;
            LastOperationMessage = lastOperationMessage;
        }

        /// <summary> True, if customer is allowed to perform Maintenance. </summary>
        public bool? IsCustomerInitiatedMaintenanceAllowed { get; set; }
        /// <summary> Start Time for the Pre Maintenance Window. </summary>
        public DateTimeOffset? PreMaintenanceWindowStartTime { get; set; }
        /// <summary> End Time for the Pre Maintenance Window. </summary>
        public DateTimeOffset? PreMaintenanceWindowEndTime { get; set; }
        /// <summary> Start Time for the Maintenance Window. </summary>
        public DateTimeOffset? MaintenanceWindowStartTime { get; set; }
        /// <summary> End Time for the Maintenance Window. </summary>
        public DateTimeOffset? MaintenanceWindowEndTime { get; set; }
        /// <summary> The Last Maintenance Operation Result Code. </summary>
        public MaintenanceOperationResultCodeTypes? LastOperationResultCode { get; set; }
        /// <summary> Message returned for the last Maintenance Operation. </summary>
        public string LastOperationMessage { get; set; }
    }
}
