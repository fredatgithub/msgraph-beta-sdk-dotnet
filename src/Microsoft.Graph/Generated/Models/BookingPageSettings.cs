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
    public class BookingPageSettings : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessControl property</summary>
        public BookingPageAccessControl? AccessControl
        {
            get { return BackingStore?.Get<BookingPageAccessControl?>("accessControl"); }
            set { BackingStore?.Set("accessControl", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Custom color for the bookings page. The value should be in Hex format. Example: #123456.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BookingPageColorCode
        {
            get { return BackingStore?.Get<string?>("bookingPageColorCode"); }
            set { BackingStore?.Set("bookingPageColorCode", value); }
        }
#nullable restore
#else
        public string BookingPageColorCode
        {
            get { return BackingStore?.Get<string>("bookingPageColorCode"); }
            set { BackingStore?.Set("bookingPageColorCode", value); }
        }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessTimeZone
        {
            get { return BackingStore?.Get<string?>("businessTimeZone"); }
            set { BackingStore?.Set("businessTimeZone", value); }
        }
#nullable restore
#else
        public string BusinessTimeZone
        {
            get { return BackingStore?.Get<string>("businessTimeZone"); }
            set { BackingStore?.Set("businessTimeZone", value); }
        }
#endif
        /// <summary>The personal data collection and usage consent message in the bookings page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerConsentMessage
        {
            get { return BackingStore?.Get<string?>("customerConsentMessage"); }
            set { BackingStore?.Set("customerConsentMessage", value); }
        }
#nullable restore
#else
        public string CustomerConsentMessage
        {
            get { return BackingStore?.Get<string>("customerConsentMessage"); }
            set { BackingStore?.Set("customerConsentMessage", value); }
        }
#endif
        /// <summary>Determines if the one-time password is required to create an appointment. The default value is false.</summary>
        public bool? EnforceOneTimePassword
        {
            get { return BackingStore?.Get<bool?>("enforceOneTimePassword"); }
            set { BackingStore?.Set("enforceOneTimePassword", value); }
        }
        /// <summary>Indicates if the business logo is displayed on the bookings page. The default value is false.</summary>
        public bool? IsBusinessLogoDisplayEnabled
        {
            get { return BackingStore?.Get<bool?>("isBusinessLogoDisplayEnabled"); }
            set { BackingStore?.Set("isBusinessLogoDisplayEnabled", value); }
        }
        /// <summary>Enables personal data collection and the usage consent toggle on the bookings page. The default value is false.</summary>
        public bool? IsCustomerConsentEnabled
        {
            get { return BackingStore?.Get<bool?>("isCustomerConsentEnabled"); }
            set { BackingStore?.Set("isCustomerConsentEnabled", value); }
        }
        /// <summary>Ensures that the web crawlers don&apos;t index this page. The defaults value is false.</summary>
        public bool? IsSearchEngineIndexabilityDisabled
        {
            get { return BackingStore?.Get<bool?>("isSearchEngineIndexabilityDisabled"); }
            set { BackingStore?.Set("isSearchEngineIndexabilityDisabled", value); }
        }
        /// <summary>Displays the booking time slots in the business time zone. The default value is false.</summary>
        public bool? IsTimeSlotTimeZoneSetToBusinessTimeZone
        {
            get { return BackingStore?.Get<bool?>("isTimeSlotTimeZoneSetToBusinessTimeZone"); }
            set { BackingStore?.Set("isTimeSlotTimeZoneSetToBusinessTimeZone", value); }
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
        /// <summary>RL of a webpage that provides the terms and conditions of the business. If a privacy policy isn&apos;t included, the following text appears on the bookings page as default: &apos;The policies and practices of &lt;booking business&apos;s name&gt; apply to the use of your data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyPolicyWebUrl
        {
            get { return BackingStore?.Get<string?>("privacyPolicyWebUrl"); }
            set { BackingStore?.Set("privacyPolicyWebUrl", value); }
        }
#nullable restore
#else
        public string PrivacyPolicyWebUrl
        {
            get { return BackingStore?.Get<string>("privacyPolicyWebUrl"); }
            set { BackingStore?.Set("privacyPolicyWebUrl", value); }
        }
#endif
        /// <summary>URL of a webpage that provides the terms and conditions of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TermsAndConditionsWebUrl
        {
            get { return BackingStore?.Get<string?>("termsAndConditionsWebUrl"); }
            set { BackingStore?.Set("termsAndConditionsWebUrl", value); }
        }
#nullable restore
#else
        public string TermsAndConditionsWebUrl
        {
            get { return BackingStore?.Get<string>("termsAndConditionsWebUrl"); }
            set { BackingStore?.Set("termsAndConditionsWebUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BookingPageSettings"/> and sets the default values.
        /// </summary>
        public BookingPageSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BookingPageSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BookingPageSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingPageSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessControl", n => { AccessControl = n.GetEnumValue<BookingPageAccessControl>(); } },
                { "bookingPageColorCode", n => { BookingPageColorCode = n.GetStringValue(); } },
                { "businessTimeZone", n => { BusinessTimeZone = n.GetStringValue(); } },
                { "customerConsentMessage", n => { CustomerConsentMessage = n.GetStringValue(); } },
                { "enforceOneTimePassword", n => { EnforceOneTimePassword = n.GetBoolValue(); } },
                { "isBusinessLogoDisplayEnabled", n => { IsBusinessLogoDisplayEnabled = n.GetBoolValue(); } },
                { "isCustomerConsentEnabled", n => { IsCustomerConsentEnabled = n.GetBoolValue(); } },
                { "isSearchEngineIndexabilityDisabled", n => { IsSearchEngineIndexabilityDisabled = n.GetBoolValue(); } },
                { "isTimeSlotTimeZoneSetToBusinessTimeZone", n => { IsTimeSlotTimeZoneSetToBusinessTimeZone = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privacyPolicyWebUrl", n => { PrivacyPolicyWebUrl = n.GetStringValue(); } },
                { "termsAndConditionsWebUrl", n => { TermsAndConditionsWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BookingPageAccessControl>("accessControl", AccessControl);
            writer.WriteStringValue("bookingPageColorCode", BookingPageColorCode);
            writer.WriteStringValue("businessTimeZone", BusinessTimeZone);
            writer.WriteStringValue("customerConsentMessage", CustomerConsentMessage);
            writer.WriteBoolValue("enforceOneTimePassword", EnforceOneTimePassword);
            writer.WriteBoolValue("isBusinessLogoDisplayEnabled", IsBusinessLogoDisplayEnabled);
            writer.WriteBoolValue("isCustomerConsentEnabled", IsCustomerConsentEnabled);
            writer.WriteBoolValue("isSearchEngineIndexabilityDisabled", IsSearchEngineIndexabilityDisabled);
            writer.WriteBoolValue("isTimeSlotTimeZoneSetToBusinessTimeZone", IsTimeSlotTimeZoneSetToBusinessTimeZone);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("privacyPolicyWebUrl", PrivacyPolicyWebUrl);
            writer.WriteStringValue("termsAndConditionsWebUrl", TermsAndConditionsWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
