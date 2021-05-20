// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Credential User Registration Details.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CredentialUserRegistrationDetails>))]
    public partial class CredentialUserRegistrationDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets auth methods.
        /// Represents the authentication method that the user has registered. Possible values are: email, mobilePhone, officePhone,  securityQuestion (only used for self-service password reset), appNotification,  appCode, alternateMobilePhone (supported only in registration),  fido,  appPassword,  unknownFutureValue.
        /// </summary>
        [JsonPropertyName("authMethods")]
        public IEnumerable<RegistrationAuthMethod> AuthMethods { get; set; }
    
        /// <summary>
        /// Gets or sets is capable.
        /// Indicates whether the user is ready to perform self-service password reset or MFA.
        /// </summary>
        [JsonPropertyName("isCapable")]
        public bool? IsCapable { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates whether the user enabled to perform self-service password reset.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets is mfa registered.
        /// Indicates whether the user is registered for MFA.
        /// </summary>
        [JsonPropertyName("isMfaRegistered")]
        public bool? IsMfaRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets is registered.
        /// Indicates whether the user has registered any authentication methods for self-service password reset.
        /// </summary>
        [JsonPropertyName("isRegistered")]
        public bool? IsRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// Provides the user name of the corresponding user.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// Provides the user principal name of the corresponding user.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

