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
    /// The type Person Annotation.
    /// </summary>
    public partial class PersonAnnotation : ItemFacet
    {
    
        /// <summary>
        /// Gets or sets detail.
        /// Contains the detail of the note itself.
        /// </summary>
        [JsonPropertyName("detail")]
        public ItemBody Detail { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Contains a friendly name for the note.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail url.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    
    }
}

