// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for OcrSkillLanguage.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(OcrSkillLanguageConverter))]
    public struct OcrSkillLanguage : System.IEquatable<OcrSkillLanguage>
    {
        private OcrSkillLanguage(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Chinese-Simplified
        /// </summary>
        public static readonly OcrSkillLanguage ZhHans = "zh-Hans";

        /// <summary>
        /// Chinese-Traditional
        /// </summary>
        public static readonly OcrSkillLanguage ZhHant = "zh-Hant";

        /// <summary>
        /// Czech
        /// </summary>
        public static readonly OcrSkillLanguage Cs = "cs";

        /// <summary>
        /// Danish
        /// </summary>
        public static readonly OcrSkillLanguage Da = "da";

        /// <summary>
        /// Dutch
        /// </summary>
        public static readonly OcrSkillLanguage Nl = "nl";

        /// <summary>
        /// English
        /// </summary>
        public static readonly OcrSkillLanguage En = "en";

        /// <summary>
        /// Finnish
        /// </summary>
        public static readonly OcrSkillLanguage Fi = "fi";

        /// <summary>
        /// French
        /// </summary>
        public static readonly OcrSkillLanguage Fr = "fr";

        /// <summary>
        /// German
        /// </summary>
        public static readonly OcrSkillLanguage De = "de";

        /// <summary>
        /// Greek
        /// </summary>
        public static readonly OcrSkillLanguage El = "el";

        /// <summary>
        /// Hungarian
        /// </summary>
        public static readonly OcrSkillLanguage Hu = "hu";

        /// <summary>
        /// Italian
        /// </summary>
        public static readonly OcrSkillLanguage It = "it";

        /// <summary>
        /// Japanese
        /// </summary>
        public static readonly OcrSkillLanguage Ja = "ja";

        /// <summary>
        /// Korean
        /// </summary>
        public static readonly OcrSkillLanguage Ko = "ko";

        /// <summary>
        /// Norwegian (Bokmål)
        /// </summary>
        public static readonly OcrSkillLanguage Nb = "nb";

        /// <summary>
        /// Polish
        /// </summary>
        public static readonly OcrSkillLanguage Pl = "pl";

        /// <summary>
        /// Portuguese
        /// </summary>
        public static readonly OcrSkillLanguage Pt = "pt";

        /// <summary>
        /// Russian
        /// </summary>
        public static readonly OcrSkillLanguage Ru = "ru";

        /// <summary>
        /// Spanish
        /// </summary>
        public static readonly OcrSkillLanguage Es = "es";

        /// <summary>
        /// Swedish
        /// </summary>
        public static readonly OcrSkillLanguage Sv = "sv";

        /// <summary>
        /// Turkish
        /// </summary>
        public static readonly OcrSkillLanguage Tr = "tr";

        /// <summary>
        /// Arabic
        /// </summary>
        public static readonly OcrSkillLanguage Ar = "ar";

        /// <summary>
        /// Romanian
        /// </summary>
        public static readonly OcrSkillLanguage Ro = "ro";

        /// <summary>
        /// Serbian (Cyrillic, Serbia)
        /// </summary>
        public static readonly OcrSkillLanguage SrCyrl = "sr-Cyrl";

        /// <summary>
        /// Serbian (Latin, Serbia)
        /// </summary>
        public static readonly OcrSkillLanguage SrLatn = "sr-Latn";

        /// <summary>
        /// Slovak
        /// </summary>
        public static readonly OcrSkillLanguage Sk = "sk";


        /// <summary>
        /// Underlying value of enum OcrSkillLanguage
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for OcrSkillLanguage
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type OcrSkillLanguage
        /// </summary>
        public bool Equals(OcrSkillLanguage e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to OcrSkillLanguage
        /// </summary>
        public static implicit operator OcrSkillLanguage(string value)
        {
            return new OcrSkillLanguage(value);
        }

        /// <summary>
        /// Implicit operator to convert OcrSkillLanguage to string
        /// </summary>
        public static implicit operator string(OcrSkillLanguage e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum OcrSkillLanguage
        /// </summary>
        public static bool operator == (OcrSkillLanguage e1, OcrSkillLanguage e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum OcrSkillLanguage
        /// </summary>
        public static bool operator != (OcrSkillLanguage e1, OcrSkillLanguage e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for OcrSkillLanguage
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is OcrSkillLanguage && Equals((OcrSkillLanguage)obj);
        }

        /// <summary>
        /// Returns for hashCode OcrSkillLanguage
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
