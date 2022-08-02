﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Azure.Messaging.ServiceBus.Amqp;
using Microsoft.Azure.Amqp;
using Microsoft.Azure.Amqp.Framing;
using Moq;
using NUnit.Framework;

namespace Azure.Messaging.ServiceBus.Tests.Amqp
{
    /// <summary>
    ///   The suite of tests for the <see cref="AmqpMessageBatch" />
    ///   class.
    /// </summary>
    [TestFixture]
    public class AmqpMessageBatchTests
    {
        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorValidatesTheOptions()
        {
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };
            Assert.That(() => new AmqpMessageBatch(mockMessageConverter, null), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorValidatesTheMaximumSize()
        {
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };
            Assert.That(() => new AmqpMessageBatch(mockMessageConverter, new CreateMessageBatchOptions { MaxSizeInBytes = null }), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorSetsTheMaximumSize()
        {
            var maximumSize = 9943;
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = maximumSize };
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            var batch = new AmqpMessageBatch(mockMessageConverter, options);
            Assert.That(batch.MaxSizeInBytes, Is.EqualTo(maximumSize));
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.TryAddMessage" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddValidatesTheMessage()
        {
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };
            var batch = new AmqpMessageBatch(mockMessageConverter, new CreateMessageBatchOptions { MaxSizeInBytes = 25 });
            Assert.That(() => batch.TryAddMessage(null), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.TryAddMessage" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddValidatesNotDisposed()
        {
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };
            var batch = new AmqpMessageBatch(mockMessageConverter, new CreateMessageBatchOptions { MaxSizeInBytes = 25 });

            batch.Dispose();

            Assert.That(() => batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Throws.InstanceOf<ObjectDisposedException>());
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.TryAddMessage" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddDoesNotAcceptAMessageBiggerThanTheMaximumSize()
        {
            var maximumSize = 50;
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = maximumSize };
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };
            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            Assert.That(batch.TryAddMessage(new ServiceBusMessage(new byte[50])), Is.False, "A message of the maximum size is too large due to the reserved overhead.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.TryAddMessage" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddAcceptsAMessageSmallerThanTheMaximumSize()
        {
            var maximumSize = 50;
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = maximumSize };
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            Assert.That(batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.TryAddMessage" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddAcceptMessagesUntilTheMaximumSizeIsReached()
        {
            var maximumSize = 100;
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = maximumSize };
            var messages = new AmqpMessage[3];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < messages.Length; ++index)
            {
                if (index == messages.Length - 1)
                {
                    Assert.That(batch.TryAddMessage(new ServiceBusMessage(new byte[10])), Is.False, "The final addition should not fit in the available space.");
                }
                else
                {
                    Assert.That(batch.TryAddMessage(new ServiceBusMessage(new byte[10])), Is.True, $"The addition for index: { index } should fit and be accepted.");
                }
            }
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.TryAddMessage" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddSetsTheCount()
        {
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = 5000 };
            var messages = new AmqpMessage[5];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            for (var index = 0; index < messages.Length; ++index)
            {
                messages[index] = AmqpMessage.Create(new Data { Value = new ArraySegment<byte>(new byte[] { 0x66 }) });
            }

            // Add the messages to the batch; all should be accepted.

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < messages.Length; ++index)
            {
                Assert.That(batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Is.True, $"The addition for index: { index } should fit and be accepted.");
            }

            Assert.That(batch.Count, Is.EqualTo(messages.Length), "The count should have been set when the batch was updated.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.AsList{T}" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AsReadOnlyValidatesTheTypeParameter()
        {
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = 5000 };
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            var batch = new AmqpMessageBatch(mockMessageConverter, options);
            Assert.That(() => batch.AsReadOnly<ServiceBusMessage>(), Throws.InstanceOf<FormatException>());
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.AsList{T}" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AsReadOnlyReturnsTheMessages()
        {
            var maximumSize = 5000;
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = maximumSize };
            var batchMessages = new AmqpMessage[5];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>(),
                BuildAmqpMessageFromSBMessageHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < batchMessages.Length; ++index)
            {
                var serviceBusMessage = new ServiceBusMessage(Array.Empty<byte>());
                batchMessages[index] = mockMessageConverter.SBMessageToAmqpMessage(serviceBusMessage);
            }

            var batchReadOnly = batch.AsReadOnly<AmqpMessage>();
            Assert.That(batchReadOnly, Is.Not.Null, "The batch enumerable should have been populated.");
            Assert.That(batchReadOnly.Count, Is.EqualTo(batch.Count), "The wrong number of messages was in the enumerable.");

            for (var index = 0; index < batchMessages.Length; ++index)
            {
                Assert.That(batchReadOnly.Contains(batchMessages[index]), $"The message at index: { index } was not in the enumerable.");
            }
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.Clear" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void ClearClearsTheCount()
        {
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = 5000 };
            var messages = new AmqpMessage[5];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            for (var index = 0; index < messages.Length; ++index)
            {
                messages[index] = AmqpMessage.Create(new Data { Value = new ArraySegment<byte>(new byte[] { 0x66 }) });
            }

            // Add the messages to the batch; all should be accepted.

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < messages.Length; ++index)
            {
                Assert.That(batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Is.True, $"The addition for index: { index } should fit and be accepted.");
            }

            Assert.That(batch.Count, Is.EqualTo(messages.Length), "The count should have been set when the batch was updated.");

            batch.Clear();
            Assert.That(batch.Count, Is.Zero, "The count should have been set when the batch was cleared.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.Clear" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void ClearClearsTheSize()
        {
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = 5000 };
            var messages = new AmqpMessage[5];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            for (var index = 0; index < messages.Length; ++index)
            {
                messages[index] = AmqpMessage.Create(new Data { Value = new ArraySegment<byte>(new byte[] { 0x66 }) });
            }

            // Add the messages to the batch; all should be accepted.

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < messages.Length; ++index)
            {
                Assert.That(batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Is.True, $"The addition for index: { index } should fit and be accepted.");
            }

            Assert.That(batch.SizeInBytes, Is.GreaterThan(0), "The size should have been set when the batch was updated.");

            batch.Clear();
            Assert.That(batch.SizeInBytes, Is.EqualTo(0));
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.Dispose" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void DisposeClearsTheCount()
        {
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = 5000 };
            var messages = new AmqpMessage[5];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            for (var index = 0; index < messages.Length; ++index)
            {
                messages[index] = AmqpMessage.Create(new Data { Value = new ArraySegment<byte>(new byte[] { 0x66 }) });
            }

            // Add the messages to the batch; all should be accepted.

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < messages.Length; ++index)
            {
                Assert.That(batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Is.True, $"The addition for index: { index } should fit and be accepted.");
            }

            Assert.That(batch.Count, Is.EqualTo(messages.Length), "The count should have been set when the batch was updated.");

            batch.Dispose();
            Assert.That(batch.Count, Is.Zero, "The count should have been set when the batch was cleared.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="AmqpMessageBatch.Dispose" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void DisposeClearsTheSize()
        {
            var options = new CreateMessageBatchOptions { MaxSizeInBytes = 5000 };
            var messages = new AmqpMessage[5];
            var mockMessageConverter = new InjectableMockConverter
            {
                BuildBatchFromAmqpMessagesHandler = (_s) => Mock.Of<AmqpMessage>()
            };

            for (var index = 0; index < messages.Length; ++index)
            {
                messages[index] = AmqpMessage.Create(new Data { Value = new ArraySegment<byte>(new byte[] { 0x66 }) });
            }

            // Add the messages to the batch; all should be accepted.

            var batch = new AmqpMessageBatch(mockMessageConverter, options);

            for (var index = 0; index < messages.Length; ++index)
            {
                Assert.That(batch.TryAddMessage(new ServiceBusMessage(Array.Empty<byte>())), Is.True, $"The addition for index: { index } should fit and be accepted.");
            }

            Assert.That(batch.SizeInBytes, Is.GreaterThan(0), "The size should have been set when the batch was updated.");

            batch.Dispose();
            Assert.That(batch.SizeInBytes, Is.EqualTo(0));
        }

        /// <summary>
        ///   Allows for control over AMQP message conversion for testing purposes.
        /// </summary>
        ///
        private class InjectableMockConverter : AmqpMessageConverter
        {
            public Func<ServiceBusMessage, AmqpMessage> BuildAmqpMessageFromSBMessageHandler = (_s) => null;
            public Func<IEnumerable<ServiceBusMessage>, bool, AmqpMessage> BuildBatchFromSBMessagesHandler = (_s, _f) => null;
            public Func<IEnumerable<AmqpMessage>, AmqpMessage> BuildBatchFromAmqpMessagesHandler = (_s) => null;
            public override AmqpMessage SBMessageToAmqpMessage(ServiceBusMessage source) => BuildAmqpMessageFromSBMessageHandler(source);
            public override AmqpMessage BuildAmqpBatchFromMessage(IReadOnlyCollection<ServiceBusMessage> source, bool forceBatch) => BuildBatchFromSBMessagesHandler(source, forceBatch);
            public override AmqpMessage BuildAmqpBatchFromMessage(IReadOnlyCollection<AmqpMessage> source) => BuildBatchFromAmqpMessagesHandler(source);
        }
    }
}
