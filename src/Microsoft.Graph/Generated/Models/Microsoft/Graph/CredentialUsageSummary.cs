using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getCredentialUsageSummary method.</summary>
    public class CredentialUsageSummary : Entity, IParsable {
        /// <summary>Represents the authentication method that the user used. Possible values are:email, mobileSMS, mobileCall, officePhone, securityQuestion (only used for self-service password reset), appNotification, appCode, alternateMobileCall (supported only in registration), fido, appPassword, unknownFutureValue.</summary>
        public UsageAuthMethod? AuthMethod { get; set; }
        /// <summary>Provides the count of failed resets or registration data.</summary>
        public int? FailureActivityCount { get; set; }
        /// <summary>Defines the feature to report. Possible values are: registration, reset, unknownFutureValue.</summary>
        public FeatureType? Feature { get; set; }
        /// <summary>Provides the count of successful registrations or resets.</summary>
        public int? SuccessfulActivityCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CredentialUsageSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUsageSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authMethod", (o,n) => { (o as CredentialUsageSummary).AuthMethod = n.GetEnumValue<UsageAuthMethod>(); } },
                {"failureActivityCount", (o,n) => { (o as CredentialUsageSummary).FailureActivityCount = n.GetIntValue(); } },
                {"feature", (o,n) => { (o as CredentialUsageSummary).Feature = n.GetEnumValue<FeatureType>(); } },
                {"successfulActivityCount", (o,n) => { (o as CredentialUsageSummary).SuccessfulActivityCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UsageAuthMethod>("authMethod", AuthMethod);
            writer.WriteIntValue("failureActivityCount", FailureActivityCount);
            writer.WriteEnumValue<FeatureType>("feature", Feature);
            writer.WriteIntValue("successfulActivityCount", SuccessfulActivityCount);
        }
    }
}
