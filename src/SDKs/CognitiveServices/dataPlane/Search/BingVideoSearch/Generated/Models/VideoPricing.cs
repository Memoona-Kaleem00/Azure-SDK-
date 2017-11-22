// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.VideoSearch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VideoPricing.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoPricing
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Free")]
        Free,
        [EnumMember(Value = "Paid")]
        Paid
    }
    internal static class VideoPricingEnumExtension
    {
        internal static string ToSerializedValue(this VideoPricing? value)
        {
            return value == null ? null : ((VideoPricing)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VideoPricing value)
        {
            switch( value )
            {
                case VideoPricing.All:
                    return "All";
                case VideoPricing.Free:
                    return "Free";
                case VideoPricing.Paid:
                    return "Paid";
            }
            return null;
        }

        internal static VideoPricing? ParseVideoPricing(this string value)
        {
            switch( value )
            {
                case "All":
                    return VideoPricing.All;
                case "Free":
                    return VideoPricing.Free;
                case "Paid":
                    return VideoPricing.Paid;
            }
            return null;
        }
    }
}
