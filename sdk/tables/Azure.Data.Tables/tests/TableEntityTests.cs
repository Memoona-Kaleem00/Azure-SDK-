// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.Data.Tables;
using Azure.Data.Tables.Sas;
using Moq;
using NUnit.Framework;

namespace Azure.Tables.Tests
{
    public class TableEntityTests : ClientTestBase
    {
        public TableEntityTests(bool isAsync) : base(isAsync)
        { }

        private TableEntity entityWithoutPK = new TableEntity { { TableConstants.PropertyNames.RowKey, "row" } };
        private TableEntity entityWithAllTypes = new TableEntity {
            { TableConstants.PropertyNames.PartitionKey, "partition" },
            { TableConstants.PropertyNames.RowKey, "row" },
            { "binary", new byte[] { 1, 2 }},
            { "boolean", true },
            { "datetime", new DateTime() },
            { "double", (double)2.0 },
            { "guid", new Guid() },
            { "int32", int.MaxValue },
            { "int64", long.MaxValue }};

        /// <summary>
        /// Validates the typed getters.
        /// </summary>
        [Test]
        public void ValidateDictionaryTableEntityGetTypes()
        {
            Assert.That(entityWithAllTypes.GetBinary("binary"), Is.InstanceOf(typeof(byte[])));
            Assert.That(entityWithAllTypes.GetBoolean("boolean"), Is.InstanceOf(typeof(bool)));
            Assert.That(entityWithAllTypes.GetDateTime("datetime"), Is.InstanceOf(typeof(DateTime)));
            Assert.That(entityWithAllTypes.GetDouble("double"), Is.InstanceOf(typeof(double)));
            Assert.That(entityWithAllTypes.GetGuid("guid"), Is.InstanceOf(typeof(Guid)));
            Assert.That(entityWithAllTypes.GetInt32("int32"), Is.InstanceOf(typeof(int)));
            Assert.That(entityWithAllTypes.GetInt64("int64"), Is.InstanceOf(typeof(long)));
        }

        /// <summary>
        /// Validates the typed getters throws InvalidOperationException when the retrieved value doesn't match the type.
        /// </summary>
        [Test]
        public void DictionaryEntityGetWrongTypesThrows()
        {
            Assert.That(() => entityWithAllTypes.GetBinary("boolean"), Throws.InstanceOf<InvalidOperationException>(), "GetBinary should validate that the value for the inputted key is a Binary.");
            Assert.That(() => entityWithAllTypes.GetBoolean("datetime"), Throws.InstanceOf<InvalidOperationException>(), "GetBoolean should validate that the value for the inputted key is a Boolean.");
            Assert.That(() => entityWithAllTypes.GetDateTime("double"), Throws.InstanceOf<InvalidOperationException>(), "GetDateTime should validate that the value for the inputted key is a DateTime.");
            Assert.That(() => entityWithAllTypes.GetDouble("guid"), Throws.InstanceOf<InvalidOperationException>(), "GetDouble should validate that the value for the inputted key is an Double.");
            Assert.That(() => entityWithAllTypes.GetGuid("int32"), Throws.InstanceOf<InvalidOperationException>(), "GetGuid should validate that the value for the inputted key is an Guid.");
            Assert.That(() => entityWithAllTypes.GetInt32("int64"), Throws.InstanceOf<InvalidOperationException>(), "GetInt32 should validate that the value for the inputted key is a Int32.");
            Assert.That(() => entityWithAllTypes.GetInt64("binary"), Throws.InstanceOf<InvalidOperationException>(), "GetInt64 should validate that the value for the inputted key is a Int64.");
        }

        /// <summary>
        /// Validates getters for non-nullable types involving null. (ex. DateTime, int)
        /// </summary>
        [Test]
        public void ValidateDictionaryTableEntityGetNonNullType()
        {
            var dummyKey = "I'm a little dumb";
            Assert.That(entityWithAllTypes.GetBoolean(dummyKey), Is.Null);
            Assert.That(entityWithAllTypes.GetDateTime(dummyKey), Is.Null);
            Assert.That(entityWithAllTypes.GetDouble(dummyKey), Is.Null);
            Assert.That(entityWithAllTypes.GetInt32(dummyKey), Is.Null);
            Assert.That(entityWithAllTypes.GetInt64(dummyKey), Is.Null);
        }

        /// <summary>
        /// Validates getting properties involving null.
        /// </summary>
        [Test]
        public void DictionaryEntityGetNullOrNonexistentProperties()
        {
            // Test getting nonexistent property works.
            Assert.That(entityWithoutPK.PartitionKey, Is.Null);

            // Test getting a property that was set to null.
            entityWithAllTypes[TableConstants.PropertyNames.PartitionKey] = null;
            Assert.That(entityWithAllTypes[TableConstants.PropertyNames.PartitionKey], Is.Null);
        }

        /// <summary>
        /// Validates setting values makes correct changes.
        /// </summary>
        [Test]
        public void ValidateDictionaryEntitySetType()
        {
            var entity = new TableEntity("partition", "row") { { "exampleBool", true } };

            // Test setting an existing property with the same type works.
            entity["exampleInt"] = false;
            Assert.That(entity.GetBoolean("exampleInt"), Is.False);
        }

        /// <summary>
        /// Validates setting values to a different type throws InvalidOperationException.
        /// </summary>
        [Test]
        public void DictionaryEntitySetWrongTypeThrows()
        {
            var entity = new TableEntity("partition", "row") { { "exampleBool", true } };

            Assert.That(() => entity["exampleBool"] = "A random string", Throws.InstanceOf<InvalidOperationException>(), "Setting an existing property to a value with mismatched types should throw an exception.");
        }

        /// <summary>
        /// Validates setting required and additional properties involving null.
        /// </summary>
        [Test]
        public void DictionaryEntitySetNullProperties()
        {
            var entity = new TableEntity("partition", "row");

            // Test setting new property works.
            string stringKey = "key :D";
            string stringValue = "value D:";
            Assert.That(entity[stringKey], Is.Null);
            entity[stringKey] = stringValue;
            Assert.That(entity[stringKey], Is.EqualTo(stringValue));

            // Test setting existing value to null.
            entity[stringKey] = null;
            Assert.That(entity[stringKey], Is.Null);

            // Test setting existing null value to a non-null value.
            entity[stringKey] = stringValue;
            Assert.That(entity[stringKey], Is.EqualTo(stringValue));
        }
    }
}
