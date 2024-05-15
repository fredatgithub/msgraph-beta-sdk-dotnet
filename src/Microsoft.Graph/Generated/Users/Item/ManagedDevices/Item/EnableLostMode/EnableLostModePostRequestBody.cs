// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Users.Item.ManagedDevices.Item.EnableLostMode
{
    #pragma warning disable CS1591
    public class EnableLostModePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The footer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Footer
        {
            get { return BackingStore?.Get<string?>("footer"); }
            set { BackingStore?.Set("footer", value); }
        }
#nullable restore
#else
        public string Footer
        {
            get { return BackingStore?.Get<string>("footer"); }
            set { BackingStore?.Set("footer", value); }
        }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message
        {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message
        {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber
        {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber
        {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EnableLostModePostRequestBody"/> and sets the default values.
        /// </summary>
        public EnableLostModePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EnableLostModePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EnableLostModePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnableLostModePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "footer", n => { Footer = n.GetStringValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("footer", Footer);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
