// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ContentLabel.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ContentLabel>))]
    public partial class ContentLabel
    {

        /// <summary>
        /// Gets or sets assignmentMethod.
        /// Describes whether the label was applied by an automated (standard) process or a person (privileged).
        /// </summary>
        [JsonPropertyName("assignmentMethod")]
        public AssignmentMethod? AssignmentMethod { get; set; }
    
        /// <summary>
        /// Gets or sets createdDateTime.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivityLabelId.
        /// </summary>
        [JsonPropertyName("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }
    
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
