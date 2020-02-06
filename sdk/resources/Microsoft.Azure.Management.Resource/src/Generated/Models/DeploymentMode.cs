// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeploymentMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeploymentMode
    {
        [EnumMember(Value = "Incremental")]
        Incremental,
        [EnumMember(Value = "Complete")]
        Complete
    }
    internal static class DeploymentModeEnumExtension
    {
        internal static string ToSerializedValue(this DeploymentMode? value)
        {
            return value == null ? null : ((DeploymentMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DeploymentMode value)
        {
            switch( value )
            {
                case DeploymentMode.Incremental:
                    return "Incremental";
                case DeploymentMode.Complete:
                    return "Complete";
            }
            return null;
        }

        internal static DeploymentMode? ParseDeploymentMode(this string value)
        {
            switch( value )
            {
                case "Incremental":
                    return DeploymentMode.Incremental;
                case "Complete":
                    return DeploymentMode.Complete;
            }
            return null;
        }
    }
}
