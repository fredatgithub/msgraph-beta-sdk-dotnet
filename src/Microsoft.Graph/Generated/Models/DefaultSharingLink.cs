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
    public class DefaultSharingLink : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether the default link setting for this object is a direct URL rather than a sharing link.</summary>
        public bool? DefaultToExistingAccess
        {
            get { return BackingStore?.Get<bool?>("defaultToExistingAccess"); }
            set { BackingStore?.Set("defaultToExistingAccess", value); }
        }
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
        /// <summary>The default sharing link role. The possible values are: none, view, edit, manageList, review, restrictedView, submitOnly, unknownFutureValue.</summary>
        public SharingRole? Role
        {
            get { return BackingStore?.Get<SharingRole?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>The default sharing link scope. The possible values are: anyone, organization, specificPeople, anonymous, users, unknownFutureValue.</summary>
        public SharingScope? Scope
        {
            get { return BackingStore?.Get<SharingScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="DefaultSharingLink"/> and sets the default values.
        /// </summary>
        public DefaultSharingLink()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DefaultSharingLink"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DefaultSharingLink CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultSharingLink();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "defaultToExistingAccess", n => { DefaultToExistingAccess = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "role", n => { Role = n.GetEnumValue<SharingRole>(); } },
                { "scope", n => { Scope = n.GetEnumValue<SharingScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("defaultToExistingAccess", DefaultToExistingAccess);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SharingRole>("role", Role);
            writer.WriteEnumValue<SharingScope>("scope", Scope);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
