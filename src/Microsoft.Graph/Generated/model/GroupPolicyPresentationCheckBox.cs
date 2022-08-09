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
    /// The type Group Policy Presentation Check Box.
    /// </summary>
    public partial class GroupPolicyPresentationCheckBox : GroupPolicyUploadedPresentation
    {
    
        ///<summary>
        /// The GroupPolicyPresentationCheckBox constructor
        ///</summary>
        public GroupPolicyPresentationCheckBox()
        {
            this.ODataType = "microsoft.graph.groupPolicyPresentationCheckBox";
        }

        /// <summary>
        /// Gets or sets default checked.
        /// Default value for the check box. The default value is false.
        /// </summary>
        [JsonPropertyName("defaultChecked")]
        public bool? DefaultChecked { get; set; }
    
    }
}

