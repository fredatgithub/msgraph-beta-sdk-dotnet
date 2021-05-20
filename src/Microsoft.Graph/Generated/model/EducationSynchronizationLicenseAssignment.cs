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
    /// The type EducationSynchronizationLicenseAssignment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EducationSynchronizationLicenseAssignment>))]
    public partial class EducationSynchronizationLicenseAssignment
    {

        /// <summary>
        /// Gets or sets appliesTo.
        /// The user role type to assign to license. Possible values are: student, teacher, faculty.
        /// </summary>
        [JsonPropertyName("appliesTo")]
        public EducationUserRole? AppliesTo { get; set; }
    
        /// <summary>
        /// Gets or sets skuIds.
        /// Represents the SKU identifiers of the licenses to assign.
        /// </summary>
        [JsonPropertyName("skuIds")]
        public IEnumerable<string> SkuIds { get; set; }
    
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
