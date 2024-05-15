// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CrossTenantAccessPolicyB2BSetting : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The list of applications targeted with your cross-tenant access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyTargetConfiguration? Applications
        {
            get { return BackingStore?.Get<CrossTenantAccessPolicyTargetConfiguration?>("applications"); }
            set { BackingStore?.Set("applications", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyTargetConfiguration Applications
        {
            get { return BackingStore?.Get<CrossTenantAccessPolicyTargetConfiguration>("applications"); }
            set { BackingStore?.Set("applications", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The list of users and groups targeted with your cross-tenant access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyTargetConfiguration? UsersAndGroups
        {
            get { return BackingStore?.Get<CrossTenantAccessPolicyTargetConfiguration?>("usersAndGroups"); }
            set { BackingStore?.Set("usersAndGroups", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyTargetConfiguration UsersAndGroups
        {
            get { return BackingStore?.Get<CrossTenantAccessPolicyTargetConfiguration>("usersAndGroups"); }
            set { BackingStore?.Set("usersAndGroups", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CrossTenantAccessPolicyB2BSetting"/> and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyB2BSetting()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CrossTenantAccessPolicyB2BSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CrossTenantAccessPolicyB2BSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.crossTenantAccessPolicyTenantRestrictions" => new CrossTenantAccessPolicyTenantRestrictions(),
                _ => new CrossTenantAccessPolicyB2BSetting(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applications", n => { Applications = n.GetObjectValue<CrossTenantAccessPolicyTargetConfiguration>(CrossTenantAccessPolicyTargetConfiguration.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "usersAndGroups", n => { UsersAndGroups = n.GetObjectValue<CrossTenantAccessPolicyTargetConfiguration>(CrossTenantAccessPolicyTargetConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CrossTenantAccessPolicyTargetConfiguration>("applications", Applications);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<CrossTenantAccessPolicyTargetConfiguration>("usersAndGroups", UsersAndGroups);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
