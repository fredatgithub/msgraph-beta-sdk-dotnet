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
    /// The type Exact Match Lookup Job.
    /// </summary>
    public partial class ExactMatchLookupJob : ExactMatchJobBase
    {
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets matching rows.
        /// </summary>
        [JsonPropertyName("matchingRows")]
        public IExactMatchLookupJobMatchingRowsCollectionPage MatchingRows { get; set; }

        /// <summary>
        /// Gets or sets matchingRowsNextLink.
        /// </summary>
        [JsonPropertyName("matchingRows@odata.nextLink")]
        public string MatchingRowsNextLink { get; set; }
    
    }
}

