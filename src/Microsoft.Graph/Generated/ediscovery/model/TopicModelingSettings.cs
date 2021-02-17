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
    /// The type TopicModelingSettings.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<TopicModelingSettings>))]
    public partial class TopicModelingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicModelingSettings"/> class.
        /// </summary>
        public TopicModelingSettings()
        {
            this.ODataType = "microsoft.graph.ediscovery.topicModelingSettings";
        }

        /// <summary>
        /// Gets or sets dynamicallyAdjustTopicCount.
        /// </summary>
        [JsonPropertyName("dynamicallyAdjustTopicCount")]
        public bool? DynamicallyAdjustTopicCount { get; set; }
    
        /// <summary>
        /// Gets or sets ignoreNumbers.
        /// </summary>
        [JsonPropertyName("ignoreNumbers")]
        public bool? IgnoreNumbers { get; set; }
    
        /// <summary>
        /// Gets or sets isEnabled.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets topicCount.
        /// </summary>
        [JsonPropertyName("topicCount")]
        public Int32? TopicCount { get; set; }
    
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
