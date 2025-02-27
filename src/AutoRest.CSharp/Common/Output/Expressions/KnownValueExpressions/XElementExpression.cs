﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Xml.Linq;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using static AutoRest.CSharp.Common.Output.Models.Snippets;

namespace AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions
{
    internal sealed record XElementExpression(ValueExpression Untyped) : TypedValueExpression<XElement>(Untyped)
    {
        public XNameExpression Name => new(Property(nameof(XElement.Name)));
        public StringExpression Value => new(Property(nameof(XElement.Value)));

        public XAttributeExpression Attribute(string name)
            => new(Invoke(nameof(XElement.Attribute), Literal(name)));

        public ValueExpression GetBytesFromBase64Value(string? format) => Extensible.XElement.GetBytesFromBase64Value(this, format);
        public ValueExpression GetDateTimeOffsetValue(string? format) => Extensible.XElement.GetDateTimeOffsetValue(this, format);
        public ValueExpression GetObjectValue(string? format) => Extensible.XElement.GetObjectValue(this, format);
        public ValueExpression GetTimeSpanValue(string? format) => Extensible.XElement.GetTimeSpanValue(this, format);
    }

    internal sealed record XAttributeExpression(ValueExpression Untyped) : TypedValueExpression<XAttribute>(Untyped)
    {
        public XNameExpression Name => new(Property(nameof(XAttribute.Name)));
        public StringExpression Value => new(Property(nameof(XAttribute.Value)));
    }
}
