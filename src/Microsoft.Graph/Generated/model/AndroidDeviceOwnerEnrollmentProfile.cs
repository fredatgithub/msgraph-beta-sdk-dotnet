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
    /// The type Android Device Owner Enrollment Profile.
    /// </summary>
    public partial class AndroidDeviceOwnerEnrollmentProfile : Entity
    {
    
		///<summary>
		/// The AndroidDeviceOwnerEnrollmentProfile constructor
		///</summary>
        public AndroidDeviceOwnerEnrollmentProfile()
        {
            this.ODataType = "microsoft.graph.androidDeviceOwnerEnrollmentProfile";
        }
	
        /// <summary>
        /// Gets or sets account id.
        /// Tenant GUID the enrollment profile belongs to.
        /// </summary>
        [JsonPropertyName("accountId")]
        public string AccountId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date time the enrollment profile was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description for the enrollment profile.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name for the enrollment profile.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enrolled device count.
        /// Total number of Android devices that have enrolled using this enrollment profile.
        /// </summary>
        [JsonPropertyName("enrolledDeviceCount")]
        public Int32? EnrolledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment mode.
        /// The enrollment mode of devices that use this enrollment profile. Possible values are: corporateOwnedDedicatedDevice, corporateOwnedFullyManaged, corporateOwnedWorkProfile.
        /// </summary>
        [JsonPropertyName("enrollmentMode")]
        public AndroidDeviceOwnerEnrollmentMode? EnrollmentMode { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment token type.
        /// The enrollment token type for an enrollment profile. Possible values are: default, corporateOwnedDedicatedDeviceWithAzureADSharedMode.
        /// </summary>
        [JsonPropertyName("enrollmentTokenType")]
        public AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Date time the enrollment profile was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets qr code content.
        /// String used to generate a QR code for the token.
        /// </summary>
        [JsonPropertyName("qrCodeContent")]
        public string QrCodeContent { get; set; }
    
        /// <summary>
        /// Gets or sets qr code image.
        /// String used to generate a QR code for the token.
        /// </summary>
        [JsonPropertyName("qrCodeImage")]
        public MimeContent QrCodeImage { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets token creation date time.
        /// Date time the most recently created token was created.
        /// </summary>
        [JsonPropertyName("tokenCreationDateTime")]
        public DateTimeOffset? TokenCreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token expiration date time.
        /// Date time the most recently created token will expire.
        /// </summary>
        [JsonPropertyName("tokenExpirationDateTime")]
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token value.
        /// Value of the most recently created token for this enrollment profile.
        /// </summary>
        [JsonPropertyName("tokenValue")]
        public string TokenValue { get; set; }
    
    }
}

