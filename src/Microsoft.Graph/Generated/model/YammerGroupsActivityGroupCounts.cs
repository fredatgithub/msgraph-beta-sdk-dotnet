// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Yammer Groups Activity Group Counts.
    /// </summary>
    public partial class YammerGroupsActivityGroupCounts : Entity
    {
    
        /// <summary>
        /// Gets or sets active.
        /// </summary>
        [JsonPropertyName("active")]
        public Int64? Active { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonPropertyName("reportDate")]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonPropertyName("reportPeriod")]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonPropertyName("reportRefreshDate")]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [JsonPropertyName("total")]
        public Int64? Total { get; set; }
    
    }
}

