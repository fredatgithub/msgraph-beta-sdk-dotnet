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
    /// The type UserRegistrationFeatureCount.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserRegistrationFeatureCount>))]
    public partial class UserRegistrationFeatureCount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationFeatureCount"/> class.
        /// </summary>
        public UserRegistrationFeatureCount()
        {
            this.ODataType = "microsoft.graph.userRegistrationFeatureCount";
        }

        /// <summary>
        /// Gets or sets feature.
        /// Number of users registered or capable for Multi-Factor Authentication, Self-Service Password Reset and Passwordless Authentication. Possible values are: ssprRegistered, ssprEnabled, ssprCapable, passwordlessCapable, mfaCapable.
        /// </summary>
        [JsonPropertyName("feature")]
        public AuthenticationMethodFeature? Feature { get; set; }
    
        /// <summary>
        /// Gets or sets userCount.
        /// Number of users.
        /// </summary>
        [JsonPropertyName("userCount")]
        public Int64? UserCount { get; set; }
    
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
