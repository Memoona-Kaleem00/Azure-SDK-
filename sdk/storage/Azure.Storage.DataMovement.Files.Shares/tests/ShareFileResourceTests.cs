﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;
using Azure.Storage.Test;
using Moq;
using NUnit.Framework;

namespace Azure.Storage.DataMovement.Files.Shares.Tests
{
    public class ShareFileResourceTests
    {
        public static byte[] GetRandomBuffer(long size, Random random = null)
        {
            random ??= new Random(Environment.TickCount);
            var buffer = new byte[size];
            random.NextBytes(buffer);
            return buffer;
        }

        [Test]
        public void Ctor_PublicUri()
        {
            // Arrange
            Uri uri = new Uri("https://storageaccount.blob.core.windows.net/");
            ShareFileClient fileClient = new ShareFileClient(uri);
            ShareFileStorageResource storageResource = new(fileClient);

            // Assert
            Assert.AreEqual(uri, storageResource.Uri.AbsoluteUri);
        }

        [Test]
        public async Task ReadStreamAsync()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());
            int length = 1024;
            string contentRange = "bytes 0-1024/1024";
            var data = GetRandomBuffer(length);
            using (var stream = new MemoryStream(data))
            {
                mock.Setup(b => b.DownloadAsync(It.IsAny<ShareFileDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    FilesModelFactory.StorageFileDownloadInfo(
                        content: stream,
                        contentLength: length,
                        contentRange: contentRange),
                    new MockResponse(201))));

                ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

                // Act
                StorageResourceReadStreamResult result = await storageResource.ReadStreamInternalAsync();

                // Assert
                Assert.NotNull(result);
                Assert.That(data, Is.EqualTo(result.Content.AsBytes().ToArray()));
            }
            mock.Verify(b => b.DownloadAsync(It.IsAny<ShareFileDownloadOptions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task ReadStreamAsync_Position()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());
            int position = 5;
            int length = 1024;
            string contentRange = "bytes 0-1024/1024";
            var data = GetRandomBuffer(length);
            using (var stream = new MemoryStream(data))
            {
                mock.Setup(b => b.DownloadAsync(It.IsAny<ShareFileDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    FilesModelFactory.StorageFileDownloadInfo(
                        content: stream,
                        contentLength: length,
                        contentRange: contentRange),
                    new MockResponse(201))));

                ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

                // Act
                StorageResourceReadStreamResult result = await storageResource.ReadStreamInternalAsync();

                // Assert
                Assert.NotNull(result);
                byte[] dataAt5 = new byte[data.Length - position];
                Array.Copy(data, position, dataAt5, 0, data.Length - position);
                Assert.That(data, Is.EqualTo(result.Content.AsBytes().ToArray()));
            }
            mock.Verify(b => b.DownloadAsync(It.IsAny<ShareFileDownloadOptions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task ReadStreamAsync_Error()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());

            mock.Setup(b => b.DownloadAsync(It.IsAny<ShareFileDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Throws(new RequestFailedException(status: 404, message: "The specified resource does not exist.", errorCode: "ResourceNotFound", default));

            ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

            // Act without creating the blob
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                storageResource.ReadStreamInternalAsync(),
                e =>
                {
                    Assert.AreEqual("ResourceNotFound", e.ErrorCode);
                });
            mock.Verify(b => b.DownloadAsync(It.IsAny<ShareFileDownloadOptions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyFromStreamAsync()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());
            int length = 1024;
            var data = GetRandomBuffer(length);
            using var stream = new MemoryStream(data);
            using var fileContentStream = new MemoryStream();
            mock.Setup(b => b.UploadAsync(It.IsAny<Stream>(), It.IsAny<ShareFileUploadOptions>(), It.IsAny<CancellationToken>()))
                .Callback<Stream, ShareFileUploadOptions, CancellationToken>(
                async (uploadedstream, options, token) =>
                {
                    await uploadedstream.CopyToAsync(fileContentStream).ConfigureAwait(false);
                    fileContentStream.Position = 0;
                })
                .Returns(Task.FromResult(Response.FromValue(
                    ShareModelFactory.ShareFileUploadInfo(
                        eTag: new ETag("eTag"),
                        lastModified: DateTimeOffset.UtcNow,
                        contentHash: default,
                        isServerEncrypted: false),
                    new MockResponse(200))));

            ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

            // Act
            await storageResource.CopyFromStreamInternalAsync(
                stream: stream,
                streamLength: length,
                overwrite: false,
                completeLength: length);

            Assert.That(data, Is.EqualTo(fileContentStream.AsBytes().ToArray()));
            mock.Verify(b => b.UploadAsync(It.IsAny<Stream>(), It.IsAny<ShareFileUploadOptions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyFromStreamAsync_Position()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());
            int position = 5;
            int length = 1024;
            var data = GetRandomBuffer(length);
            using var stream = new MemoryStream(data);
            using var fileContentStream = new MemoryStream();
            mock.Setup(b => b.UploadRangeAsync(It.IsAny<HttpRange>(), It.IsAny<Stream>(), It.IsAny<ShareFileUploadRangeOptions>(), It.IsAny<CancellationToken>()))
                .Callback<HttpRange, Stream, ShareFileUploadRangeOptions, CancellationToken>(
                async (range, uploadedstream, options, token) =>
                {
                    fileContentStream.Position = 5;
                    await uploadedstream.CopyToAsync(fileContentStream).ConfigureAwait(false);
                    fileContentStream.Position = 0;
                })
                .Returns(Task.FromResult(Response.FromValue(
                    ShareModelFactory.ShareFileUploadInfo(
                        eTag: new ETag("eTag"),
                        lastModified: DateTimeOffset.UtcNow,
                        contentHash: default,
                        isServerEncrypted: false),
                    new MockResponse(200))));

            ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

            // Act
            await storageResource.CopyFromStreamInternalAsync(
                stream: stream,
                streamLength: length,
                overwrite: false,
                completeLength: length,
                options: new StorageResourceWriteToOffsetOptions() { Position = position });

            // Assert
            byte[] dataAt5 = new byte[data.Length + position];
            Array.Copy(data, 0, dataAt5, 5, length);
            Assert.That(dataAt5, Is.EqualTo(fileContentStream.AsBytes().ToArray()));
            mock.Verify(b => b.UploadRangeAsync(It.IsAny<HttpRange>(), It.IsAny<Stream>(), It.IsAny<ShareFileUploadRangeOptions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyFromStreamAsync_Error()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());

            mock.Setup(b => b.UploadAsync(It.IsAny<Stream>(), It.IsAny<ShareFileUploadOptions>(), It.IsAny<CancellationToken>()))
                .Throws(new RequestFailedException(status: 404, message: "The specified resource does not exist.", errorCode: "ResourceNotFound", default));

            ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

            // Act
            int length = 1024;
            var data = GetRandomBuffer(length);
            using (var stream = new MemoryStream(data))
            {
                await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                storageResource.CopyFromStreamInternalAsync(stream, length, false, length),
                e =>
                {
                    Assert.AreEqual("ResourceNotFound", e.ErrorCode);
                });
            }
            mock.Verify(b => b.UploadAsync(It.IsAny<Stream>(), It.IsAny<ShareFileUploadOptions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyFromUriAsync()
        {
            // Arrange
            Mock<StorageResourceItem> sourceResource = new();
            sourceResource.Setup(b => b.Uri)
                .Returns(new Uri("https://storageaccount.file.core.windows.net/container/sourcefile"));

            Mock<ShareFileClient> mockDestination = new(
                new Uri("https://storageaccount.file.core.windows.net/container/destinationfile"),
                new ShareClientOptions());

            mockDestination.Setup(b => b.UploadRangeFromUriAsync(It.IsAny<Uri>(), It.IsAny<HttpRange>(), It.IsAny<HttpRange>(), It.IsAny<ShareFileUploadRangeFromUriOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    ShareModelFactory.ShareFileUploadInfo(
                        eTag: new ETag("eTag"),
                        lastModified: DateTimeOffset.UtcNow,
                        contentHash: default,
                        isServerEncrypted: false),
                    new MockResponse(200))));
            ShareFileStorageResource destinationResource = new ShareFileStorageResource(mockDestination.Object);

            int length = 1024;
            await destinationResource.CopyFromUriInternalAsync(sourceResource.Object, false, length);

            sourceResource.Verify(b => b.Uri, Times.Once());
            sourceResource.VerifyNoOtherCalls();
            mockDestination.Verify(b => b.UploadRangeFromUriAsync(
                sourceResource.Object.Uri,
                new HttpRange(0, length),
                new HttpRange(0, length),
                It.IsAny<ShareFileUploadRangeFromUriOptions>(),
                It.IsAny<CancellationToken>()),
                Times.Once());
            mockDestination.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyFromUriAsync_Error()
        {
            // Arrange
            Mock<StorageResourceItem> sourceResource = new();
            sourceResource.Setup(b => b.Uri)
                .Returns(new Uri("https://storageaccount.file.core.windows.net/container/sourcefile"));

            Mock<ShareFileClient> mockDestination = new(
                new Uri("https://storageaccount.file.core.windows.net/container/destinationfile"),
                new ShareClientOptions());

            mockDestination.Setup(b => b.UploadRangeFromUriAsync(It.IsAny<Uri>(), It.IsAny<HttpRange>(), It.IsAny<HttpRange>(), It.IsAny<ShareFileUploadRangeFromUriOptions>(), It.IsAny<CancellationToken>()))
                .Throws(new RequestFailedException(status: 404, message: "The specified resource does not exist.", errorCode: "ResourceNotFound", default));
            ShareFileStorageResource destinationResource = new ShareFileStorageResource(mockDestination.Object);

            // Act
            int length = 1024;
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                destinationResource.CopyFromUriInternalAsync(sourceResource.Object, false, length),
                e =>
                {
                    Assert.AreEqual("ResourceNotFound", e.ErrorCode);
                });

            sourceResource.Verify(b => b.Uri, Times.Once());
            sourceResource.VerifyNoOtherCalls();
            mockDestination.Verify(b => b.UploadRangeFromUriAsync(
                sourceResource.Object.Uri,
                new HttpRange(0, length),
                new HttpRange(0, length),
                It.IsAny<ShareFileUploadRangeFromUriOptions>(),
                It.IsAny<CancellationToken>()),
                Times.Once());
            mockDestination.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyBlockFromUriAsync()
        {
            // Arrange
            int length = 1024;
            Mock<StorageResourceItem> sourceResource = new();
            sourceResource.Setup(b => b.Uri)
                .Returns(new Uri("https://storageaccount.file.core.windows.net/container/sourcefile"));

            Mock<ShareFileClient> mockDestination = new(
                new Uri("https://storageaccount.file.core.windows.net/container/destinationfile"),
                new ShareClientOptions());

            mockDestination.Setup(b => b.UploadRangeFromUriAsync(It.IsAny<Uri>(), It.IsAny<HttpRange>(), It.IsAny<HttpRange>(), It.IsAny<ShareFileUploadRangeFromUriOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    ShareModelFactory.ShareFileUploadInfo(
                        eTag: new ETag("eTag"),
                        lastModified: DateTimeOffset.UtcNow,
                        contentHash: default,
                        isServerEncrypted: false),
                    new MockResponse(200))));
            ShareFileStorageResource destinationResource = new ShareFileStorageResource(mockDestination.Object);

            // Act
            await destinationResource.CopyBlockFromUriInternalAsync(
                sourceResource: sourceResource.Object,
                overwrite: false,
                range: new HttpRange(0, length),
                completeLength: length);

            sourceResource.Verify(b => b.Uri, Times.Once());
            sourceResource.VerifyNoOtherCalls();
            mockDestination.Verify(b => b.UploadRangeFromUriAsync(
                sourceResource.Object.Uri,
                new HttpRange(0, length),
                new HttpRange(0, length),
                It.IsAny<ShareFileUploadRangeFromUriOptions>(),
                It.IsAny<CancellationToken>()),
                Times.Once());
            mockDestination.VerifyNoOtherCalls();
        }

        [Test]
        public async Task CopyBlockFromUriAsync_Error()
        {
            // Arrange
            Mock<StorageResourceItem> sourceResource = new();
            sourceResource.Setup(b => b.Uri)
                .Returns(new Uri("https://storageaccount.file.core.windows.net/container/sourcefile"));

            Mock<ShareFileClient> mockDestination = new(
                new Uri("https://storageaccount.file.core.windows.net/container/destinationfile"),
                new ShareClientOptions());

            mockDestination.Setup(b => b.UploadRangeFromUriAsync(It.IsAny<Uri>(), It.IsAny<HttpRange>(), It.IsAny<HttpRange>(), It.IsAny<ShareFileUploadRangeFromUriOptions>(), It.IsAny<CancellationToken>()))
                .Throws(new RequestFailedException(status: 404, message: "The specified resource does not exist.", errorCode: "ResourceNotFound", default));
            ShareFileStorageResource destinationResource = new ShareFileStorageResource(mockDestination.Object);

            // Act
            int length = 1024;
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                destinationResource.CopyBlockFromUriInternalAsync(sourceResource.Object, new HttpRange(0, length), false, length),
                e =>
                {
                    Assert.AreEqual("ResourceNotFound", e.ErrorCode);
                });

            sourceResource.Verify(b => b.Uri, Times.Once());
            sourceResource.VerifyNoOtherCalls();
            mockDestination.Verify(b => b.UploadRangeFromUriAsync(
                sourceResource.Object.Uri,
                new HttpRange(0, length),
                new HttpRange(0, length),
                It.IsAny<ShareFileUploadRangeFromUriOptions>(),
                It.IsAny<CancellationToken>()),
                Times.Once());
            mockDestination.VerifyNoOtherCalls();
        }

        [Test]
        public async Task GetPropertiesAsync()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());

            long length = 1024;
            string source = "https://storageaccount.file.core.windows.net/container/file2";
            mock.Setup(b => b.GetPropertiesAsync(It.IsAny<ShareFileRequestConditions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    FilesModelFactory.StorageFileProperties(
                        lastModified: DateTime.MinValue,
                        metadata: default,
                        contentLength: length,
                        contentType: default,
                        eTag: new ETag("etag"),
                        contentHash: default,
                        contentEncoding: default,
                        cacheControl: default,
                        contentDisposition: default,
                        contentLanguage: default,
                        copyCompletedOn: DateTimeOffset.MinValue,
                        copyStatusDescription: default,
                        copyId: default,
                        copyProgress: default,
                        copySource: source,
                        copyStatus: CopyStatus.Success,
                        isServerEncrypted: false,
                        fileAttributes: default,
                        fileCreationTime: DateTimeOffset.MinValue,
                        fileLastWriteTime: DateTimeOffset.MinValue,
                        fileChangeTime: DateTimeOffset.MinValue,
                        filePermissionKey: default,
                        fileId: default,
                        fileParentId: default),
                    new MockResponse(200))));

            ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

            // Act
            StorageResourceProperties result = await storageResource.GetPropertiesInternalAsync();
            Mock<StorageResourceProperties> properties = new Mock<StorageResourceProperties>(result);

            // Assert
            Assert.NotNull(result);
            mock.Verify(b => b.GetPropertiesAsync(It.IsAny<ShareFileRequestConditions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task GetPropertiesAsync_Error()
        {
            // Arrange
            Mock<ShareFileClient> mock = new(
                new Uri("https://storageaccount.file.core.windows.net/container/file"),
                new ShareClientOptions());

            mock.Setup(b => b.GetPropertiesAsync(It.IsAny<ShareFileRequestConditions>(), It.IsAny<CancellationToken>()))
                .Throws(new RequestFailedException(status: 404, message: "The specified resource does not exist.", errorCode: "ResourceNotFound", default));

            ShareFileStorageResource storageResource = new ShareFileStorageResource(mock.Object);

            // Act without creating the blob
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                storageResource.GetPropertiesInternalAsync(),
                e =>
                {
                    Assert.AreEqual("ResourceNotFound", e.ErrorCode);
                });
            mock.Verify(b => b.GetPropertiesAsync(It.IsAny<ShareFileRequestConditions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }
    }
}
