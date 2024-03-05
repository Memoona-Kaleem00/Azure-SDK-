// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies Windows operating system settings on the virtual machine. </summary>
    public partial class WindowsConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WindowsConfiguration"/>. </summary>
        public WindowsConfiguration()
        {
            AdditionalUnattendContent = new ChangeTrackingList<AdditionalUnattendContent>();
        }

        /// <summary> Initializes a new instance of <see cref="WindowsConfiguration"/>. </summary>
        /// <param name="provisionVmAgent"> Indicates whether virtual machine agent should be provisioned on the virtual machine. When this property is not specified in the request body, it is set to true by default. This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </param>
        /// <param name="isAutomaticUpdatesEnabled"> Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is true. For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning. </param>
        /// <param name="timeZone"> Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time". Possible values can be [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time zones returned by [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones). </param>
        /// <param name="additionalUnattendContent"> Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. </param>
        /// <param name="patchSettings"> [Preview Feature] Specifies settings related to VM Guest Patching on Windows. </param>
        /// <param name="winRM"> Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell. </param>
        /// <param name="isVmAgentPlatformUpdatesEnabled"> Indicates whether VMAgent Platform Updates is enabled for the Windows virtual machine. Default value is false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WindowsConfiguration(bool? provisionVmAgent, bool? isAutomaticUpdatesEnabled, string timeZone, IList<AdditionalUnattendContent> additionalUnattendContent, PatchSettings patchSettings, WinRMConfiguration winRM, bool? isVmAgentPlatformUpdatesEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisionVmAgent = provisionVmAgent;
            IsAutomaticUpdatesEnabled = isAutomaticUpdatesEnabled;
            TimeZone = timeZone;
            AdditionalUnattendContent = additionalUnattendContent;
            PatchSettings = patchSettings;
            WinRM = winRM;
            IsVmAgentPlatformUpdatesEnabled = isVmAgentPlatformUpdatesEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether virtual machine agent should be provisioned on the virtual machine. When this property is not specified in the request body, it is set to true by default. This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </summary>
        public bool? ProvisionVmAgent { get; set; }
        /// <summary> Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is true. For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning. </summary>
        public bool? IsAutomaticUpdatesEnabled { get; set; }
        /// <summary> Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time". Possible values can be [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time zones returned by [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones). </summary>
        public string TimeZone { get; set; }
        /// <summary> Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. </summary>
        public IList<AdditionalUnattendContent> AdditionalUnattendContent { get; }
        /// <summary> [Preview Feature] Specifies settings related to VM Guest Patching on Windows. </summary>
        public PatchSettings PatchSettings { get; set; }
        /// <summary> Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell. </summary>
        internal WinRMConfiguration WinRM { get; set; }
        /// <summary> The list of Windows Remote Management listeners. </summary>
        public IList<WinRMListener> WinRMListeners
        {
            get
            {
                if (WinRM is null)
                    WinRM = new WinRMConfiguration();
                return WinRM.Listeners;
            }
        }

        /// <summary> Indicates whether VMAgent Platform Updates is enabled for the Windows virtual machine. Default value is false. </summary>
        public bool? IsVmAgentPlatformUpdatesEnabled { get; set; }
    }
}
