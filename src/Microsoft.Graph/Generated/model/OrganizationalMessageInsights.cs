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
    /// The type OrganizationalMessageInsights.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OrganizationalMessageInsights>))]
    public partial class OrganizationalMessageInsights
    {

        /// <summary>
        /// Gets or sets clicks.
        /// The number of times this message was clicked on
        /// </summary>
        [JsonPropertyName("clicks")]
        public Int32? Clicks { get; set; }
    
        /// <summary>
        /// Gets or sets dismisses.
        /// The number of times this message was dismissed by a user. This may not be collected for some surfaces and will be null
        /// </summary>
        [JsonPropertyName("dismisses")]
        public Int32? Dismisses { get; set; }
    
        /// <summary>
        /// Gets or sets impressions.
        /// The number of times this message was shown to all clients
        /// </summary>
        [JsonPropertyName("impressions")]
        public Int32? Impressions { get; set; }
    
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
