// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class HostTracker : Artifact, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.Host? Host
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Host?>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.Host Host
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Host>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#endif
        /// <summary>The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kind
        {
            get { return BackingStore?.Get<string?>("kind"); }
            set { BackingStore?.Set("kind", value); }
        }
#nullable restore
#else
        public string Kind
        {
            get { return BackingStore?.Get<string>("kind"); }
            set { BackingStore?.Set("kind", value); }
        }
#endif
        /// <summary>The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The identification value for the hostTracker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value
        {
            get { return BackingStore?.Get<string?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public string Value
        {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="HostTracker"/> and sets the default values.
        /// </summary>
        public HostTracker() : base()
        {
            OdataType = "#microsoft.graph.security.hostTracker";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HostTracker"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HostTracker CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostTracker();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "host", n => { Host = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.Host>(Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue); } },
                { "kind", n => { Kind = n.GetStringValue(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "value", n => { Value = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.Host>("host", Host);
            writer.WriteStringValue("kind", Kind);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("value", Value);
        }
    }
}
