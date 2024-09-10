// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Billing
{
    public partial class SubscriptionBillingInvoiceResource : IJsonModel<BillingInvoiceData>
    {
        void IJsonModel<BillingInvoiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BillingInvoiceData>)Data).Write(writer, options);

        BillingInvoiceData IJsonModel<BillingInvoiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BillingInvoiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<BillingInvoiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        BillingInvoiceData IPersistableModel<BillingInvoiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BillingInvoiceData>(data, options);

        string IPersistableModel<BillingInvoiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BillingInvoiceData>)Data).GetFormatFromOptions(options);
    }
}
