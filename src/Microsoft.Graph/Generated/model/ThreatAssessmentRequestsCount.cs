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
    /// The type ThreatAssessmentRequestsCount.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ThreatAssessmentRequestsCount>))]
    public partial class ThreatAssessmentRequestsCount
    {

        /// <summary>
        /// Gets or sets count.
        /// </summary>
        [JsonPropertyName("count")]
        public Int64? Count { get; set; }
    
        /// <summary>
        /// Gets or sets createdDateTime.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets pivotValue.
        /// </summary>
        [JsonPropertyName("pivotValue")]
        public string PivotValue { get; set; }
    
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
