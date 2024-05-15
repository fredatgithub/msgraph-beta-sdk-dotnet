// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class HostPort : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The hostPortBanners retrieved from scanning the port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostPortBanner>? Banners
        {
            get { return BackingStore?.Get<List<HostPortBanner>?>("banners"); }
            set { BackingStore?.Set("banners", value); }
        }
#nullable restore
#else
        public List<HostPortBanner> Banners
        {
            get { return BackingStore?.Get<List<HostPortBanner>>("banners"); }
            set { BackingStore?.Set("banners", value); }
        }
#endif
        /// <summary>The first date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
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
        /// <summary>The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastScanDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastScanDateTime"); }
            set { BackingStore?.Set("lastScanDateTime", value); }
        }
        /// <summary>The last date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The most recent sslCertificate used to communicate on the port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SslCertificate? MostRecentSslCertificate
        {
            get { return BackingStore?.Get<SslCertificate?>("mostRecentSslCertificate"); }
            set { BackingStore?.Set("mostRecentSslCertificate", value); }
        }
#nullable restore
#else
        public SslCertificate MostRecentSslCertificate
        {
            get { return BackingStore?.Get<SslCertificate>("mostRecentSslCertificate"); }
            set { BackingStore?.Set("mostRecentSslCertificate", value); }
        }
#endif
        /// <summary>The numerical identifier of the port which is standardized across the internet.</summary>
        public int? Port
        {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>The general protocol used to scan the port. The possible values are: tcp, udp, unknownFutureValue.</summary>
        public HostPortProtocol? Protocol
        {
            get { return BackingStore?.Get<HostPortProtocol?>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
        /// <summary>The hostPortComponents retrieved from scanning the port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostPortComponent>? Services
        {
            get { return BackingStore?.Get<List<HostPortComponent>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<HostPortComponent> Services
        {
            get { return BackingStore?.Get<List<HostPortComponent>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>The status of the port. The possible values are: open, filtered, closed, unknownFutureValue.</summary>
        public HostPortStatus? Status
        {
            get { return BackingStore?.Get<HostPortStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.</summary>
        public int? TimesObserved
        {
            get { return BackingStore?.Get<int?>("timesObserved"); }
            set { BackingStore?.Set("timesObserved", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HostPort"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HostPort CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostPort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "banners", n => { Banners = n.GetCollectionOfObjectValues<HostPortBanner>(HostPortBanner.CreateFromDiscriminatorValue)?.ToList(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "host", n => { Host = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.Host>(Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue); } },
                { "lastScanDateTime", n => { LastScanDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "mostRecentSslCertificate", n => { MostRecentSslCertificate = n.GetObjectValue<SslCertificate>(SslCertificate.CreateFromDiscriminatorValue); } },
                { "port", n => { Port = n.GetIntValue(); } },
                { "protocol", n => { Protocol = n.GetEnumValue<HostPortProtocol>(); } },
                { "services", n => { Services = n.GetCollectionOfObjectValues<HostPortComponent>(HostPortComponent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "status", n => { Status = n.GetEnumValue<HostPortStatus>(); } },
                { "timesObserved", n => { TimesObserved = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<HostPortBanner>("banners", Banners);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.Host>("host", Host);
            writer.WriteDateTimeOffsetValue("lastScanDateTime", LastScanDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteObjectValue<SslCertificate>("mostRecentSslCertificate", MostRecentSslCertificate);
            writer.WriteIntValue("port", Port);
            writer.WriteEnumValue<HostPortProtocol>("protocol", Protocol);
            writer.WriteCollectionOfObjectValues<HostPortComponent>("services", Services);
            writer.WriteEnumValue<HostPortStatus>("status", Status);
            writer.WriteIntValue("timesObserved", TimesObserved);
        }
    }
}
