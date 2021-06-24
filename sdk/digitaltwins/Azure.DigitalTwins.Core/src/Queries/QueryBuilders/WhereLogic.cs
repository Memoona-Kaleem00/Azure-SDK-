﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azure.DigitalTwins.Core.QueryBuilder
{
    /// <summary>
    /// Query that already contains a SELECT, FROM and a WHERE statement.
    /// </summary>
    public sealed class WhereLogic
    {
        private readonly AdtQueryBuilder _parent;
        private LogicalOperator _logicalOperator;
        private StringBuilder _conditions; //stbuilder, public method that exposes stringbuilder to logical op class

        internal WhereLogic(AdtQueryBuilder parent)
        {
            _parent = parent;
            _logicalOperator = new LogicalOperator(this, _conditions);
            _conditions = new StringBuilder();
        }

        /// <summary>
        /// Adds  the conditional arguments for a comparison to the query object. Used to compare ADT properties
        /// using the query language's comparison operators.
        /// </summary>
        /// <param name="field"> The field being checked against a certain value. </param>
        /// <param name="comparisonOperator"> The comparison operator being invoked. </param>
        /// <param name="value"> The value being checked against a Field. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator Compare<T>(string field, QueryComparisonOperator comparisonOperator, T value)
        {
            _conditions.Append(new WhereClause(new ComparisonCondition<T>(field, comparisonOperator, value)).Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the conditional arugments for a contains conditional statement to the query object. Used to search
        /// a field for a user specified property.
        /// </summary>
        /// <param name="value"> User specified property to look for. </param>
        /// <param name="searched"> Field of possible options to check for the 'value' parameter. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator Contains(string value, string[] searched)
        {
            _conditions.Append(new WhereClause(new ContainsCondition(value, QueryContainsOperator.In, searched)).Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the conditional arugments for a contains conditional statement to the query object. Used to search
        /// a field for a user specified property.
        /// </summary>
        /// <param name="value"> User specified property to look for. </param>
        /// <param name="searched"> Field of possible options to check for the 'value' parameter. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator NotContains(string value, string[] searched)
        {
            _conditions.Append(new WhereClause(new ContainsCondition(value, QueryContainsOperator.NotIn, searched)).Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// An alternative way to add a WHERE clause to the query by directly providing a string that contains the condition.
        /// </summary>
        /// <param name="condition"> The verbatim condition (SQL-like syntax) in string format. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator CustomClause(string condition)
        {
            _conditions.Append(condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-functions#is_defined">IS_DEFINED</see> function to the condition statement of the query.
        /// </summary>
        /// <param name="property"> The property that the query is looking for as defined. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator IsDefined(string property)
        {
            _conditions.Append(new WhereClause($"{QueryConstants.IsDefined}({property})").Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-functions#is_null">IS_NULL</see> function to the condition statement of the query.
        /// </summary>
        /// <param name="expression"> The expression being checked for null. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator IsNull(string expression)
        {
            _conditions.Append(new WhereClause($"{QueryConstants.IsNull}({expression})").Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-functions#startswith">STARTSWITH</see> function to the condition statement of the query.
        /// </summary>
        /// <param name="stringToCheck"> String to check the beginning of. </param>
        /// <param name="beginningString"> String representing the beginning to check for. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator StartsWith(string stringToCheck, string beginningString)
        {
            _conditions.Append(new WhereClause($"{QueryConstants.StartsWith}({stringToCheck}, '{beginningString}')").Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-functions#endswith">ENDSWITH</see> function to the condition statement of the query.
        /// </summary>
        /// <param name="stringToCheck"> String to check the ending of. </param>
        /// <param name="endingString"> String representing the ending to check for. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator EndsWith(string stringToCheck, string endingString)
        {
            _conditions.Append(new WhereClause($"{QueryConstants.EndsWith}({stringToCheck}, '{endingString}')").Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Adds the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-functions#is_of_model">IS_OF_MODEL</see> function to the condition statement of the query.
        /// </summary>
        /// <param name="model"> Model ID to check for. </param>
        /// <param name="exact"> Whether or not an exact match is required. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator IsOfModel(string model, bool exact = false)
        {
            var whereClauseArg = new StringBuilder();
            whereClauseArg.Append($"{QueryConstants.IsOfModel}('{model}'");

            if (exact)
            {
                whereClauseArg.Append(", exact");
            }

            whereClauseArg.Append(')');
            _conditions.Append(new WhereClause(whereClauseArg.ToString()));

            return _logicalOperator;
        }

        /// <summary>
        /// Adds a user-specified ADT query language function to check an expression's type against a built type in the ADT query language.
        /// </summary>
        /// <param name="expression"> The expression that the query is looking for as a specified type. </param>
        /// <param name="type"> The type in the ADT query language being checked for. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator IsOfType(string expression, AdtDataType type)
        {
            string functionName = QueryConstants.DataTypeToFunctionNameMap[type];
            _conditions.Append(new WhereClause($"{functionName}({expression})").Condition);
            return _logicalOperator;
        }

        /// <summary>
        /// Used to add nested WHERE conditions to a query.
        /// </summary>
        /// <param name="nested"> WhereLogic methods to perform within a set of parenthesis. </param>
        /// <returns> ADT query that already contains SELECT and FROM. </returns>
        public LogicalOperator IsTrue(Func<WhereLogic, LogicalOperator> nested)
        {
            var nestedLogic = new WhereLogic(null);
            nested.Invoke(nestedLogic);

            _conditions.Append(new WhereClause(QueryConstants.OpenParenthesis + nestedLogic.GetQueryText() + QueryConstants.CloseParenthesis).Condition);

            return _logicalOperator;
        }

        ///// <summary>
        ///// Adds the OR logical operator to a query.
        ///// </summary>
        ///// <returns> ADT query that already contains SELECT and FROM. </returns>
        //public WhereLogic Or()
        //{
        //    // prevent users from adding Or as the first expression of a WHERE clause
        //    if (_clauses.Count == 0)
        //    {
        //        throw new InvalidOperationException("The 'OR' logical operator cannot be the first part of a WHERE clause.");
        //    }

        //    _clauses.Add(new WhereClause(QueryConstants.Or));
        //    return this;
        //}

        ///// <summary>
        ///// Adds the AMD logical operator to a query.
        ///// </summary>
        ///// <returns> ADT query that already contains SELECT and FROM. </returns>
        //public WhereLogic And()
        //{
        //    // prevent users from adding And as the first expression of a WHERE clause
        //    if (_clauses.Count == 0)
        //    {
        //        throw new InvalidOperationException("The 'AND' logical operator cannot be the first part of a WHERE clause.");
        //    }

        //    _clauses.Add(new WhereClause(QueryConstants.And));
        //    return this;
        //}

        /// <inheritdoc/>
        internal AdtQueryBuilder Build()
        {
            return _parent;
        }

        /// <inheritdoc/>
        internal string GetQueryText()
        {
            if (_conditions.Length > 0)
            {
                //// Where keyword only needs to be appened one time, happends outside of loop
                //var whereLogicComponents = new StringBuilder();

                //var conditions = new List<string>(_conditions.Length);
                //foreach (string _clause in _conditions)
                //{
                //    conditions.Add(_clause);
                //}

                //whereLogicComponents.Append(string.Join(" ", conditions).Trim());
                //return whereLogicComponents.ToString().Trim();
                return _conditions.ToString();
            }

            return string.Empty;
        }
    }
}
