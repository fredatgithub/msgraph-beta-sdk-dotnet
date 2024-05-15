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
    /// Represents one item in the list of managed apps with app details and its associated delegated scope(s).
    /// </summary>
    public class AndroidDeviceOwnerDelegatedScopeAppSetting : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Represents an app in the list of managed applications</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppListItem? AppDetail
        {
            get { return BackingStore?.Get<AppListItem?>("appDetail"); }
            set { BackingStore?.Set("appDetail", value); }
        }
#nullable restore
#else
        public AppListItem AppDetail
        {
            get { return BackingStore?.Get<AppListItem>("appDetail"); }
            set { BackingStore?.Set("appDetail", value); }
        }
#endif
        /// <summary>List of scopes an app has been assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerDelegatedAppScopeType?>? AppScopes
        {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerDelegatedAppScopeType?>?>("appScopes"); }
            set { BackingStore?.Set("appScopes", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerDelegatedAppScopeType?> AppScopes
        {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerDelegatedAppScopeType?>>("appScopes"); }
            set { BackingStore?.Set("appScopes", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="AndroidDeviceOwnerDelegatedScopeAppSetting"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerDelegatedScopeAppSetting()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidDeviceOwnerDelegatedScopeAppSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidDeviceOwnerDelegatedScopeAppSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerDelegatedScopeAppSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appDetail", n => { AppDetail = n.GetObjectValue<AppListItem>(AppListItem.CreateFromDiscriminatorValue); } },
                { "appScopes", n => { AppScopes = n.GetCollectionOfEnumValues<AndroidDeviceOwnerDelegatedAppScopeType>()?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AppListItem>("appDetail", AppDetail);
            writer.WriteCollectionOfEnumValues<AndroidDeviceOwnerDelegatedAppScopeType>("appScopes", AppScopes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
