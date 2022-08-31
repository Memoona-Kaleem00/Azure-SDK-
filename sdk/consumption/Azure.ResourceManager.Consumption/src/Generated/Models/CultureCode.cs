// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Language in which the recipient will receive the notification. </summary>
    public readonly partial struct CultureCode : IEquatable<CultureCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CultureCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CultureCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnUsValue = "en-us";
        private const string JaJpValue = "ja-jp";
        private const string ZhCnValue = "zh-cn";
        private const string DeDeValue = "de-de";
        private const string EsEsValue = "es-es";
        private const string FrFrValue = "fr-fr";
        private const string ItItValue = "it-it";
        private const string KoKrValue = "ko-kr";
        private const string PtBrValue = "pt-br";
        private const string RuRuValue = "ru-ru";
        private const string ZhTwValue = "zh-tw";
        private const string CsCzValue = "cs-cz";
        private const string PlPlValue = "pl-pl";
        private const string TrTrValue = "tr-tr";
        private const string DaDkValue = "da-dk";
        private const string EnGbValue = "en-gb";
        private const string HuHuValue = "hu-hu";
        private const string NbNoValue = "nb-no";
        private const string NlNlValue = "nl-nl";
        private const string PtPtValue = "pt-pt";
        private const string SvSeValue = "sv-se";

        /// <summary> en-us. </summary>
        public static CultureCode EnUs { get; } = new CultureCode(EnUsValue);
        /// <summary> ja-jp. </summary>
        public static CultureCode JaJp { get; } = new CultureCode(JaJpValue);
        /// <summary> zh-cn. </summary>
        public static CultureCode ZhCn { get; } = new CultureCode(ZhCnValue);
        /// <summary> de-de. </summary>
        public static CultureCode DeDe { get; } = new CultureCode(DeDeValue);
        /// <summary> es-es. </summary>
        public static CultureCode EsEs { get; } = new CultureCode(EsEsValue);
        /// <summary> fr-fr. </summary>
        public static CultureCode FrFr { get; } = new CultureCode(FrFrValue);
        /// <summary> it-it. </summary>
        public static CultureCode ItIt { get; } = new CultureCode(ItItValue);
        /// <summary> ko-kr. </summary>
        public static CultureCode KoKr { get; } = new CultureCode(KoKrValue);
        /// <summary> pt-br. </summary>
        public static CultureCode PtBr { get; } = new CultureCode(PtBrValue);
        /// <summary> ru-ru. </summary>
        public static CultureCode RuRu { get; } = new CultureCode(RuRuValue);
        /// <summary> zh-tw. </summary>
        public static CultureCode ZhTw { get; } = new CultureCode(ZhTwValue);
        /// <summary> cs-cz. </summary>
        public static CultureCode CsCz { get; } = new CultureCode(CsCzValue);
        /// <summary> pl-pl. </summary>
        public static CultureCode PlPl { get; } = new CultureCode(PlPlValue);
        /// <summary> tr-tr. </summary>
        public static CultureCode TrTr { get; } = new CultureCode(TrTrValue);
        /// <summary> da-dk. </summary>
        public static CultureCode DaDk { get; } = new CultureCode(DaDkValue);
        /// <summary> en-gb. </summary>
        public static CultureCode EnGb { get; } = new CultureCode(EnGbValue);
        /// <summary> hu-hu. </summary>
        public static CultureCode HuHu { get; } = new CultureCode(HuHuValue);
        /// <summary> nb-no. </summary>
        public static CultureCode NbNo { get; } = new CultureCode(NbNoValue);
        /// <summary> nl-nl. </summary>
        public static CultureCode NlNl { get; } = new CultureCode(NlNlValue);
        /// <summary> pt-pt. </summary>
        public static CultureCode PtPt { get; } = new CultureCode(PtPtValue);
        /// <summary> sv-se. </summary>
        public static CultureCode SvSe { get; } = new CultureCode(SvSeValue);
        /// <summary> Determines if two <see cref="CultureCode"/> values are the same. </summary>
        public static bool operator ==(CultureCode left, CultureCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CultureCode"/> values are not the same. </summary>
        public static bool operator !=(CultureCode left, CultureCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CultureCode"/>. </summary>
        public static implicit operator CultureCode(string value) => new CultureCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CultureCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CultureCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
