﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace Azure.Data.Tables.Queryable
{
    internal class ExpressionNormalizer : DataServiceLinqExpressionVisitor
    {
        private const bool LiftToNull = false;

        private readonly Dictionary<Expression, Pattern> patterns = new Dictionary<Expression, Pattern>(ReferenceEqualityComparer<Expression>.Instance);

        private ExpressionNormalizer(Dictionary<Expression, Expression> normalizerRewrites)
        {
            Debug.Assert(normalizerRewrites != null, "normalizerRewrites != null");
            NormalizerRewrites = normalizerRewrites;
        }

        internal Dictionary<Expression, Expression> NormalizerRewrites { get; }

        internal static Expression Normalize(Expression expression, Dictionary<Expression, Expression> rewrites)
        {
            Debug.Assert(expression != null, "expression != null");
            Debug.Assert(rewrites != null, "rewrites != null");

            ExpressionNormalizer normalizer = new ExpressionNormalizer(rewrites);
            Expression result = normalizer.Visit(expression);
            return result;
        }

        internal override Expression VisitBinary(BinaryExpression b)
        {
            BinaryExpression visited = (BinaryExpression)base.VisitBinary(b);

            if (visited.NodeType == ExpressionType.Equal)
            {
                Expression normalizedLeft = UnwrapObjectConvert(visited.Left);
                Expression normalizedRight = UnwrapObjectConvert(visited.Right);
                if (normalizedLeft != visited.Left || normalizedRight != visited.Right)
                {
                    visited = CreateRelationalOperator(ExpressionType.Equal, normalizedLeft, normalizedRight);
                }
            }

            if (patterns.TryGetValue(visited.Left, out Pattern pattern) && pattern.Kind == PatternKind.Compare && IsConstantZero(visited.Right))
            {
                ComparePattern comparePattern = (ComparePattern)pattern;
                if (TryCreateRelationalOperator(visited.NodeType, comparePattern.Left, comparePattern.Right, out BinaryExpression relationalExpression))
                {
                    visited = relationalExpression;
                }
            }

            RecordRewrite(b, visited);

            return visited;
        }

        internal override Expression VisitUnary(UnaryExpression u)
        {
            UnaryExpression visited = (UnaryExpression)base.VisitUnary(u);
            Expression result = visited;

            RecordRewrite(u, result);

            return result;
        }

        private static Expression UnwrapObjectConvert(Expression input)
        {
            if (input.NodeType == ExpressionType.Constant && input.Type == typeof(object))
            {
                ConstantExpression constant = (ConstantExpression)input;

                if (constant.Value != null &&
                    constant.Value.GetType() != typeof(object))
                {
                    return Expression.Constant(constant.Value, constant.Value.GetType());
                }
            }

            while (ExpressionType.Convert == input.NodeType && typeof(object) == input.Type)
            {
                input = ((UnaryExpression)input).Operand;
            }

            return input;
        }

        private static bool IsConstantZero(Expression expression)
        {
            return expression.NodeType == ExpressionType.Constant &&
                ((ConstantExpression)expression).Value.Equals(0);
        }

        internal override Expression VisitMethodCall(MethodCallExpression call)
        {
            Expression visited = VisitMethodCallNoRewrite(call);
            RecordRewrite(call, visited);
            return visited;
        }

        internal Expression VisitMethodCallNoRewrite(MethodCallExpression call)
        {
            MethodCallExpression visited = (MethodCallExpression)base.VisitMethodCall(call);

            if (visited.Method.IsStatic && visited.Method.Name.StartsWith("op_", StringComparison.Ordinal))
            {
                if (visited.Arguments.Count == 2)
                {
                    switch (visited.Method.Name)
                    {
                        case "op_Equality":
                            return Expression.Equal(visited.Arguments[0], visited.Arguments[1], LiftToNull, visited.Method);

                        case "op_Inequality":
                            return Expression.NotEqual(visited.Arguments[0], visited.Arguments[1], LiftToNull, visited.Method);

                        case "op_GreaterThan":
                            return Expression.GreaterThan(visited.Arguments[0], visited.Arguments[1], LiftToNull, visited.Method);

                        case "op_GreaterThanOrEqual":
                            return Expression.GreaterThanOrEqual(visited.Arguments[0], visited.Arguments[1], LiftToNull, visited.Method);

                        case "op_LessThan":
                            return Expression.LessThan(visited.Arguments[0], visited.Arguments[1], LiftToNull, visited.Method);

                        case "op_LessThanOrEqual":
                            return Expression.LessThanOrEqual(visited.Arguments[0], visited.Arguments[1], LiftToNull, visited.Method);

                        case "op_Multiply":
                            return Expression.Multiply(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_Subtraction":
                            return Expression.Subtract(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_Addition":
                            return Expression.Add(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_Division":
                            return Expression.Divide(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_Modulus":
                            return Expression.Modulo(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_BitwiseAnd":
                            return Expression.And(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_BitwiseOr":
                            return Expression.Or(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        case "op_ExclusiveOr":
                            return Expression.ExclusiveOr(visited.Arguments[0], visited.Arguments[1], visited.Method);

                        default:
                            break;
                    }
                }

                if (visited.Arguments.Count == 1)
                {
                    switch (visited.Method.Name)
                    {
                        case "op_UnaryNegation":
                            return Expression.Negate(visited.Arguments[0], visited.Method);

                        case "op_UnaryPlus":
                            return Expression.UnaryPlus(visited.Arguments[0], visited.Method);

                        case "op_Explicit":
                        case "op_Implicit":
                            return Expression.Convert(visited.Arguments[0], visited.Type, visited.Method);

                        case "op_OnesComplement":
                        case "op_False":
                            return Expression.Not(visited.Arguments[0], visited.Method);

                        default:
                            break;
                    }
                }
            }

            if (visited.Method.IsStatic && visited.Method.Name == "Equals" && visited.Arguments.Count > 1)
            {
                return Expression.Equal(visited.Arguments[0], visited.Arguments[1], false, visited.Method);
            }

            if (!visited.Method.IsStatic && visited.Method.Name == "Equals" && visited.Arguments.Count > 0)
            {
                return CreateRelationalOperator(ExpressionType.Equal, visited.Object, visited.Arguments[0]);
            }

            if (visited.Method.IsStatic && visited.Method.Name == "CompareString" && visited.Method.DeclaringType.FullName == "Microsoft.VisualBasic.CompilerServices.Operators")
            {
                return CreateCompareExpression(visited.Arguments[0], visited.Arguments[1]);
            }

            if (!visited.Method.IsStatic && visited.Method.Name == "CompareTo" && visited.Arguments.Count == 1 && visited.Method.ReturnType == typeof(int))
            {
                return CreateCompareExpression(visited.Object, visited.Arguments[0]);
            }

            if (visited.Method.IsStatic && visited.Method.Name == "Compare" && visited.Arguments.Count > 1 && visited.Method.ReturnType == typeof(int))
            {
                return CreateCompareExpression(visited.Arguments[0], visited.Arguments[1]);
            }

            MethodCallExpression normalizedResult = NormalizePredicateArgument(visited);

            return normalizedResult;
        }

        private static MethodCallExpression NormalizePredicateArgument(MethodCallExpression callExpression)
        {
            MethodCallExpression result;

            if (HasPredicateArgument(callExpression, out int argumentOrdinal) &&
                TryMatchCoalescePattern(callExpression.Arguments[argumentOrdinal], out Expression normalizedArgument))
            {
                List<Expression> normalizedArguments = new List<Expression>(callExpression.Arguments);

                normalizedArguments[argumentOrdinal] = normalizedArgument;

                result = Expression.Call(callExpression.Object, callExpression.Method, normalizedArguments);
            }
            else
            {
                result = callExpression;
            }

            return result;
        }

        private static bool HasPredicateArgument(MethodCallExpression callExpression, out int argumentOrdinal)
        {
            argumentOrdinal = default(int);
            bool result = false;

            if (2 <= callExpression.Arguments.Count &&
                ReflectionUtil.TryIdentifySequenceMethod(callExpression.Method, out SequenceMethod sequenceMethod))
            {
                switch (sequenceMethod)
                {
                    case SequenceMethod.FirstPredicate:
                    case SequenceMethod.FirstOrDefaultPredicate:
                    case SequenceMethod.SinglePredicate:
                    case SequenceMethod.SingleOrDefaultPredicate:
                    case SequenceMethod.LastPredicate:
                    case SequenceMethod.LastOrDefaultPredicate:
                    case SequenceMethod.Where:
                    case SequenceMethod.WhereOrdinal:
                    case SequenceMethod.CountPredicate:
                    case SequenceMethod.LongCountPredicate:
                    case SequenceMethod.AnyPredicate:
                    case SequenceMethod.All:
                    case SequenceMethod.SkipWhile:
                    case SequenceMethod.SkipWhileOrdinal:
                    case SequenceMethod.TakeWhile:
                    case SequenceMethod.TakeWhileOrdinal:
                        argumentOrdinal = 1;
                        result = true;
                        break;
                }
            }

            return result;
        }

        private static bool TryMatchCoalescePattern(Expression expression, out Expression normalized)
        {
            normalized = null;
            bool result = false;

            if (expression.NodeType == ExpressionType.Quote)
            {
                UnaryExpression quote = (UnaryExpression)expression;
                if (TryMatchCoalescePattern(quote.Operand, out normalized))
                {
                    result = true;
                    normalized = Expression.Quote(normalized);
                }
            }
            else if (expression.NodeType == ExpressionType.Lambda)
            {
                LambdaExpression lambda = (LambdaExpression)expression;

                if (lambda.Body.NodeType == ExpressionType.Coalesce && lambda.Body.Type == typeof(bool))
                {
                    BinaryExpression coalesce = (BinaryExpression)lambda.Body;
                    if (coalesce.Right.NodeType == ExpressionType.Constant && false.Equals(((ConstantExpression)coalesce.Right).Value))
                    {
                        normalized = Expression.Lambda(lambda.Type, Expression.Convert(coalesce.Left, typeof(bool)), lambda.Parameters);
                        result = true;
                    }
                }
            }

            return result;
        }

        private static readonly MethodInfo StaticRelationalOperatorPlaceholderMethod = typeof(ExpressionNormalizer).GetMethod("RelationalOperatorPlaceholder", BindingFlags.Static | BindingFlags.NonPublic);

        private static bool RelationalOperatorPlaceholder<TLeft, TRight>(TLeft left, TRight right)
        {
            Debug.Assert(false, "This method should never be called. It exists merely to support creation of relational LINQ expressions.");
            return object.ReferenceEquals(left, right);
        }

        private static BinaryExpression CreateRelationalOperator(ExpressionType op, Expression left, Expression right)
        {
            if (!TryCreateRelationalOperator(op, left, right, out BinaryExpression result))
            {
                Debug.Assert(false, "CreateRelationalOperator has unknown op " + op);
            }

            return result;
        }

        private static bool TryCreateRelationalOperator(ExpressionType op, Expression left, Expression right, out BinaryExpression result)
        {
            MethodInfo relationalOperatorPlaceholderMethod = StaticRelationalOperatorPlaceholderMethod.MakeGenericMethod(left.Type, right.Type);

            switch (op)
            {
                case ExpressionType.Equal:
                    result = Expression.Equal(left, right, LiftToNull, relationalOperatorPlaceholderMethod);
                    return true;

                case ExpressionType.NotEqual:
                    result = Expression.NotEqual(left, right, LiftToNull, relationalOperatorPlaceholderMethod);
                    return true;

                case ExpressionType.LessThan:
                    result = Expression.LessThan(left, right, LiftToNull, relationalOperatorPlaceholderMethod);
                    return true;

                case ExpressionType.LessThanOrEqual:
                    result = Expression.LessThanOrEqual(left, right, LiftToNull, relationalOperatorPlaceholderMethod);
                    return true;

                case ExpressionType.GreaterThan:
                    result = Expression.GreaterThan(left, right, LiftToNull, relationalOperatorPlaceholderMethod);
                    return true;

                case ExpressionType.GreaterThanOrEqual:
                    result = Expression.GreaterThanOrEqual(left, right, LiftToNull, relationalOperatorPlaceholderMethod);
                    return true;

                default:
                    result = null;
                    return false;
            }
        }

        private Expression CreateCompareExpression(Expression left, Expression right)
        {
            Expression result = Expression.Condition(
                CreateRelationalOperator(ExpressionType.Equal, left, right),
                Expression.Constant(0),
                Expression.Condition(
                    CreateRelationalOperator(ExpressionType.GreaterThan, left, right),
                    Expression.Constant(1),
                    Expression.Constant(-1)));

            patterns[result] = new ComparePattern(left, right);

            return result;
        }

        private void RecordRewrite(Expression source, Expression rewritten)
        {
            Debug.Assert(source != null, "source != null");
            Debug.Assert(rewritten != null, "rewritten != null");
            Debug.Assert(NormalizerRewrites != null, "this.NormalizerRewrites != null");

            if (source != rewritten)
            {
                NormalizerRewrites.Add(rewritten, source);
            }
        }

        private abstract class Pattern
        {
            internal abstract PatternKind Kind { get; }
        }

        private enum PatternKind
        {
            Compare,
        }

        private sealed class ComparePattern : Pattern
        {
            internal ComparePattern(Expression left, Expression right)
            {
                Left = left;
                Right = right;
            }

            internal readonly Expression Left;

            internal readonly Expression Right;

            internal override PatternKind Kind
            {
                get { return PatternKind.Compare; }
            }
        }

    }
}
