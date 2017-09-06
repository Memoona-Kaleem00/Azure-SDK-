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
    /// Defines values for HealthErrorCategory.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HealthErrorCategory
    {
        [EnumMember(Value = "Replication")]
        Replication,
        [EnumMember(Value = "TestFailover")]
        TestFailover,
        [EnumMember(Value = "Configuration")]
        Configuration
    }
    internal static class HealthErrorCategoryEnumExtension
    {
        internal static string ToSerializedValue(this HealthErrorCategory? value)  =>
            value == null ? null : ((HealthErrorCategory)value).ToSerializedValue();

        internal static string ToSerializedValue(this HealthErrorCategory value)
        {
            switch( value )
            {
                case HealthErrorCategory.Replication:
                    return "Replication";
                case HealthErrorCategory.TestFailover:
                    return "TestFailover";
                case HealthErrorCategory.Configuration:
                    return "Configuration";
            }
            return null;
        }

        internal static HealthErrorCategory? ParseHealthErrorCategory(this string value)
        {
            switch( value )
            {
                case "Replication":
                    return HealthErrorCategory.Replication;
                case "TestFailover":
                    return HealthErrorCategory.TestFailover;
                case "Configuration":
                    return HealthErrorCategory.Configuration;
            }
            return null;
        }
    }
}
