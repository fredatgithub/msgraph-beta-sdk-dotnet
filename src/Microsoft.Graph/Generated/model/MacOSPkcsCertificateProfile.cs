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
    /// The type Mac OSPkcs Certificate Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSPkcsCertificateProfile>))]
    public partial class MacOSPkcsCertificateProfile : MacOSCertificateProfileBase
    {
    
        ///<summary>
        /// The MacOSPkcsCertificateProfile constructor
        ///</summary>
        public MacOSPkcsCertificateProfile()
        {
            this.ODataType = "microsoft.graph.macOSPkcsCertificateProfile";
        }
    
        /// <summary>
        /// Gets or sets allow all apps access.
        /// AllowAllAppsAccess setting
        /// </summary>
        [JsonPropertyName("allowAllAppsAccess")]
        public bool? AllowAllAppsAccess { get; set; }
    
        /// <summary>
        /// Gets or sets certificate store.
        /// Target store certificate. Possible values are: user, machine.
        /// </summary>
        [JsonPropertyName("certificateStore")]
        public CertificateStore? CertificateStore { get; set; }
    
        /// <summary>
        /// Gets or sets certificate template name.
        /// PKCS certificate template name.
        /// </summary>
        [JsonPropertyName("certificateTemplateName")]
        public string CertificateTemplateName { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority.
        /// PKCS certification authority FQDN.
        /// </summary>
        [JsonPropertyName("certificationAuthority")]
        public string CertificationAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority name.
        /// PKCS certification authority Name.
        /// </summary>
        [JsonPropertyName("certificationAuthorityName")]
        public string CertificationAuthorityName { get; set; }
    
        /// <summary>
        /// Gets or sets custom subject alternative names.
        /// Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("customSubjectAlternativeNames")]
        public IEnumerable<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// Format string that defines the subject alternative name.
        /// </summary>
        [JsonPropertyName("subjectAlternativeNameFormatString")]
        public string SubjectAlternativeNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format string.
        /// Format string that defines the subject name. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US
        /// </summary>
        [JsonPropertyName("subjectNameFormatString")]
        public string SubjectNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates")]
        public IMacOSPkcsCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceCertificateStatesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates@odata.nextLink")]
        public string ManagedDeviceCertificateStatesNextLink { get; set; }
    
    }
}

