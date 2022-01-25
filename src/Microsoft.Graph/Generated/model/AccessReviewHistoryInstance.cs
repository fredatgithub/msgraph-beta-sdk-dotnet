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
    /// The type Access Review History Instance.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessReviewHistoryInstance>))]
    public partial class AccessReviewHistoryInstance : Entity
    {
    
        /// <summary>
        /// Gets or sets download uri.
        /// </summary>
        [JsonPropertyName("downloadUri")]
        public string DownloadUri { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets fulfilled date time.
        /// </summary>
        [JsonPropertyName("fulfilledDateTime")]
        public DateTimeOffset? FulfilledDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets review history period end date time.
        /// </summary>
        [JsonPropertyName("reviewHistoryPeriodEndDateTime")]
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets review history period start date time.
        /// </summary>
        [JsonPropertyName("reviewHistoryPeriodStartDateTime")]
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets run date time.
        /// </summary>
        [JsonPropertyName("runDateTime")]
        public DateTimeOffset? RunDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public AccessReviewHistoryStatus? Status { get; set; }
    
    }
}

