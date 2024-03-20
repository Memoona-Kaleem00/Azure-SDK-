// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Monitor.Query;
using NUnit.Framework;

namespace Azure.Monitor.Query.Samples
{
    public partial class Samples_MetricsBatchClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Batch_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            MetricsBatchClient client = new MetricsBatchClient(endpoint);

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Batch(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), "<metricnamespace>", new string[] { "<metricnames>" }, content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Batch_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            MetricsBatchClient client = new MetricsBatchClient(endpoint);

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.BatchAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), "<metricnamespace>", new string[] { "<metricnames>" }, content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Batch_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            MetricsBatchClient client = new MetricsBatchClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                resourceids = new object[]
            {
new object()
            },
            });
            Response response = client.Batch(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), "<metricnamespace>", new string[] { "<metricnames>" }, content, starttime: "<starttime>", endtime: "<endtime>", interval: XmlConvert.ToTimeSpan("PT1H23M45S"), aggregation: "<aggregation>", top: 1234, orderby: "<orderby>", filter: "<filter>", rollupby: "<rollupby>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("starttime").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("endtime").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("interval").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("namespace").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("resourceregion").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("resourceid").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("name").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("name").GetProperty("localizedValue").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("displayDescription").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("errorMessage").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("metadatavalues")[0].GetProperty("name").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("metadatavalues")[0].GetProperty("name").GetProperty("localizedValue").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("metadatavalues")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("timeStamp").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("average").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("minimum").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("maximum").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("total").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("count").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Batch_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            MetricsBatchClient client = new MetricsBatchClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                resourceids = new object[]
            {
new object()
            },
            });
            Response response = await client.BatchAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), "<metricnamespace>", new string[] { "<metricnames>" }, content, starttime: "<starttime>", endtime: "<endtime>", interval: XmlConvert.ToTimeSpan("PT1H23M45S"), aggregation: "<aggregation>", top: 1234, orderby: "<orderby>", filter: "<filter>", rollupby: "<rollupby>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("starttime").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("endtime").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("interval").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("namespace").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("resourceregion").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("resourceid").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("name").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("name").GetProperty("localizedValue").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("displayDescription").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("errorMessage").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("metadatavalues")[0].GetProperty("name").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("metadatavalues")[0].GetProperty("name").GetProperty("localizedValue").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("metadatavalues")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("timeStamp").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("average").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("minimum").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("maximum").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("total").ToString());
            Console.WriteLine(result.GetProperty("values")[0].GetProperty("value")[0].GetProperty("timeseries")[0].GetProperty("data")[0].GetProperty("count").ToString());
        }
    }
}
