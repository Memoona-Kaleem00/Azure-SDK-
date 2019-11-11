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
    /// Defines values for TokenFilterName.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(TokenFilterNameConverter))]
    public struct TokenFilterName : System.IEquatable<TokenFilterName>
    {
        private TokenFilterName(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// A token filter that applies the Arabic normalizer to normalize the
        /// orthography. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ar/ArabicNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName ArabicNormalization = "arabic_normalization";

        /// <summary>
        /// Strips all characters after an apostrophe (including the apostrophe
        /// itself). See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/tr/ApostropheFilter.html
        /// </summary>
        public static readonly TokenFilterName Apostrophe = "apostrophe";

        /// <summary>
        /// Converts alphabetic, numeric, and symbolic Unicode characters which
        /// are not in the first 127 ASCII characters (the "Basic Latin"
        /// Unicode block) into their ASCII equivalents, if such equivalents
        /// exist. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/ASCIIFoldingFilter.html
        /// </summary>
        public static readonly TokenFilterName AsciiFolding = "asciifolding";

        /// <summary>
        /// Forms bigrams of CJK terms that are generated from
        /// StandardTokenizer. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/cjk/CJKBigramFilter.html
        /// </summary>
        public static readonly TokenFilterName CjkBigram = "cjk_bigram";

        /// <summary>
        /// Normalizes CJK width differences. Folds fullwidth ASCII variants
        /// into the equivalent basic Latin, and half-width Katakana variants
        /// into the equivalent Kana. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/cjk/CJKWidthFilter.html
        /// </summary>
        public static readonly TokenFilterName CjkWidth = "cjk_width";

        /// <summary>
        /// Removes English possessives, and dots from acronyms. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/standard/ClassicFilter.html
        /// </summary>
        public static readonly TokenFilterName Classic = "classic";

        /// <summary>
        /// Construct bigrams for frequently occurring terms while indexing.
        /// Single terms are still indexed too, with bigrams overlaid. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/commongrams/CommonGramsFilter.html
        /// </summary>
        public static readonly TokenFilterName CommonGram = "common_grams";

        /// <summary>
        /// Generates n-grams of the given size(s) starting from the front or
        /// the back of an input token. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ngram/EdgeNGramTokenFilter.html
        /// </summary>
        public static readonly TokenFilterName EdgeNGram = "edgeNGram_v2";

        /// <summary>
        /// Removes elisions. For example, "l'avion" (the plane) will be
        /// converted to "avion" (plane). See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/util/ElisionFilter.html
        /// </summary>
        public static readonly TokenFilterName Elision = "elision";

        /// <summary>
        /// Normalizes German characters according to the heuristics of the
        /// German2 snowball algorithm. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/de/GermanNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName GermanNormalization = "german_normalization";

        /// <summary>
        /// Normalizes text in Hindi to remove some differences in spelling
        /// variations. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/hi/HindiNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName HindiNormalization = "hindi_normalization";

        /// <summary>
        /// Normalizes the Unicode representation of text in Indian languages.
        /// See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/in/IndicNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName IndicNormalization = "indic_normalization";

        /// <summary>
        /// KeywordRepeat
        /// </summary>
        public static readonly TokenFilterName EmitseachincomingtokentwiceonceaskeywordandonceasnonKeywordSeehttpLuceneapacheorgCore4103AnalyzersCommonOrgApacheLuceneAnalysisMiscellaneousKeywordRepeatFilterhtml = "keyword_repeat";

        /// <summary>
        /// A high-performance kstem filter for English. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/en/KStemFilter.html
        /// </summary>
        public static readonly TokenFilterName KStem = "kstem";

        /// <summary>
        /// Removes words that are too long or too short. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/LengthFilter.html
        /// </summary>
        public static readonly TokenFilterName Length = "length";

        /// <summary>
        /// Limits the number of tokens while indexing. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/LimitTokenCountFilter.html
        /// </summary>
        public static readonly TokenFilterName Limit = "limit";

        /// <summary>
        /// Normalizes token text to lower case. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/LowerCaseFilter.htm
        /// </summary>
        public static readonly TokenFilterName Lowercase = "lowercase";

        /// <summary>
        /// Generates n-grams of the given size(s). See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ngram/NGramTokenFilter.html
        /// </summary>
        public static readonly TokenFilterName NGram = "nGram_v2";

        /// <summary>
        /// Applies normalization for Persian. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/fa/PersianNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName PersianNormalization = "persian_normalization";

        /// <summary>
        /// Create tokens for phonetic matches. See
        /// https://lucene.apache.org/core/4_10_3/analyzers-phonetic/org/apache/lucene/analysis/phonetic/package-tree.html
        /// </summary>
        public static readonly TokenFilterName Phonetic = "phonetic";

        /// <summary>
        /// Uses the Porter stemming algorithm to transform the token stream.
        /// See http://tartarus.org/~martin/PorterStemmer
        /// </summary>
        public static readonly TokenFilterName PorterStem = "porter_stem";

        /// <summary>
        /// Reverses the token string. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/reverse/ReverseStringFilter.html
        /// </summary>
        public static readonly TokenFilterName Reverse = "reverse";

        /// <summary>
        /// Normalizes use of the interchangeable Scandinavian characters. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/ScandinavianNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName ScandinavianNormalization = "scandinavian_normalization";

        /// <summary>
        /// Folds Scandinavian characters åÅäæÄÆ-&gt;a and öÖøØ-&gt;o. It also
        /// discriminates against use of double vowels aa, ae, ao, oe and oo,
        /// leaving just the first one. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/ScandinavianFoldingFilter.html
        /// </summary>
        public static readonly TokenFilterName ScandinavianFoldingNormalization = "scandinavian_folding";

        /// <summary>
        /// Creates combinations of tokens as a single token. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/shingle/ShingleFilter.html
        /// </summary>
        public static readonly TokenFilterName Shingle = "shingle";

        /// <summary>
        /// A filter that stems words using a Snowball-generated stemmer. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/snowball/SnowballFilter.html
        /// </summary>
        public static readonly TokenFilterName Snowball = "snowball";

        /// <summary>
        /// Normalizes the Unicode representation of Sorani text. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ckb/SoraniNormalizationFilter.html
        /// </summary>
        public static readonly TokenFilterName SoraniNormalization = "sorani_normalization";

        /// <summary>
        /// Language specific stemming filter. See
        /// https://docs.microsoft.com/rest/api/searchservice/Custom-analyzers-in-Azure-Search#TokenFilters
        /// </summary>
        public static readonly TokenFilterName Stemmer = "stemmer";

        /// <summary>
        /// Removes stop words from a token stream. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/StopFilter.html
        /// </summary>
        public static readonly TokenFilterName Stopwords = "stopwords";

        /// <summary>
        /// Trims leading and trailing whitespace from tokens. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/TrimFilter.html
        /// </summary>
        public static readonly TokenFilterName Trim = "trim";

        /// <summary>
        /// Truncates the terms to a specific length. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/TruncateTokenFilter.html
        /// </summary>
        public static readonly TokenFilterName Truncate = "truncate";

        /// <summary>
        /// Filters out tokens with same text as the previous token. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/RemoveDuplicatesTokenFilter.html
        /// </summary>
        public static readonly TokenFilterName Unique = "unique";

        /// <summary>
        /// Normalizes token text to upper case. See
        /// http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/UpperCaseFilter.html
        /// </summary>
        public static readonly TokenFilterName Uppercase = "uppercase";

        /// <summary>
        /// Splits words into subwords and performs optional transformations on
        /// subword groups.
        /// </summary>
        public static readonly TokenFilterName WordDelimiter = "word_delimiter";


        /// <summary>
        /// Underlying value of enum TokenFilterName
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for TokenFilterName
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type TokenFilterName
        /// </summary>
        public bool Equals(TokenFilterName e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to TokenFilterName
        /// </summary>
        public static implicit operator TokenFilterName(string value)
        {
            return new TokenFilterName(value);
        }

        /// <summary>
        /// Implicit operator to convert TokenFilterName to string
        /// </summary>
        public static implicit operator string(TokenFilterName e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum TokenFilterName
        /// </summary>
        public static bool operator == (TokenFilterName e1, TokenFilterName e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum TokenFilterName
        /// </summary>
        public static bool operator != (TokenFilterName e1, TokenFilterName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for TokenFilterName
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is TokenFilterName && Equals((TokenFilterName)obj);
        }

        /// <summary>
        /// Returns for hashCode TokenFilterName
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
