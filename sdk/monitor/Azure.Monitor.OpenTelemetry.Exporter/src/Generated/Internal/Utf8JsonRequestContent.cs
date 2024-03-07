// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    internal class Utf8JsonRequestContent : RequestContent
    {
        private readonly MemoryStream _stream;
        private readonly RequestContent _content;
        private bool _disposed;

        public Utf8JsonRequestContent()
        {
            _stream = new MemoryStream();
            _content = Create(_stream);
            JsonWriter = new Utf8JsonWriter(_stream);
        }

        public Utf8JsonWriter JsonWriter { get; }

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default)
        {
            await JsonWriter.FlushAsync().ConfigureAwait(false);
            await _content.WriteToAsync(stream, cancellationToken).ConfigureAwait(false);
        }

        public override void WriteTo(Stream stream, CancellationToken cancellationToken = default)
        {
            JsonWriter.Flush();
            _content.WriteTo(stream, cancellationToken);
        }

        public override bool TryComputeLength(out long length)
        {
            length = JsonWriter.BytesCommitted + JsonWriter.BytesPending;
            return true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                var stream = _stream;
                stream.Dispose();

                var content = _content;
                content.Dispose();

                var writer = JsonWriter;
                writer.Dispose();

                _disposed = true;
            }
        }

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
