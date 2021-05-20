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
    /// The type Windows81Certificate Profile Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows81CertificateProfileBase>))]
    public partial class Windows81CertificateProfileBase : WindowsCertificateProfileBase
    {
    
        ///<summary>
        /// The internal Windows81CertificateProfileBase constructor
        ///</summary>
        protected internal Windows81CertificateProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets custom subject alternative names.
        /// Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("customSubjectAlternativeNames")]
        public IEnumerable<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("extendedKeyUsages")]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
    }
}

