// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{

    /// <summary>
    /// Defines values for Priority.
    /// </summary>
    public static class Priority
    {
        /// <summary>
        /// Used for TransformOutputs that can be generated after Normal and
        /// High priority TransformOutputs.
        /// </summary>
        public const string Low = "Low";
        /// <summary>
        /// Used for TransformOutputs that can be generated at Normal priority.
        /// </summary>
        public const string Normal = "Normal";
        /// <summary>
        /// Used for TransformOutputs that should take precedence over others.
        /// </summary>
        public const string High = "High";
    }
}
