// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Workflow Template.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<WorkflowTemplate>))]
    public partial class WorkflowTemplate : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets category.
        /// The category of the workflow template. The possible values are: joiner, leaver.
        /// </summary>
        [JsonPropertyName("category")]
        public LifecycleWorkflowCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the workflowTemplate.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the workflowTemplate. Supports  orderby.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets execution conditions.
        /// Conditions describing when to execute the workflow and the criteria to identify in-scope subject set.
        /// </summary>
        [JsonPropertyName("executionConditions")]
        public WorkflowExecutionConditions ExecutionConditions { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Represents the configured tasks to execute and their execution sequence within a workflow. This relationship is expanded by default.
        /// </summary>
        [JsonPropertyName("tasks")]
        public IWorkflowTemplateTasksCollectionPage Tasks { get; set; }

        /// <summary>
        /// Gets or sets tasksNextLink.
        /// </summary>
        [JsonPropertyName("tasks@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TasksNextLink { get; set; }
    
    }
}

