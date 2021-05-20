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
    /// The type Share Point Activity User Counts.
    /// </summary>
    public partial class SharePointActivityUserCounts : Entity
    {
    
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
        /// Gets or sets shared externally.
        /// </summary>
        [JsonPropertyName("sharedExternally")]
        public Int64? SharedExternally { get; set; }
    
        /// <summary>
        /// Gets or sets shared internally.
        /// </summary>
        [JsonPropertyName("sharedInternally")]
        public Int64? SharedInternally { get; set; }
    
        /// <summary>
        /// Gets or sets synced.
        /// </summary>
        [JsonPropertyName("synced")]
        public Int64? Synced { get; set; }
    
        /// <summary>
        /// Gets or sets viewed or edited.
        /// </summary>
        [JsonPropertyName("viewedOrEdited")]
        public Int64? ViewedOrEdited { get; set; }
    
        /// <summary>
        /// Gets or sets visited page.
        /// </summary>
        [JsonPropertyName("visitedPage")]
        public Int64? VisitedPage { get; set; }
    
    }
}

