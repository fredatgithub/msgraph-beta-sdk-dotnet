// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    #pragma warning disable CS1591
    public class Edition : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The device family targeted by the edition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceFamily
        {
            get { return BackingStore?.Get<string?>("deviceFamily"); }
            set { BackingStore?.Set("deviceFamily", value); }
        }
#nullable restore
#else
        public string DeviceFamily
        {
            get { return BackingStore?.Get<string>("deviceFamily"); }
            set { BackingStore?.Set("deviceFamily", value); }
        }
#endif
        /// <summary>The date and time when the edition reached the end of service. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? EndOfServiceDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endOfServiceDateTime"); }
            set { BackingStore?.Set("endOfServiceDateTime", value); }
        }
        /// <summary>The date and time when the edition became available to the general customers for the first time. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? GeneralAvailabilityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("generalAvailabilityDateTime"); }
            set { BackingStore?.Set("generalAvailabilityDateTime", value); }
        }
        /// <summary>Indicates whether the edition is in service or out of service.</summary>
        public bool? IsInService
        {
            get { return BackingStore?.Get<bool?>("isInService"); }
            set { BackingStore?.Set("isInService", value); }
        }
        /// <summary>The name of the edition. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The public name of the edition. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReleasedName
        {
            get { return BackingStore?.Get<string?>("releasedName"); }
            set { BackingStore?.Set("releasedName", value); }
        }
#nullable restore
#else
        public string ReleasedName
        {
            get { return BackingStore?.Get<string>("releasedName"); }
            set { BackingStore?.Set("releasedName", value); }
        }
#endif
        /// <summary>The servicingPeriods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicingPeriod>? ServicingPeriods
        {
            get { return BackingStore?.Get<List<ServicingPeriod>?>("servicingPeriods"); }
            set { BackingStore?.Set("servicingPeriods", value); }
        }
#nullable restore
#else
        public List<ServicingPeriod> ServicingPeriods
        {
            get { return BackingStore?.Get<List<ServicingPeriod>>("servicingPeriods"); }
            set { BackingStore?.Set("servicingPeriods", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Edition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Edition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Edition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceFamily", n => { DeviceFamily = n.GetStringValue(); } },
                { "endOfServiceDateTime", n => { EndOfServiceDateTime = n.GetDateTimeOffsetValue(); } },
                { "generalAvailabilityDateTime", n => { GeneralAvailabilityDateTime = n.GetDateTimeOffsetValue(); } },
                { "isInService", n => { IsInService = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "releasedName", n => { ReleasedName = n.GetStringValue(); } },
                { "servicingPeriods", n => { ServicingPeriods = n.GetCollectionOfObjectValues<ServicingPeriod>(ServicingPeriod.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("deviceFamily", DeviceFamily);
            writer.WriteDateTimeOffsetValue("endOfServiceDateTime", EndOfServiceDateTime);
            writer.WriteDateTimeOffsetValue("generalAvailabilityDateTime", GeneralAvailabilityDateTime);
            writer.WriteBoolValue("isInService", IsInService);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("releasedName", ReleasedName);
            writer.WriteCollectionOfObjectValues<ServicingPeriod>("servicingPeriods", ServicingPeriods);
        }
    }
}
