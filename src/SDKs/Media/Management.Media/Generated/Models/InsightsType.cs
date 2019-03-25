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
    /// Defines values for InsightsType.
    /// </summary>
    public static class InsightsType
    {
        /// <summary>
        /// Generate audio only insights. Ignore video even if present. Fails
        /// if no audio is present.
        /// </summary>
        public const string AudioInsightsOnly = "AudioInsightsOnly";
        /// <summary>
        /// Generate video only insights. Ignore audio if present. Fails if no
        /// video is present.
        /// </summary>
        public const string VideoInsightsOnly = "VideoInsightsOnly";
        /// <summary>
        /// Generate both audio and video insights. Fails if either audio or
        /// video Insights fail.
        /// </summary>
        public const string AllInsights = "AllInsights";
    }
}
