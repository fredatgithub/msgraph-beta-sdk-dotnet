// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DriveItemAssignSensitivityLabelRequestBody.
    /// </summary>
    public partial class DriveItemAssignSensitivityLabelRequestBody
    {
    
        /// <summary>
        /// Gets or sets SensitivityLabelId.
        /// </summary>
        [JsonPropertyName("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }
    
        /// <summary>
        /// Gets or sets AssignmentMethod.
        /// </summary>
        [JsonPropertyName("assignmentMethod")]
        public SensitivityLabelAssignmentMethod? AssignmentMethod { get; set; }
    
        /// <summary>
        /// Gets or sets JustificationText.
        /// </summary>
        [JsonPropertyName("justificationText")]
        public string JustificationText { get; set; }
    
    }
}
