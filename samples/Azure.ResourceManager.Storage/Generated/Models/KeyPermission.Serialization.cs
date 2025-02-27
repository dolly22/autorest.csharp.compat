// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class KeyPermissionExtensions
    {
        public static string ToSerialString(this KeyPermission value) => value switch
        {
            KeyPermission.Read => "Read",
            KeyPermission.Full => "Full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyPermission value.")
        };

        public static KeyPermission ToKeyPermission(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Read")) return KeyPermission.Read;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Full")) return KeyPermission.Full;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyPermission value.");
        }
    }
}
