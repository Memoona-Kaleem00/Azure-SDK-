﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Test.Perf;

namespace Azure.Messaging.ServiceBus.Perf.Scenarios
{
    public sealed class DeadLetterMessages : SettleMessagesBase
    {
        public DeadLetterMessages(SizeCountOptions options) : base(options)
        {
        }

        protected override async Task SettleAsync(ServiceBusReceivedMessage message, CancellationToken cancellationToken)
        {
            await Receiver.DeadLetterMessageAsync(message, "reason", cancellationToken: cancellationToken);
        }
    }
}
