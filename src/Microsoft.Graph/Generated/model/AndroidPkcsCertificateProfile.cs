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
    /// The type Android Pkcs Certificate Profile.
    /// </summary>
    public partial class AndroidPkcsCertificateProfile : AndroidCertificateProfileBase
    {
    
        ///<summary>
        /// The AndroidPkcsCertificateProfile constructor
        ///</summary>
        public AndroidPkcsCertificateProfile()
        {
            this.ODataType = "microsoft.graph.androidPkcsCertificateProfile";
        }
    
        /// <summary>
        /// Gets or sets certificate template name.
        /// PKCS Certificate Template Name
        /// </summary>
        [JsonPropertyName("certificateTemplateName")]
        public string CertificateTemplateName { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority.
        /// PKCS Certification Authority
        /// </summary>
        [JsonPropertyName("certificationAuthority")]
        public string CertificationAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority name.
        /// PKCS Certification Authority Name
        /// </summary>
        [JsonPropertyName("certificationAuthorityName")]
        public string CertificationAuthorityName { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// Custom String that defines the AAD Attribute.
        /// </summary>
        [JsonPropertyName("subjectAlternativeNameFormatString")]
        public string SubjectAlternativeNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates")]
        public IAndroidPkcsCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceCertificateStatesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates@odata.nextLink")]
        public string ManagedDeviceCertificateStatesNextLink { get; set; }
    
    }
}

