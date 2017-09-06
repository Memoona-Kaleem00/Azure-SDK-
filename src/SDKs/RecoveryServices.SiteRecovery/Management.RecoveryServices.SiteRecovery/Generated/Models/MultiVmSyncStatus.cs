// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MultiVmSyncStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MultiVmSyncStatus
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class MultiVmSyncStatusEnumExtension
    {
        internal static string ToSerializedValue(this MultiVmSyncStatus? value)  =>
            value == null ? null : ((MultiVmSyncStatus)value).ToSerializedValue();

        internal static string ToSerializedValue(this MultiVmSyncStatus value)
        {
            switch( value )
            {
                case MultiVmSyncStatus.Enabled:
                    return "Enabled";
                case MultiVmSyncStatus.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static MultiVmSyncStatus? ParseMultiVmSyncStatus(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return MultiVmSyncStatus.Enabled;
                case "Disabled":
                    return MultiVmSyncStatus.Disabled;
            }
            return null;
        }
    }
}
