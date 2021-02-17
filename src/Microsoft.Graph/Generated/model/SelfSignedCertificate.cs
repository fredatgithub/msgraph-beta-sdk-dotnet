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
    /// The type SelfSignedCertificate.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SelfSignedCertificate>))]
    public partial class SelfSignedCertificate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfSignedCertificate"/> class.
        /// </summary>
        public SelfSignedCertificate()
        {
            this.ODataType = "microsoft.graph.selfSignedCertificate";
        }

        /// <summary>
        /// Gets or sets customKeyIdentifier.
        /// </summary>
        [JsonPropertyName("customKeyIdentifier")]
        public byte[] CustomKeyIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets endDateTime.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets key.
        /// </summary>
        [JsonPropertyName("key")]
        public byte[] Key { get; set; }
    
        /// <summary>
        /// Gets or sets keyId.
        /// </summary>
        [JsonPropertyName("keyId")]
        public Guid? KeyId { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets thumbprint.
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets usage.
        /// </summary>
        [JsonPropertyName("usage")]
        public string Usage { get; set; }
    
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
