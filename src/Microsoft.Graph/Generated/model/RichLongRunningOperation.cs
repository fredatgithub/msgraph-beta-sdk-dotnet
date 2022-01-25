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
    /// The type Rich Long Running Operation.
    /// </summary>
    public partial class RichLongRunningOperation : LongRunningOperation
    {
    
        ///<summary>
        /// The RichLongRunningOperation constructor
        ///</summary>
        public RichLongRunningOperation()
        {
            this.ODataType = "microsoft.graph.richLongRunningOperation";
        }

        /// <summary>
        /// Gets or sets error.
        /// Error due to which the operation failed.
        /// </summary>
        [JsonPropertyName("error")]
        public PublicError Error { get; set; }
    
        /// <summary>
        /// Gets or sets percentage complete.
        /// A value between 0 and 100 that indicates the progress of the operation.
        /// </summary>
        [JsonPropertyName("percentageComplete")]
        public Int32? PercentageComplete { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// A unique identifier for the result.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Type of the operation.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    }
}

