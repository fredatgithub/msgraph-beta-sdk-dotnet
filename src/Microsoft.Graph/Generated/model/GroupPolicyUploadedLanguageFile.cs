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
    /// The type GroupPolicyUploadedLanguageFile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<GroupPolicyUploadedLanguageFile>))]
    public partial class GroupPolicyUploadedLanguageFile
    {

        /// <summary>
        /// Gets or sets content.
        /// The contents of the uploaded ADML file.
        /// </summary>
        [JsonPropertyName("content")]
        public byte[] Content { get; set; }
    
        /// <summary>
        /// Gets or sets fileName.
        /// The file name of the uploaded ADML file.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Key of the entity.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets languageCode.
        /// The language code of the uploaded ADML file.
        /// </summary>
        [JsonPropertyName("languageCode")]
        public string LanguageCode { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedDateTime.
        /// The date and time the entity was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
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
