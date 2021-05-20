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
    /// The type Password Authentication Method.
    /// </summary>
    public partial class PasswordAuthenticationMethod : AuthenticationMethod
    {
    
        ///<summary>
        /// The PasswordAuthenticationMethod constructor
        ///</summary>
        public PasswordAuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.passwordAuthenticationMethod";
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// The date and time when this password was last updated. This property is currently not populated. Read-only. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Obsolete("The creationDateTime property is deprecated and will stop returning data on December 31, 2020. Please use the createdDateTime property.")]
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets password.
        /// For security, the password is always returned as null from a LIST or GET operation.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    
    }
}

