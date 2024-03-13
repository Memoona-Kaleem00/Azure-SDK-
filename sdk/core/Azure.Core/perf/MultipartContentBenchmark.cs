﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.IO;
using System.Net.Http;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Azure.Core.Perf;

[SimpleJob(RuntimeMoniker.Net60)]
[MemoryDiagnoser]
public class MultipartContentBenchmark
{
    // File is 1.68 MB
    private static string _fileName = @"c:\temp\test\data\variation_sample_image.png";

    [Benchmark(Baseline = true)]
    public Stream SerializeWithOptimizedMultipart()
    {
        FileStream fileStream = File.OpenRead(_fileName);

        System.ClientModel.Primitives.MultipartContentPrototype content = new(boundary: "f8c75cdd-b0a1-4b5d-9807-bff78e26d083"u8);
        content.Add(BinaryContent.FromBinaryData(BinaryData.FromString("Hello World!\r\n")), ("Content-Type", "text/plain"));
        content.Add(BinaryContent.FromStream(fileStream), ("Content-Type", "application/octet-stream"));

        MemoryStream stream = new();
        content.WriteTo(stream);
        stream.Flush();
        return stream;
    }

    [Benchmark]
    public Stream SerializeWithBCL()
    {
        FileStream fileStream = File.OpenRead(_fileName);

        System.Net.Http.MultipartFormDataContent httpContent = new();
        httpContent.Add(new StringContent("Hello World!\r\n"), "text/plain");
        httpContent.Add(new StreamContent(fileStream), "application/octet-stream");

#if NET6_0_OR_GREATER
        Stream contentStream = httpContent.ReadAsStream();
        BinaryContent content = BinaryContent.FromStream(contentStream);

        MemoryStream stream = new();
        content.WriteTo(stream);
        stream.Flush();
        return stream;
#else
        // TODO: if we want to perf test earlier frameworks, add that.
        // Looks like HttpContent has this API available prior to .NET 5
        // https://learn.microsoft.com/dotnet/api/system.net.http.httpcontent.loadintobufferasync
        return new MemoryStream();
#endif
    }
}
