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
        /// Gets or sets customKeyIdentifier.
        /// Custom key identifier.
        /// </summary>
        [JsonPropertyName("customKeyIdentifier")]
        public byte[] CustomKeyIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The friendly name for the key.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets endDateTime.
        /// The date and time at which the credential expires. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets key.
        /// The value for the key credential. Should be a base-64 encoded value.
        /// </summary>
        [JsonPropertyName("key")]
        public byte[] Key { get; set; }
    
        /// <summary>
        /// Gets or sets keyId.
        /// The unique identifier (GUID) for the key.
        /// </summary>
        [JsonPropertyName("keyId")]
        public Guid? KeyId { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// The date and time at which the credential becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets thumbprint.
        /// The thumbprint value for the key.
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of key credential. 'AsymmetricX509Cert'.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets usage.
        /// A string that describes the purpose for which the key can be used. For example, 'Verify'.
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
