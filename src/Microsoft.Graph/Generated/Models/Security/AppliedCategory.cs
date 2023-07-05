using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AppliedCategory : FilePlanDescriptorBase, IParsable {
        /// <summary>Represents the file plan descriptor for a subcategory under a specific category, which has been assigned to a particular retention label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.SubCategory? SubCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SubCategory?>("subCategory"); }
            set { BackingStore?.Set("subCategory", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.SubCategory SubCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SubCategory>("subCategory"); }
            set { BackingStore?.Set("subCategory", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppliedCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"subCategory", n => { SubCategory = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.SubCategory>(Microsoft.Graph.Beta.Models.Security.SubCategory.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.SubCategory>("subCategory", SubCategory);
        }
    }
}
