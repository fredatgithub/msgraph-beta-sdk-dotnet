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
    /// The type Onenote Page.
    /// </summary>
    public partial class OnenotePage : OnenoteEntitySchemaObjectModel
    {
    
        /// <summary>
        /// Gets or sets content.
        /// The page's HTML content.
        /// </summary>
        [JsonPropertyName("content")]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets content url.
        /// The URL for the page's HTML content.  Read-only.
        /// </summary>
        [JsonPropertyName("contentUrl")]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets created by app id.
        /// The unique identifier of the application that created the page. Read-only.
        /// </summary>
        [JsonPropertyName("createdByAppId")]
        public string CreatedByAppId { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets level.
        /// The indentation level of the page. Read-only.
        /// </summary>
        [JsonPropertyName("level")]
        public Int32? Level { get; set; }
    
        /// <summary>
        /// Gets or sets links.
        /// Links for opening the page. The oneNoteClientURL link opens the page in the OneNote native client if it 's installed. The oneNoteWebUrl link opens the page in OneNote on the web. Read-only.
        /// </summary>
        [JsonPropertyName("links")]
        public PageLinks Links { get; set; }
    
        /// <summary>
        /// Gets or sets order.
        /// The order of the page within its parent section. Read-only.
        /// </summary>
        [JsonPropertyName("order")]
        public Int32? Order { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The title of the page.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets user tags.
        /// </summary>
        [JsonPropertyName("userTags")]
        public IEnumerable<string> UserTags { get; set; }
    
        /// <summary>
        /// Gets or sets parent notebook.
        /// The notebook that contains the page.  Read-only.
        /// </summary>
        [JsonPropertyName("parentNotebook")]
        public Notebook ParentNotebook { get; set; }
    
        /// <summary>
        /// Gets or sets parent section.
        /// The section that contains the page. Read-only.
        /// </summary>
        [JsonPropertyName("parentSection")]
        public OnenoteSection ParentSection { get; set; }
    
    }
}

