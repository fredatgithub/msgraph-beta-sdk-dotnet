using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationEventListener : Entity, IParsable {
        /// <summary>The identifier of the authenticationEventsFlow object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationEventsFlowId {
            get { return BackingStore?.Get<string?>("authenticationEventsFlowId"); }
            set { BackingStore?.Set("authenticationEventsFlowId", value); }
        }
#nullable restore
#else
        public string AuthenticationEventsFlowId {
            get { return BackingStore?.Get<string>("authenticationEventsFlowId"); }
            set { BackingStore?.Set("authenticationEventsFlowId", value); }
        }
#endif
        /// <summary>The conditions on which this authenticationEventListener should trigger.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationConditions? Conditions {
            get { return BackingStore?.Get<AuthenticationConditions?>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#nullable restore
#else
        public AuthenticationConditions Conditions {
            get { return BackingStore?.Get<AuthenticationConditions>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#endif
        /// <summary>The priority of this handler. Between 0 (lower priority) and 1000 (higher priority).</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationEventListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.onAttributeCollectionListener" => new OnAttributeCollectionListener(),
                "#microsoft.graph.onAuthenticationMethodLoadStartListener" => new OnAuthenticationMethodLoadStartListener(),
                "#microsoft.graph.onInteractiveAuthFlowStartListener" => new OnInteractiveAuthFlowStartListener(),
                "#microsoft.graph.onTokenIssuanceStartListener" => new OnTokenIssuanceStartListener(),
                "#microsoft.graph.onUserCreateStartListener" => new OnUserCreateStartListener(),
                _ => new AuthenticationEventListener(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationEventsFlowId", n => { AuthenticationEventsFlowId = n.GetStringValue(); } },
                {"conditions", n => { Conditions = n.GetObjectValue<AuthenticationConditions>(AuthenticationConditions.CreateFromDiscriminatorValue); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationEventsFlowId", AuthenticationEventsFlowId);
            writer.WriteObjectValue<AuthenticationConditions>("conditions", Conditions);
            writer.WriteIntValue("priority", Priority);
        }
    }
}
