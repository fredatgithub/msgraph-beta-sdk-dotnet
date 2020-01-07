// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MatchingDlpRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MatchingDlpRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingDlpRule"/> class.
        /// </summary>
        public MatchingDlpRule()
        {
            this.ODataType = "microsoft.graph.matchingDlpRule";
        }

        /// <summary>
        /// Gets or sets ruleId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ruleId", Required = Newtonsoft.Json.Required.Default)]
        public string RuleId { get; set; }
    
        /// <summary>
        /// Gets or sets ruleName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ruleName", Required = Newtonsoft.Json.Required.Default)]
        public string RuleName { get; set; }
    
        /// <summary>
        /// Gets or sets policyId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyId", Required = Newtonsoft.Json.Required.Default)]
        public string PolicyId { get; set; }
    
        /// <summary>
        /// Gets or sets policyName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyName", Required = Newtonsoft.Json.Required.Default)]
        public string PolicyName { get; set; }
    
        /// <summary>
        /// Gets or sets isMostRestrictive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMostRestrictive", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMostRestrictive { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "priority", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DlpActionInfo> Actions { get; set; }
    
        /// <summary>
        /// Gets or sets ruleMode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ruleMode", Required = Newtonsoft.Json.Required.Default)]
        public RuleMode? RuleMode { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}