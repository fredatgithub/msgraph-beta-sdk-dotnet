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
    /// The type Compliance.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Compliance>))]
    public partial class Compliance
    {
    
        /// <summary>
        /// Gets or sets subject rights requests.
        /// </summary>
        [JsonPropertyName("subjectRightsRequests")]
        public IComplianceSubjectRightsRequestsCollectionPage SubjectRightsRequests { get; set; }

        /// <summary>
        /// Gets or sets subjectRightsRequestsNextLink.
        /// </summary>
        [JsonPropertyName("subjectRightsRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SubjectRightsRequestsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets ediscovery.
        /// </summary>
        [JsonPropertyName("ediscovery")]
        public Microsoft.Graph.Ediscovery.Ediscoveryroot Ediscovery { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

