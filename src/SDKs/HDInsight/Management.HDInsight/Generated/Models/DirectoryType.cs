// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DirectoryType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectoryType
    {
        [EnumMember(Value = "ActiveDirectory")]
        ActiveDirectory
    }
    internal static class DirectoryTypeEnumExtension
    {
        internal static string ToSerializedValue(this DirectoryType? value)
        {
            return value == null ? null : ((DirectoryType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DirectoryType value)
        {
            switch( value )
            {
                case DirectoryType.ActiveDirectory:
                    return "ActiveDirectory";
            }
            return null;
        }

        internal static DirectoryType? ParseDirectoryType(this string value)
        {
            switch( value )
            {
                case "ActiveDirectory":
                    return DirectoryType.ActiveDirectory;
            }
            return null;
        }
    }
}
