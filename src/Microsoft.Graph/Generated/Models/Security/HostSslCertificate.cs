// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class HostSslCertificate : Artifact, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The first date and time that this hostSslCertificate was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The host for this hostSslCertificate.</summary>
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
        /// <summary>The most recent date and time that this hostSslCertificate was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The ports related with this hostSslCertificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostSslCertificatePort>? Ports
        {
            get { return BackingStore?.Get<List<HostSslCertificatePort>?>("ports"); }
            set { BackingStore?.Set("ports", value); }
        }
#nullable restore
#else
        public List<HostSslCertificatePort> Ports
        {
            get { return BackingStore?.Get<List<HostSslCertificatePort>>("ports"); }
            set { BackingStore?.Set("ports", value); }
        }
#endif
        /// <summary>The sslCertificate for this hostSslCertificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.SslCertificate? SslCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SslCertificate?>("sslCertificate"); }
            set { BackingStore?.Set("sslCertificate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.SslCertificate SslCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SslCertificate>("sslCertificate"); }
            set { BackingStore?.Set("sslCertificate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="HostSslCertificate"/> and sets the default values.
        /// </summary>
        public HostSslCertificate() : base()
        {
            OdataType = "#microsoft.graph.security.hostSslCertificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HostSslCertificate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HostSslCertificate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostSslCertificate();
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
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "ports", n => { Ports = n.GetCollectionOfObjectValues<HostSslCertificatePort>(HostSslCertificatePort.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sslCertificate", n => { SslCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.SslCertificate>(Microsoft.Graph.Beta.Models.Security.SslCertificate.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<HostSslCertificatePort>("ports", Ports);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.SslCertificate>("sslCertificate", SslCertificate);
        }
    }
}
