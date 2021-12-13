﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Data.Tables;
using Microsoft.Azure.WebJobs.Host.Bindings;

namespace Microsoft.Azure.WebJobs.Extensions.Tables
{
    internal class PocoEntityArgumentBinding<TElement> : IArgumentBinding<TableEntityContext>
        where TElement : new()
    {
        public Type ValueType => typeof(TElement);

        public async Task<IValueProvider> BindAsync(TableEntityContext value, ValueBindingContext context)
        {
            var table = value.Table;
            var result = await table.GetEntityAsync<TableEntity>(
                value.PartitionKey, value.RowKey).ConfigureAwait(false);
            TableEntity entity = result.Value;

            if (entity == null)
            {
                return new NullEntityValueProvider<TElement>(value);
            }

            TElement userEntity;
            if (typeof(TElement) == typeof(TableEntity))
            {
                userEntity = (TElement)(object) entity;
            }
            else
            {
                userEntity = PocoTypeBinder.Shared.Deserialize<TElement>(entity);
            }

            return new PocoEntityValueBinder<TElement>(value, entity.ETag.ToString(), userEntity);
        }
    }
}