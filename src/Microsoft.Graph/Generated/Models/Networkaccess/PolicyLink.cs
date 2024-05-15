// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class PolicyLink : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Policy? Policy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Policy?>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Policy Policy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Policy>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#endif
        /// <summary>The state property</summary>
        public Status? State
        {
            get { return BackingStore?.Get<Status?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyLink"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PolicyLink CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.filteringPolicyLink" => new FilteringPolicyLink(),
                "#microsoft.graph.networkaccess.forwardingPolicyLink" => new ForwardingPolicyLink(),
                _ => new PolicyLink(),
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
                { "policy", n => { Policy = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Policy>(Microsoft.Graph.Beta.Models.Networkaccess.Policy.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<Status>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Policy>("policy", Policy);
            writer.WriteEnumValue<Status>("state", State);
            writer.WriteStringValue("version", Version);
        }
    }
}
