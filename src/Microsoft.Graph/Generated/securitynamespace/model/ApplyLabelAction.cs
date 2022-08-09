// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ApplyLabelAction.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ApplyLabelAction>))]
    public partial class ApplyLabelAction : InformationProtectionAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyLabelAction"/> class.
        /// </summary>
        public ApplyLabelAction()
        {
            this.ODataType = "microsoft.graph.security.applyLabelAction";
        }

        /// <summary>
        /// Gets or sets actions.
        /// The collection of actions that should be implemented by the caller.
        /// </summary>
        [JsonPropertyName("actions")]
        public IEnumerable<InformationProtectionAction> Actions { get; set; }
    
        /// <summary>
        /// Gets or sets actionSource.
        /// Specifies why the label was selected. Possible values are: manual, automatic, recommended, default.
        /// </summary>
        [JsonPropertyName("actionSource")]
        public ActionSource? ActionSource { get; set; }
    
        /// <summary>
        /// Gets or sets responsibleSensitiveTypeIds.
        /// If the label was the result of an automatic classification, supply the list of sensitive info type GUIDs that resulted in the returned label.
        /// </summary>
        [JsonPropertyName("responsibleSensitiveTypeIds")]
        public IEnumerable<string> ResponsibleSensitiveTypeIds { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivityLabelId.
        /// </summary>
        [JsonPropertyName("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }
    
    }
}
