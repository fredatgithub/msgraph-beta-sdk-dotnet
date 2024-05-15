// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class Artifact : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Artifact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Artifact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.host" => new Host(),
                "#microsoft.graph.security.hostComponent" => new HostComponent(),
                "#microsoft.graph.security.hostCookie" => new HostCookie(),
                "#microsoft.graph.security.hostname" => new Hostname(),
                "#microsoft.graph.security.hostSslCertificate" => new HostSslCertificate(),
                "#microsoft.graph.security.hostTracker" => new HostTracker(),
                "#microsoft.graph.security.ipAddress" => new IpAddress(),
                "#microsoft.graph.security.passiveDnsRecord" => new PassiveDnsRecord(),
                "#microsoft.graph.security.sslCertificate" => new SslCertificate(),
                "#microsoft.graph.security.unclassifiedArtifact" => new UnclassifiedArtifact(),
                _ => new Artifact(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
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
        }
    }
}
