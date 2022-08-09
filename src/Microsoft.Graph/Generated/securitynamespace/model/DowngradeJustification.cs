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
    /// The type DowngradeJustification.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DowngradeJustification>))]
    public partial class DowngradeJustification
    {

        /// <summary>
        /// Gets or sets isDowngradeJustified.
        /// Indicates whether the downgrade is or is not justified.
        /// </summary>
        [JsonPropertyName("isDowngradeJustified")]
        public bool? IsDowngradeJustified { get; set; }
    
        /// <summary>
        /// Gets or sets justificationMessage.
        /// Message that indicates why a downgrade is justified. The message will appear in administrative logs.
        /// </summary>
        [JsonPropertyName("justificationMessage")]
        public string JustificationMessage { get; set; }
    
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
