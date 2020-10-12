// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Outlook Task.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OutlookTask : OutlookItem
    {
    
		///<summary>
		/// The OutlookTask constructor
		///</summary>
        public OutlookTask()
        {
            this.ODataType = "microsoft.graph.outlookTask";
        }
	
        /// <summary>
        /// Gets or sets assigned to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedTo", Required = Newtonsoft.Json.Required.Default)]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets completed date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone CompletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets due date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dueDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone DueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets is reminder on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isReminderOn", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsReminderOn { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurrence", Required = Newtonsoft.Json.Required.Default)]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminder date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reminderDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone ReminderDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sensitivity", Required = Newtonsoft.Json.Required.Default)]
        public Sensitivity? Sensitivity { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public TaskStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Newtonsoft.Json.Required.Default)]
        public IOutlookTaskAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IOutlookTaskMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IOutlookTaskSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
    }
}
