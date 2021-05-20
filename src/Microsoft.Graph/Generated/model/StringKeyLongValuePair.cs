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
    /// The type StringKeyLongValuePair.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<StringKeyLongValuePair>))]
    public partial class StringKeyLongValuePair
    {

        /// <summary>
        /// Gets or sets key.
        /// Key.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Value.
        /// </summary>
        [JsonPropertyName("value")]
        public Int64? Value { get; set; }
    
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
