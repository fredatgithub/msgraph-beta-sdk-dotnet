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
    /// The type IosVpnSecurityAssociationParameters.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosVpnSecurityAssociationParameters>))]
    public partial class IosVpnSecurityAssociationParameters
    {

        /// <summary>
        /// Gets or sets lifetimeInMinutes.
        /// Lifetime (minutes)
        /// </summary>
        [JsonPropertyName("lifetimeInMinutes")]
        public Int32? LifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets securityDiffieHellmanGroup.
        /// Diffie-Hellman Group
        /// </summary>
        [JsonPropertyName("securityDiffieHellmanGroup")]
        public Int32? SecurityDiffieHellmanGroup { get; set; }
    
        /// <summary>
        /// Gets or sets securityEncryptionAlgorithm.
        /// Encryption algorithm. Possible values are: aes256, des, tripleDes, aes128, aes128Gcm, aes256Gcm, aes192, aes192Gcm.
        /// </summary>
        [JsonPropertyName("securityEncryptionAlgorithm")]
        public VpnEncryptionAlgorithmType? SecurityEncryptionAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets securityIntegrityAlgorithm.
        /// Integrity algorithm. Possible values are: sha2_256, sha1_96, sha1_160, sha2_384, sha2_512, md5.
        /// </summary>
        [JsonPropertyName("securityIntegrityAlgorithm")]
        public VpnIntegrityAlgorithmType? SecurityIntegrityAlgorithm { get; set; }
    
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
