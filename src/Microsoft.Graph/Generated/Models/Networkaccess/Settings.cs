// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class Settings : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The conditionalAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessSettings? ConditionalAccess
        {
            get { return BackingStore?.Get<ConditionalAccessSettings?>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#nullable restore
#else
        public ConditionalAccessSettings ConditionalAccess
        {
            get { return BackingStore?.Get<ConditionalAccessSettings>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#endif
        /// <summary>The crossTenantAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessSettings? CrossTenantAccess
        {
            get { return BackingStore?.Get<CrossTenantAccessSettings?>("crossTenantAccess"); }
            set { BackingStore?.Set("crossTenantAccess", value); }
        }
#nullable restore
#else
        public CrossTenantAccessSettings CrossTenantAccess
        {
            get { return BackingStore?.Get<CrossTenantAccessSettings>("crossTenantAccess"); }
            set { BackingStore?.Set("crossTenantAccess", value); }
        }
#endif
        /// <summary>The enrichedAuditLogs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs? EnrichedAuditLogs
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs?>("enrichedAuditLogs"); }
            set { BackingStore?.Set("enrichedAuditLogs", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs EnrichedAuditLogs
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs>("enrichedAuditLogs"); }
            set { BackingStore?.Set("enrichedAuditLogs", value); }
        }
#endif
        /// <summary>The forwardingOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions? ForwardingOptions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions?>("forwardingOptions"); }
            set { BackingStore?.Set("forwardingOptions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions ForwardingOptions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions>("forwardingOptions"); }
            set { BackingStore?.Set("forwardingOptions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Settings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Settings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Settings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<ConditionalAccessSettings>(ConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                { "crossTenantAccess", n => { CrossTenantAccess = n.GetObjectValue<CrossTenantAccessSettings>(CrossTenantAccessSettings.CreateFromDiscriminatorValue); } },
                { "enrichedAuditLogs", n => { EnrichedAuditLogs = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs>(Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs.CreateFromDiscriminatorValue); } },
                { "forwardingOptions", n => { ForwardingOptions = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions>(Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ConditionalAccessSettings>("conditionalAccess", ConditionalAccess);
            writer.WriteObjectValue<CrossTenantAccessSettings>("crossTenantAccess", CrossTenantAccess);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.EnrichedAuditLogs>("enrichedAuditLogs", EnrichedAuditLogs);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingOptions>("forwardingOptions", ForwardingOptions);
        }
    }
}
