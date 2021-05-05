// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type OcrSettings.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<OcrSettings>))]
    public partial class OcrSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrSettings"/> class.
        /// </summary>
        public OcrSettings()
        {
            this.ODataType = "microsoft.graph.ediscovery.ocrSettings";
        }

        /// <summary>
        /// Gets or sets isEnabled.
        /// Indicates whether or not OCR is enabled for the case.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets maxImageSize.
        /// Maximum image size that will be processed in KB).
        /// </summary>
        [JsonPropertyName("maxImageSize")]
        public Int32? MaxImageSize { get; set; }
    
        /// <summary>
        /// Gets or sets timeout.
        /// The timeout duration for the OCR engine. A longer timeout may increase success of OCR, but may add to the total processing time.
        /// </summary>
        [JsonPropertyName("timeout")]
        public Microsoft.Graph.Duration Timeout { get; set; }
    
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
