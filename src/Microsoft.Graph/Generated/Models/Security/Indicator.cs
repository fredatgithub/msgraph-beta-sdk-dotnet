using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class Indicator : Entity, IParsable {
        /// <summary>The artifact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.Artifact? Artifact {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Artifact?>("artifact"); }
            set { BackingStore?.Set("artifact", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.Artifact Artifact {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Artifact>("artifact"); }
            set { BackingStore?.Set("artifact", value); }
        }
#endif
        /// <summary>The source property</summary>
        public IndicatorSource? Source {
            get { return BackingStore?.Get<IndicatorSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Indicator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.articleIndicator" => new ArticleIndicator(),
                "#microsoft.graph.security.intelligenceProfileIndicator" => new IntelligenceProfileIndicator(),
                _ => new Indicator(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"artifact", n => { Artifact = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.Artifact>(Microsoft.Graph.Beta.Models.Security.Artifact.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetEnumValue<IndicatorSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.Artifact>("artifact", Artifact);
            writer.WriteEnumValue<IndicatorSource>("source", Source);
        }
    }
}
