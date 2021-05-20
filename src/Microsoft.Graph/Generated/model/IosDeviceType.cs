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
    /// The type IosDeviceType.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosDeviceType>))]
    public partial class IosDeviceType
    {

        /// <summary>
        /// Gets or sets iPad.
        /// Whether the app should run on iPads.
        /// </summary>
        [JsonPropertyName("iPad")]
        public bool? IPad { get; set; }
    
        /// <summary>
        /// Gets or sets iPhoneAndIPod.
        /// Whether the app should run on iPhones and iPods.
        /// </summary>
        [JsonPropertyName("iPhoneAndIPod")]
        public bool? IPhoneAndIPod { get; set; }
    
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
