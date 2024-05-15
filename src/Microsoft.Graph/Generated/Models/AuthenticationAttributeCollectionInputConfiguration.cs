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
    public class AuthenticationAttributeCollectionInputConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The built-in or custom attribute for which a value is being collected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Attribute
        {
            get { return BackingStore?.Get<string?>("attribute"); }
            set { BackingStore?.Set("attribute", value); }
        }
#nullable restore
#else
        public string Attribute
        {
            get { return BackingStore?.Get<string>("attribute"); }
            set { BackingStore?.Set("attribute", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default value of the attribute displayed to the end user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue
        {
            get { return BackingStore?.Get<string?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#nullable restore
#else
        public string DefaultValue
        {
            get { return BackingStore?.Get<string>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>Whether the attribute is editable by the end user.</summary>
        public bool? Editable
        {
            get { return BackingStore?.Get<bool?>("editable"); }
            set { BackingStore?.Set("editable", value); }
        }
        /// <summary>Whether the attribute is displayed to the end user.</summary>
        public bool? Hidden
        {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>The inputType property</summary>
        public AuthenticationAttributeCollectionInputType? InputType
        {
            get { return BackingStore?.Get<AuthenticationAttributeCollectionInputType?>("inputType"); }
            set { BackingStore?.Set("inputType", value); }
        }
        /// <summary>The label of the attribute field that is displayed to end user, unless overridden.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label
        {
            get { return BackingStore?.Get<string?>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#nullable restore
#else
        public string Label
        {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#endif
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
        /// <summary>The option values for certain multiple-option input types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationAttributeCollectionOptionConfiguration>? Options
        {
            get { return BackingStore?.Get<List<AuthenticationAttributeCollectionOptionConfiguration>?>("options"); }
            set { BackingStore?.Set("options", value); }
        }
#nullable restore
#else
        public List<AuthenticationAttributeCollectionOptionConfiguration> Options
        {
            get { return BackingStore?.Get<List<AuthenticationAttributeCollectionOptionConfiguration>>("options"); }
            set { BackingStore?.Set("options", value); }
        }
#endif
        /// <summary>Whether the field is required.</summary>
        public bool? Required
        {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>The regex for the value of the field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValidationRegEx
        {
            get { return BackingStore?.Get<string?>("validationRegEx"); }
            set { BackingStore?.Set("validationRegEx", value); }
        }
#nullable restore
#else
        public string ValidationRegEx
        {
            get { return BackingStore?.Get<string>("validationRegEx"); }
            set { BackingStore?.Set("validationRegEx", value); }
        }
#endif
        /// <summary>Whether the value collected is stored.</summary>
        public bool? WriteToDirectory
        {
            get { return BackingStore?.Get<bool?>("writeToDirectory"); }
            set { BackingStore?.Set("writeToDirectory", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationAttributeCollectionInputConfiguration"/> and sets the default values.
        /// </summary>
        public AuthenticationAttributeCollectionInputConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuthenticationAttributeCollectionInputConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationAttributeCollectionInputConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationAttributeCollectionInputConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attribute", n => { Attribute = n.GetStringValue(); } },
                { "defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                { "editable", n => { Editable = n.GetBoolValue(); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "inputType", n => { InputType = n.GetEnumValue<AuthenticationAttributeCollectionInputType>(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "options", n => { Options = n.GetCollectionOfObjectValues<AuthenticationAttributeCollectionOptionConfiguration>(AuthenticationAttributeCollectionOptionConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                { "required", n => { Required = n.GetBoolValue(); } },
                { "validationRegEx", n => { ValidationRegEx = n.GetStringValue(); } },
                { "writeToDirectory", n => { WriteToDirectory = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("attribute", Attribute);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("editable", Editable);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteEnumValue<AuthenticationAttributeCollectionInputType>("inputType", InputType);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<AuthenticationAttributeCollectionOptionConfiguration>("options", Options);
            writer.WriteBoolValue("required", Required);
            writer.WriteStringValue("validationRegEx", ValidationRegEx);
            writer.WriteBoolValue("writeToDirectory", WriteToDirectory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
