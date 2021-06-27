// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(AttestationResultConverter))]
    public partial class AttestationResult
    {
        internal static AttestationResult DeserializeAttestationResult(JsonElement element)
        {
            Optional<string> jti = default;
            Optional<string> iss = default;
            Optional<double> iat = default;
            Optional<double> exp = default;
            Optional<double> nbf = default;
            Optional<object> cnf = default;
            Optional<string> nonce = default;
            Optional<string> xMsVer = default;
            Optional<object> xMsRuntime = default;
            Optional<object> xMsInittime = default;
            Optional<object> xMsPolicy = default;
            Optional<string> xMsAttestationType = default;
            Optional<JsonWebKey> xMsPolicySigner = default;
            Optional<string> xMsPolicyHash = default;
            Optional<bool> xMsSgxIsDebuggable = default;
            Optional<float> xMsSgxProductId = default;
            Optional<string> xMsSgxMrenclave = default;
            Optional<string> xMsSgxMrsigner = default;
            Optional<float> xMsSgxSvn = default;
            Optional<string> xMsSgxEhd = default;
            Optional<object> xMsSgxCollateral = default;
            Optional<string> ver = default;
            Optional<bool> isDebuggable = default;
            Optional<object> maaAttestationcollateral = default;
            Optional<string> aasEhd = default;
            Optional<string> maaEhd = default;
            Optional<float> productId = default;
            Optional<string> sgxMrenclave = default;
            Optional<string> sgxMrsigner = default;
            Optional<float> svn = default;
            Optional<string> tee = default;
            Optional<JsonWebKey> policySigner = default;
            Optional<string> policyHash = default;
            Optional<string> rpData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jti"))
                {
                    jti = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iss"))
                {
                    iss = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    iat = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("exp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exp = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("nbf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nbf = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("cnf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cnf = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("nonce"))
                {
                    nonce = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-ver"))
                {
                    xMsVer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-runtime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsRuntime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("x-ms-inittime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsInittime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("x-ms-policy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsPolicy = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("x-ms-attestation-type"))
                {
                    xMsAttestationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-policy-signer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsPolicySigner = JsonWebKey.DeserializeJsonWebKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x-ms-policy-hash"))
                {
                    xMsPolicyHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-is-debuggable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsSgxIsDebuggable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-product-id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsSgxProductId = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-mrenclave"))
                {
                    xMsSgxMrenclave = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-mrsigner"))
                {
                    xMsSgxMrsigner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-svn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsSgxSvn = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-ehd"))
                {
                    xMsSgxEhd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-collateral"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsSgxCollateral = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ver"))
                {
                    ver = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("is-debuggable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDebuggable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maa-attestationcollateral"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maaAttestationcollateral = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("aas-ehd"))
                {
                    aasEhd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maa-ehd"))
                {
                    maaEhd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product-id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    productId = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sgx-mrenclave"))
                {
                    sgxMrenclave = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sgx-mrsigner"))
                {
                    sgxMrsigner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("svn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    svn = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("tee"))
                {
                    tee = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policy_signer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policySigner = JsonWebKey.DeserializeJsonWebKey(property.Value);
                    continue;
                }
                if (property.NameEquals("policy_hash"))
                {
                    policyHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rp_data"))
                {
                    rpData = property.Value.GetString();
                    continue;
                }
            }
            return new AttestationResult(jti.Value, iss.Value, Optional.ToNullable(iat), Optional.ToNullable(exp), Optional.ToNullable(nbf), cnf.Value, nonce.Value, xMsVer.Value, xMsRuntime.Value, xMsInittime.Value, xMsPolicy.Value, xMsAttestationType.Value, xMsPolicySigner.Value, xMsPolicyHash.Value, Optional.ToNullable(xMsSgxIsDebuggable), Optional.ToNullable(xMsSgxProductId), xMsSgxMrenclave.Value, xMsSgxMrsigner.Value, Optional.ToNullable(xMsSgxSvn), xMsSgxEhd.Value, xMsSgxCollateral.Value, ver.Value, Optional.ToNullable(isDebuggable), maaAttestationcollateral.Value, aasEhd.Value, maaEhd.Value, Optional.ToNullable(productId), sgxMrenclave.Value, sgxMrsigner.Value, Optional.ToNullable(svn), tee.Value, policySigner.Value, policyHash.Value, rpData.Value);
        }

        internal partial class AttestationResultConverter : JsonConverter<AttestationResult>
        {
            public override void Write(Utf8JsonWriter writer, AttestationResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AttestationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAttestationResult(document.RootElement);
            }
        }
    }
}
