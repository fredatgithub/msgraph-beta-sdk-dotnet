using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class MicrosoftTunnelHealthThreshold : Entity, IParsable {
        /// <summary>The default threshold for being healthy</summary>
        public int? DefaultHealthyThreshold { get; set; }
        /// <summary>The default threshold for being unhealthy</summary>
        public int? DefaultUnhealthyThreshold { get; set; }
        /// <summary>The threshold for being healthy</summary>
        public int? HealthyThreshold { get; set; }
        /// <summary>The threshold for being unhealthy</summary>
        public int? UnhealthyThreshold { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftTunnelHealthThreshold CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelHealthThreshold();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"defaultHealthyThreshold", (o,n) => { (o as MicrosoftTunnelHealthThreshold).DefaultHealthyThreshold = n.GetIntValue(); } },
                {"defaultUnhealthyThreshold", (o,n) => { (o as MicrosoftTunnelHealthThreshold).DefaultUnhealthyThreshold = n.GetIntValue(); } },
                {"healthyThreshold", (o,n) => { (o as MicrosoftTunnelHealthThreshold).HealthyThreshold = n.GetIntValue(); } },
                {"unhealthyThreshold", (o,n) => { (o as MicrosoftTunnelHealthThreshold).UnhealthyThreshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("defaultHealthyThreshold", DefaultHealthyThreshold);
            writer.WriteIntValue("defaultUnhealthyThreshold", DefaultUnhealthyThreshold);
            writer.WriteIntValue("healthyThreshold", HealthyThreshold);
            writer.WriteIntValue("unhealthyThreshold", UnhealthyThreshold);
        }
    }
}
