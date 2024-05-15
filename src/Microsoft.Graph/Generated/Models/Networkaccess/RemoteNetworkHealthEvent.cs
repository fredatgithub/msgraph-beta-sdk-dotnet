// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class RemoteNetworkHealthEvent : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of BGP routes advertised through tunnel.</summary>
        public int? BgpRoutesAdvertisedCount
        {
            get { return BackingStore?.Get<int?>("bgpRoutesAdvertisedCount"); }
            set { BackingStore?.Set("bgpRoutesAdvertisedCount", value); }
        }
        /// <summary>The time of the original event generation in UTC. Supports $filter (ge, le) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The IP address of the destination.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationIp
        {
            get { return BackingStore?.Get<string?>("destinationIp"); }
            set { BackingStore?.Set("destinationIp", value); }
        }
#nullable restore
#else
        public string DestinationIp
        {
            get { return BackingStore?.Get<string>("destinationIp"); }
            set { BackingStore?.Set("destinationIp", value); }
        }
#endif
        /// <summary>The number of bytes sent from the destination to the source.</summary>
        public long? ReceivedBytes
        {
            get { return BackingStore?.Get<long?>("receivedBytes"); }
            set { BackingStore?.Set("receivedBytes", value); }
        }
        /// <summary>A unique identifier for each remoteNetwork site. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteNetworkId
        {
            get { return BackingStore?.Get<string?>("remoteNetworkId"); }
            set { BackingStore?.Set("remoteNetworkId", value); }
        }
#nullable restore
#else
        public string RemoteNetworkId
        {
            get { return BackingStore?.Get<string>("remoteNetworkId"); }
            set { BackingStore?.Set("remoteNetworkId", value); }
        }
#endif
        /// <summary>The number of bytes sent from the source to the destination for the connection or session.</summary>
        public long? SentBytes
        {
            get { return BackingStore?.Get<long?>("sentBytes"); }
            set { BackingStore?.Set("sentBytes", value); }
        }
        /// <summary>The public IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceIp
        {
            get { return BackingStore?.Get<string?>("sourceIp"); }
            set { BackingStore?.Set("sourceIp", value); }
        }
#nullable restore
#else
        public string SourceIp
        {
            get { return BackingStore?.Get<string>("sourceIp"); }
            set { BackingStore?.Set("sourceIp", value); }
        }
#endif
        /// <summary>The status property</summary>
        public RemoteNetworkStatus? Status
        {
            get { return BackingStore?.Get<RemoteNetworkStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RemoteNetworkHealthEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoteNetworkHealthEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteNetworkHealthEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bgpRoutesAdvertisedCount", n => { BgpRoutesAdvertisedCount = n.GetIntValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "destinationIp", n => { DestinationIp = n.GetStringValue(); } },
                { "receivedBytes", n => { ReceivedBytes = n.GetLongValue(); } },
                { "remoteNetworkId", n => { RemoteNetworkId = n.GetStringValue(); } },
                { "sentBytes", n => { SentBytes = n.GetLongValue(); } },
                { "sourceIp", n => { SourceIp = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<RemoteNetworkStatus>(); } },
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
            writer.WriteIntValue("bgpRoutesAdvertisedCount", BgpRoutesAdvertisedCount);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("destinationIp", DestinationIp);
            writer.WriteLongValue("receivedBytes", ReceivedBytes);
            writer.WriteStringValue("remoteNetworkId", RemoteNetworkId);
            writer.WriteLongValue("sentBytes", SentBytes);
            writer.WriteStringValue("sourceIp", SourceIp);
            writer.WriteEnumValue<RemoteNetworkStatus>("status", Status);
        }
    }
}
