using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class Run : Entity, IParsable {
        /// <summary>The date time that the run completed. Value is null if the workflow hasn&apos;t completed. Optional.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The number of tasks that failed in the run execution. Required.</summary>
        public int? FailedTasksCount {
            get { return BackingStore?.Get<int?>("failedTasksCount"); }
            set { BackingStore?.Set("failedTasksCount", value); }
        }
        /// <summary>The number of users that failed in the run execution. Required.</summary>
        public int? FailedUsersCount {
            get { return BackingStore?.Get<int?>("failedUsersCount"); }
            set { BackingStore?.Set("failedUsersCount", value); }
        }
        /// <summary>The datetime that the run was last updated. Optional.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The processingStatus property</summary>
        public LifecycleWorkflowProcessingStatus? ProcessingStatus {
            get { return BackingStore?.Get<LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The date time that the run is scheduled to be executed for a workflow. Required.</summary>
        public DateTimeOffset? ScheduledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("scheduledDateTime"); }
            set { BackingStore?.Set("scheduledDateTime", value); }
        }
        /// <summary>The date time that the run execution started. Optional.</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The number of successfully completed users in the run. Required.</summary>
        public int? SuccessfulUsersCount {
            get { return BackingStore?.Get<int?>("successfulUsersCount"); }
            set { BackingStore?.Set("successfulUsersCount", value); }
        }
        /// <summary>The related taskProcessingResults.</summary>
        public List<TaskProcessingResult> TaskProcessingResults {
            get { return BackingStore?.Get<List<TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
        /// <summary>The totalTasksCount property</summary>
        public int? TotalTasksCount {
            get { return BackingStore?.Get<int?>("totalTasksCount"); }
            set { BackingStore?.Set("totalTasksCount", value); }
        }
        /// <summary>The total number of unprocessed tasks in the run execution. Required.</summary>
        public int? TotalUnprocessedTasksCount {
            get { return BackingStore?.Get<int?>("totalUnprocessedTasksCount"); }
            set { BackingStore?.Set("totalUnprocessedTasksCount", value); }
        }
        /// <summary>The total number of users in the workflow execution. Required.</summary>
        public int? TotalUsersCount {
            get { return BackingStore?.Get<int?>("totalUsersCount"); }
            set { BackingStore?.Set("totalUsersCount", value); }
        }
        /// <summary>The associated individual user execution.</summary>
        public List<UserProcessingResult> UserProcessingResults {
            get { return BackingStore?.Get<List<UserProcessingResult>>("userProcessingResults"); }
            set { BackingStore?.Set("userProcessingResults", value); }
        }
        /// <summary>The workflowExecutionType property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowExecutionType? WorkflowExecutionType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowExecutionType?>("workflowExecutionType"); }
            set { BackingStore?.Set("workflowExecutionType", value); }
        }
        /// <summary>
        /// Instantiates a new Run and sets the default values.
        /// </summary>
        public Run() : base() {
            OdataType = "#microsoft.graph.identityGovernance.run";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Run CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Run();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"failedTasksCount", n => { FailedTasksCount = n.GetIntValue(); } },
                {"failedUsersCount", n => { FailedUsersCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<LifecycleWorkflowProcessingStatus>(); } },
                {"scheduledDateTime", n => { ScheduledDateTime = n.GetDateTimeOffsetValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulUsersCount", n => { SuccessfulUsersCount = n.GetIntValue(); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue).ToList(); } },
                {"totalTasksCount", n => { TotalTasksCount = n.GetIntValue(); } },
                {"totalUnprocessedTasksCount", n => { TotalUnprocessedTasksCount = n.GetIntValue(); } },
                {"totalUsersCount", n => { TotalUsersCount = n.GetIntValue(); } },
                {"userProcessingResults", n => { UserProcessingResults = n.GetCollectionOfObjectValues<UserProcessingResult>(UserProcessingResult.CreateFromDiscriminatorValue).ToList(); } },
                {"workflowExecutionType", n => { WorkflowExecutionType = n.GetEnumValue<WorkflowExecutionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedTasksCount", FailedTasksCount);
            writer.WriteIntValue("failedUsersCount", FailedUsersCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteDateTimeOffsetValue("scheduledDateTime", ScheduledDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteIntValue("successfulUsersCount", SuccessfulUsersCount);
            writer.WriteCollectionOfObjectValues<TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalTasksCount", TotalTasksCount);
            writer.WriteIntValue("totalUnprocessedTasksCount", TotalUnprocessedTasksCount);
            writer.WriteIntValue("totalUsersCount", TotalUsersCount);
            writer.WriteCollectionOfObjectValues<UserProcessingResult>("userProcessingResults", UserProcessingResults);
            writer.WriteEnumValue<WorkflowExecutionType>("workflowExecutionType", WorkflowExecutionType);
        }
    }
}
