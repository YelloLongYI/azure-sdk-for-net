// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AdminKeyKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdminKeyKind
    {
        [EnumMember(Value = "primary")]
        Primary,
        [EnumMember(Value = "secondary")]
        Secondary
    }
    internal static class AdminKeyKindEnumExtension
    {
        internal static string ToSerializedValue(this AdminKeyKind? value)
        {
            return value == null ? null : ((AdminKeyKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AdminKeyKind value)
        {
            switch( value )
            {
                case AdminKeyKind.Primary:
                    return "primary";
                case AdminKeyKind.Secondary:
                    return "secondary";
            }
            return null;
        }

        internal static AdminKeyKind? ParseAdminKeyKind(this string value)
        {
            switch( value )
            {
                case "primary":
                    return AdminKeyKind.Primary;
                case "secondary":
                    return AdminKeyKind.Secondary;
            }
            return null;
        }
    }
}