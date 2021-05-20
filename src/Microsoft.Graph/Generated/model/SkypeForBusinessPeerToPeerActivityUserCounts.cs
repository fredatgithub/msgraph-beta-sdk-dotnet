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
    /// The type Skype For Business Peer To Peer Activity User Counts.
    /// </summary>
    public partial class SkypeForBusinessPeerToPeerActivityUserCounts : Entity
    {
    
        /// <summary>
        /// Gets or sets app sharing.
        /// </summary>
        [JsonPropertyName("appSharing")]
        public Int64? AppSharing { get; set; }
    
        /// <summary>
        /// Gets or sets audio.
        /// </summary>
        [JsonPropertyName("audio")]
        public Int64? Audio { get; set; }
    
        /// <summary>
        /// Gets or sets file transfer.
        /// </summary>
        [JsonPropertyName("fileTransfer")]
        public Int64? FileTransfer { get; set; }
    
        /// <summary>
        /// Gets or sets im.
        /// </summary>
        [JsonPropertyName("im")]
        public Int64? Im { get; set; }
    
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
        /// Gets or sets video.
        /// </summary>
        [JsonPropertyName("video")]
        public Int64? Video { get; set; }
    
    }
}

