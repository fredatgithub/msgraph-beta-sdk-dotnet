// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class TenantAppManagementPolicy : PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Restrictions that apply as default to all application objects in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppManagementConfiguration? ApplicationRestrictions
        {
            get { return BackingStore?.Get<AppManagementConfiguration?>("applicationRestrictions"); }
            set { BackingStore?.Set("applicationRestrictions", value); }
        }
#nullable restore
#else
        public AppManagementConfiguration ApplicationRestrictions
        {
            get { return BackingStore?.Get<AppManagementConfiguration>("applicationRestrictions"); }
            set { BackingStore?.Set("applicationRestrictions", value); }
        }
#endif
        /// <summary>Denotes whether the policy is enabled. Default value is false.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Restrictions that apply as default to all service principal objects in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppManagementConfiguration? ServicePrincipalRestrictions
        {
            get { return BackingStore?.Get<AppManagementConfiguration?>("servicePrincipalRestrictions"); }
            set { BackingStore?.Set("servicePrincipalRestrictions", value); }
        }
#nullable restore
#else
        public AppManagementConfiguration ServicePrincipalRestrictions
        {
            get { return BackingStore?.Get<AppManagementConfiguration>("servicePrincipalRestrictions"); }
            set { BackingStore?.Set("servicePrincipalRestrictions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TenantAppManagementPolicy"/> and sets the default values.
        /// </summary>
        public TenantAppManagementPolicy() : base()
        {
            OdataType = "#microsoft.graph.tenantAppManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TenantAppManagementPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantAppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantAppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationRestrictions", n => { ApplicationRestrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "servicePrincipalRestrictions", n => { ServicePrincipalRestrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<AppManagementConfiguration>("applicationRestrictions", ApplicationRestrictions);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<AppManagementConfiguration>("servicePrincipalRestrictions", ServicePrincipalRestrictions);
        }
    }
}
