// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Blocked actions on the company portal as per platform and device ownership types
    /// </summary>
    public class CompanyPortalBlockedAction : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Action on a device that can be executed in the Company Portal</summary>
        public CompanyPortalAction? Action
        {
            get { return BackingStore?.Get<CompanyPortalAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
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
        /// <summary>Owner type of device.</summary>
        public Microsoft.Graph.Beta.Models.OwnerType? OwnerType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OwnerType?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
        /// <summary>Supported platform types.</summary>
        public DevicePlatformType? Platform
        {
            get { return BackingStore?.Get<DevicePlatformType?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="CompanyPortalBlockedAction"/> and sets the default values.
        /// </summary>
        public CompanyPortalBlockedAction()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CompanyPortalBlockedAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CompanyPortalBlockedAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompanyPortalBlockedAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<CompanyPortalAction>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "ownerType", n => { OwnerType = n.GetEnumValue<OwnerType>(); } },
                { "platform", n => { Platform = n.GetEnumValue<DevicePlatformType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CompanyPortalAction>("action", Action);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<OwnerType>("ownerType", OwnerType);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
