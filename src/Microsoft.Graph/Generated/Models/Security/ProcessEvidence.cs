// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class ProcessEvidence : AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The status of the detection. The possible values are: detected, blocked, prevented, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.DetectionStatus? DetectionStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionStatus?>("detectionStatus"); }
            set { BackingStore?.Set("detectionStatus", value); }
        }
        /// <summary>Image file details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FileDetails? ImageFile
        {
            get { return BackingStore?.Get<FileDetails?>("imageFile"); }
            set { BackingStore?.Set("imageFile", value); }
        }
#nullable restore
#else
        public FileDetails ImageFile
        {
            get { return BackingStore?.Get<FileDetails>("imageFile"); }
            set { BackingStore?.Set("imageFile", value); }
        }
#endif
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId
        {
            get { return BackingStore?.Get<string?>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#nullable restore
#else
        public string MdeDeviceId
        {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#endif
        /// <summary>Date and time when the parent of the process was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ParentProcessCreationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("parentProcessCreationDateTime"); }
            set { BackingStore?.Set("parentProcessCreationDateTime", value); }
        }
        /// <summary>Process ID (PID) of the parent process that spawned the process.</summary>
        public long? ParentProcessId
        {
            get { return BackingStore?.Get<long?>("parentProcessId"); }
            set { BackingStore?.Set("parentProcessId", value); }
        }
        /// <summary>Parent process image file details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FileDetails? ParentProcessImageFile
        {
            get { return BackingStore?.Get<FileDetails?>("parentProcessImageFile"); }
            set { BackingStore?.Set("parentProcessImageFile", value); }
        }
#nullable restore
#else
        public FileDetails ParentProcessImageFile
        {
            get { return BackingStore?.Get<FileDetails>("parentProcessImageFile"); }
            set { BackingStore?.Set("parentProcessImageFile", value); }
        }
#endif
        /// <summary>Command line used to create the new process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessCommandLine
        {
            get { return BackingStore?.Get<string?>("processCommandLine"); }
            set { BackingStore?.Set("processCommandLine", value); }
        }
#nullable restore
#else
        public string ProcessCommandLine
        {
            get { return BackingStore?.Get<string>("processCommandLine"); }
            set { BackingStore?.Set("processCommandLine", value); }
        }
#endif
        /// <summary>Date and time when the process was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ProcessCreationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("processCreationDateTime"); }
            set { BackingStore?.Set("processCreationDateTime", value); }
        }
        /// <summary>Process ID (PID) of the newly created process.</summary>
        public long? ProcessId
        {
            get { return BackingStore?.Get<long?>("processId"); }
            set { BackingStore?.Set("processId", value); }
        }
        /// <summary>User details of the user that ran the process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.UserAccount? UserAccount
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.UserAccount?>("userAccount"); }
            set { BackingStore?.Set("userAccount", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.UserAccount UserAccount
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.UserAccount>("userAccount"); }
            set { BackingStore?.Set("userAccount", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ProcessEvidence"/> and sets the default values.
        /// </summary>
        public ProcessEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.processEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProcessEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProcessEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProcessEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "detectionStatus", n => { DetectionStatus = n.GetEnumValue<DetectionStatus>(); } },
                { "imageFile", n => { ImageFile = n.GetObjectValue<FileDetails>(FileDetails.CreateFromDiscriminatorValue); } },
                { "mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                { "parentProcessCreationDateTime", n => { ParentProcessCreationDateTime = n.GetDateTimeOffsetValue(); } },
                { "parentProcessId", n => { ParentProcessId = n.GetLongValue(); } },
                { "parentProcessImageFile", n => { ParentProcessImageFile = n.GetObjectValue<FileDetails>(FileDetails.CreateFromDiscriminatorValue); } },
                { "processCommandLine", n => { ProcessCommandLine = n.GetStringValue(); } },
                { "processCreationDateTime", n => { ProcessCreationDateTime = n.GetDateTimeOffsetValue(); } },
                { "processId", n => { ProcessId = n.GetLongValue(); } },
                { "userAccount", n => { UserAccount = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.UserAccount>(Microsoft.Graph.Beta.Models.Security.UserAccount.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DetectionStatus>("detectionStatus", DetectionStatus);
            writer.WriteObjectValue<FileDetails>("imageFile", ImageFile);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteDateTimeOffsetValue("parentProcessCreationDateTime", ParentProcessCreationDateTime);
            writer.WriteLongValue("parentProcessId", ParentProcessId);
            writer.WriteObjectValue<FileDetails>("parentProcessImageFile", ParentProcessImageFile);
            writer.WriteStringValue("processCommandLine", ProcessCommandLine);
            writer.WriteDateTimeOffsetValue("processCreationDateTime", ProcessCreationDateTime);
            writer.WriteLongValue("processId", ProcessId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.UserAccount>("userAccount", UserAccount);
        }
    }
}
