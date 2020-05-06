﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Storage.Blobs.ChangeFeed.Models;
using Azure.Storage.Blobs.Models;
using Moq;
using NUnit.Framework;

namespace Azure.Storage.Blobs.ChangeFeed.Tests
{
    public class SegmentTests : ChangeFeedTestBase
    {
        public SegmentTests(bool async)
            : base(async, null /* RecordedTestMode.Record /* to re-record */)
        {
        }

        [Test]
        public async Task GetCursor()
        {
            // Arrange
            string manifestPath = "idx/segments/2020/03/25/0200/meta.json";

            Mock<BlobContainerClient> containerClient = new Mock<BlobContainerClient>(MockBehavior.Strict);
            Mock<BlobClient> blobClient = new Mock<BlobClient>(MockBehavior.Strict);
            Mock<ShardFactory> shardFactory = new Mock<ShardFactory>(MockBehavior.Strict);

            List<Mock<Shard>> shards = new List<Mock<Shard>>();
            for (int i = 0; i < 5; i++)
            {
                shards.Add(new Mock<Shard>(MockBehavior.Strict));
            }

            List<ShardCursor> shardCursors = new List<ShardCursor>
            {
                new ShardCursor(1, 2, 3),
                new ShardCursor(4, 5, 6),
                new ShardCursor(7, 8, 9),
                new ShardCursor(10, 11, 12),
                new ShardCursor(13, 14, 15)
            };

            DateTimeOffset dateTime = new DateTimeOffset(2020, 3, 25, 2, 0, 0, TimeSpan.Zero);
            int shardIndex = 4;

            SegmentCursor expectedCursor = new SegmentCursor(
                dateTime,
                shardCursors,
                shardIndex);

            containerClient.Setup(r => r.GetBlobClient(It.IsAny<string>())).Returns(blobClient.Object);

            using FileStream stream = File.OpenRead($"Resources{Path.DirectorySeparatorChar}{"SegmentManifest.json"}");
            BlobDownloadInfo blobDownloadInfo = BlobsModelFactory.BlobDownloadInfo(content: stream);
            Response<BlobDownloadInfo> downloadResponse = Response.FromValue(blobDownloadInfo, new ResponseImplementation());

            if (IsAsync)
            {
                blobClient.Setup(r => r.DownloadAsync()).ReturnsAsync(downloadResponse);
            }
            else
            {
                blobClient.Setup(r => r.Download()).Returns(downloadResponse);
            }

            shardFactory.SetupSequence(r => r.BuildShard(
                It.IsAny<bool>(),
                It.IsAny<BlobContainerClient>(),
                It.IsAny<string>(),
                It.IsAny<ShardCursor>()))
                .ReturnsAsync(shards[0].Object)
                .ReturnsAsync(shards[1].Object)
                .ReturnsAsync(shards[2].Object)
                .ReturnsAsync(shards[3].Object)
                .ReturnsAsync(shards[4].Object);

            for (int i = 0; i < shards.Count; i++)
            {
                shards[i].Setup(r => r.GetCursor()).Returns(shardCursors[i]);
            }

            SegmentFactory segmentFactory = new SegmentFactory(shardFactory.Object);
            Segment segment = await segmentFactory.BuildSegment(
                IsAsync,
                containerClient.Object,
                manifestPath,
                expectedCursor);

            // Act
            SegmentCursor cursor = segment.GetCursor();

            // Assert
            Assert.AreEqual(expectedCursor.SegmentTime, cursor.SegmentTime);
            Assert.AreEqual(expectedCursor.ShardCursors.Count, cursor.ShardCursors.Count);
            for (int i = 0; i < expectedCursor.ShardCursors.Count; i++)
            {
                Assert.AreEqual(expectedCursor.ShardCursors[i].BlockOffset, cursor.ShardCursors[i].BlockOffset);
                Assert.AreEqual(expectedCursor.ShardCursors[i].ChunkIndex, cursor.ShardCursors[i].ChunkIndex);
                Assert.AreEqual(expectedCursor.ShardCursors[i].EventIndex, cursor.ShardCursors[i].EventIndex);
            }
            Assert.AreEqual(shardIndex, cursor.ShardIndex);

            containerClient.Verify(r => r.GetBlobClient(manifestPath));

            if (IsAsync)
            {
                blobClient.Verify(r => r.DownloadAsync());
            }
            else
            {
                blobClient.Verify(r => r.Download());
            }

            for (int i = 0; i < shards.Count; i++)
            {
                shardFactory.Verify(r => r.BuildShard(
                    IsAsync,
                    containerClient.Object,
                    $"log/0{i}/2020/03/25/0200/",
                    shardCursors[i]));
            }
        }

        /// <summary>
        /// In this test, the Segment has 3 Shards and 5 total Events.
        /// Shard index 0 and 1 have 2 Events, and Shard index 2 has 1 Event.
        /// We are round-robining the Shards, so we will return the events for
        /// the shards indexes: 0 1 2 0 1.
        /// </summary>
        //[Test]
        //public async Task GetPage()
        //{
        //    // Arrange
        //    int eventCount = 5;
        //    int shardCount = 3;

        //    List<Guid> eventIds = new List<Guid>();
        //    for (int i = 0; i < eventCount; i++)
        //    {
        //        eventIds.Add(Guid.NewGuid());
        //    }

        //    List<Mock<Shard>> mockShards = new List<Mock<Shard>>();

        //    for (int i = 0; i <shardCount; i++)
        //    {
        //        mockShards.Add(new Mock<Shard>(MockBehavior.Strict));
        //    }

        //    // Set up Shards
        //    mockShards[0].SetupSequence(r => r.Next(It.IsAny<bool>(), default))
        //        .Returns(Task.FromResult(new BlobChangeFeedEvent
        //        {
        //            Id = eventIds[0]
        //        }))
        //        .Returns(Task.FromResult(new BlobChangeFeedEvent
        //        {
        //            Id = eventIds[3]
        //        }));

        //    mockShards[0].SetupSequence(r => r.HasNext())
        //        .Returns(true)
        //        .Returns(false);

        //    mockShards[1].SetupSequence(r => r.Next(It.IsAny<bool>(), default))
        //        .Returns(Task.FromResult(new BlobChangeFeedEvent
        //        {
        //            Id = eventIds[1]
        //        }))
        //        .Returns(Task.FromResult(new BlobChangeFeedEvent
        //        {
        //            Id = eventIds[4]
        //        }));

        //    mockShards[1].SetupSequence(r => r.HasNext())
        //        .Returns(true)
        //        .Returns(false);

        //    mockShards[2].Setup(r => r.Next(It.IsAny<bool>(), default))
        //        .Returns(Task.FromResult(new BlobChangeFeedEvent
        //        {
        //            Id = eventIds[2]
        //        }));

        //    mockShards[2].Setup(r => r.HasNext())
        //        .Returns(false);

        //    List<Shard> shards = new List<Shard>();
        //    for (int i = 0; i < shardCount; i++)
        //    {
        //        shards.Add(mockShards[i].Object);
        //    }

        //    Segment segment = new Segment(
        //        isInitalized: true,
        //        shards: shards);

        //    // Act
        //    List<BlobChangeFeedEvent> events = await segment.GetPage(IsAsync, 25);

        //    // Assert
        //    Assert.AreEqual(eventCount, events.Count);
        //    for (int i = 0; i < eventCount; i++)
        //    {
        //        Assert.AreEqual(eventIds[i], events[i].Id);
        //    }

        //    mockShards[0].Verify(r => r.Next(IsAsync, default));
        //    mockShards[0].Verify(r => r.HasNext());
        //    mockShards[1].Verify(r => r.Next(IsAsync, default));
        //    mockShards[1].Verify(r => r.HasNext());
        //    mockShards[2].Verify(r => r.Next(IsAsync, default));
        //    mockShards[2].Verify(r => r.HasNext());
        //    mockShards[0].Verify(r => r.Next(IsAsync, default));
        //    mockShards[0].Verify(r => r.HasNext());
        //    mockShards[1].Verify(r => r.Next(IsAsync, default));
        //    mockShards[1].Verify(r => r.HasNext());
        //}

        private class ResponseImplementation : Response
        {
            public override int Status => throw new NotImplementedException();

            public override string ReasonPhrase => throw new NotImplementedException();

            public override Stream ContentStream { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public override string ClientRequestId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void Dispose()
            {
                throw new NotImplementedException();
            }

            protected override bool ContainsHeader(string name)
            {
                throw new NotImplementedException();
            }

            protected override IEnumerable<HttpHeader> EnumerateHeaders()
            {
                throw new NotImplementedException();
            }

            protected override bool TryGetHeader(string name, out string value)
            {
                throw new NotImplementedException();
            }

            protected override bool TryGetHeaderValues(string name, out IEnumerable<string> values)
            {
                throw new NotImplementedException();
            }
        }
    }
}
