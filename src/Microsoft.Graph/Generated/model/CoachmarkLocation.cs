// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CoachmarkLocation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CoachmarkLocation>))]
    public partial class CoachmarkLocation
    {

        /// <summary>
        /// Gets or sets length.
        /// Length of coachmark.
        /// </summary>
        [JsonPropertyName("length")]
        public Int32? Length { get; set; }
    
        /// <summary>
        /// Gets or sets offset.
        /// Offset of coachmark.
        /// </summary>
        [JsonPropertyName("offset")]
        public Int32? Offset { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Type of coachmark location. The possible values are: unknown, fromEmail, subject, externalTag, displayName, messageBody, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("type")]
        public CoachmarkLocationType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
