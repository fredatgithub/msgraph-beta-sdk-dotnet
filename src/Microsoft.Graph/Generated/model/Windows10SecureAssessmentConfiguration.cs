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
    /// The type Windows10Secure Assessment Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows10SecureAssessmentConfiguration>))]
    public partial class Windows10SecureAssessmentConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The Windows10SecureAssessmentConfiguration constructor
        ///</summary>
        public Windows10SecureAssessmentConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10SecureAssessmentConfiguration";
        }
    
        /// <summary>
        /// Gets or sets allow printing.
        /// Indicates whether or not to allow the app from printing during the test.
        /// </summary>
        [JsonPropertyName("allowPrinting")]
        public bool? AllowPrinting { get; set; }
    
        /// <summary>
        /// Gets or sets allow screen capture.
        /// Indicates whether or not to allow screen capture capability during a test.
        /// </summary>
        [JsonPropertyName("allowScreenCapture")]
        public bool? AllowScreenCapture { get; set; }
    
        /// <summary>
        /// Gets or sets allow text suggestion.
        /// Indicates whether or not to allow text suggestions during the test.
        /// </summary>
        [JsonPropertyName("allowTextSuggestion")]
        public bool? AllowTextSuggestion { get; set; }
    
        /// <summary>
        /// Gets or sets assessment app user model id.
        /// Specifies the application user model ID of the assessment app launched when a user signs in to a secure assessment with a local guest account. Important notice: this property must be set with localGuestAccountName in order to make the local guest account sign-in experience work properly for secure assessments.
        /// </summary>
        [JsonPropertyName("assessmentAppUserModelId")]
        public string AssessmentAppUserModelId { get; set; }
    
        /// <summary>
        /// Gets or sets configuration account.
        /// The account used to configure the Windows device for taking the test. The user can be a domain account (domain/user), an AAD account (username@tenant.com) or a local account (username).
        /// </summary>
        [JsonPropertyName("configurationAccount")]
        public string ConfigurationAccount { get; set; }
    
        /// <summary>
        /// Gets or sets configuration account type.
        /// The account type used to by ConfigurationAccount. Possible values are: azureADAccount, domainAccount, localAccount, localGuestAccount.
        /// </summary>
        [JsonPropertyName("configurationAccountType")]
        public SecureAssessmentAccountType? ConfigurationAccountType { get; set; }
    
        /// <summary>
        /// Gets or sets launch uri.
        /// Url link to an assessment that's automatically loaded when the secure assessment browser is launched. It has to be a valid Url (http[s]://msdn.microsoft.com/).
        /// </summary>
        [JsonPropertyName("launchUri")]
        public string LaunchUri { get; set; }
    
        /// <summary>
        /// Gets or sets local guest account name.
        /// Specifies the display text for the local guest account shown on the sign-in screen. Typically is the name of an assessment. When the user clicks the local guest account on the sign-in screen, an assessment app is launched with a specified assessment URL. Secure assessments can only be configured with local guest account sign-in on devices running Windows 10, version 1903 or later. Important notice: this property must be set with assessmentAppUserModelID in order to make the local guest account sign-in experience work properly for secure assessments.
        /// </summary>
        [JsonPropertyName("localGuestAccountName")]
        public string LocalGuestAccountName { get; set; }
    
    }
}

