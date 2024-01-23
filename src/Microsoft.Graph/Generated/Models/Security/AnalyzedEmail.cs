// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AnalyzedEmail : Microsoft.Graph.Beta.Models.Entity, IParsable {
        /// <summary>The alertIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlertIds {
            get { return BackingStore?.Get<List<string>?>("alertIds"); }
            set { BackingStore?.Set("alertIds", value); }
        }
#nullable restore
#else
        public List<string> AlertIds {
            get { return BackingStore?.Get<List<string>>("alertIds"); }
            set { BackingStore?.Set("alertIds", value); }
        }
#endif
        /// <summary>The attachments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmailAttachment>? Attachments {
            get { return BackingStore?.Get<List<AnalyzedEmailAttachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<AnalyzedEmailAttachment> Attachments {
            get { return BackingStore?.Get<List<AnalyzedEmailAttachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The attachmentsCount property</summary>
        public int? AttachmentsCount {
            get { return BackingStore?.Get<int?>("attachmentsCount"); }
            set { BackingStore?.Set("attachmentsCount", value); }
        }
        /// <summary>The authenticationDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailAuthenticationDetail? AuthenticationDetails {
            get { return BackingStore?.Get<AnalyzedEmailAuthenticationDetail?>("authenticationDetails"); }
            set { BackingStore?.Set("authenticationDetails", value); }
        }
#nullable restore
#else
        public AnalyzedEmailAuthenticationDetail AuthenticationDetails {
            get { return BackingStore?.Get<AnalyzedEmailAuthenticationDetail>("authenticationDetails"); }
            set { BackingStore?.Set("authenticationDetails", value); }
        }
#endif
        /// <summary>The bulkComplaintLevel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BulkComplaintLevel {
            get { return BackingStore?.Get<string?>("bulkComplaintLevel"); }
            set { BackingStore?.Set("bulkComplaintLevel", value); }
        }
#nullable restore
#else
        public string BulkComplaintLevel {
            get { return BackingStore?.Get<string>("bulkComplaintLevel"); }
            set { BackingStore?.Set("bulkComplaintLevel", value); }
        }
#endif
        /// <summary>The contexts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Contexts {
            get { return BackingStore?.Get<List<string>?>("contexts"); }
            set { BackingStore?.Set("contexts", value); }
        }
#nullable restore
#else
        public List<string> Contexts {
            get { return BackingStore?.Get<List<string>>("contexts"); }
            set { BackingStore?.Set("contexts", value); }
        }
#endif
        /// <summary>The detectionMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DetectionMethods {
            get { return BackingStore?.Get<List<string>?>("detectionMethods"); }
            set { BackingStore?.Set("detectionMethods", value); }
        }
#nullable restore
#else
        public List<string> DetectionMethods {
            get { return BackingStore?.Get<List<string>>("detectionMethods"); }
            set { BackingStore?.Set("detectionMethods", value); }
        }
#endif
        /// <summary>The directionality property</summary>
        public AntispamDirectionality? Directionality {
            get { return BackingStore?.Get<AntispamDirectionality?>("directionality"); }
            set { BackingStore?.Set("directionality", value); }
        }
        /// <summary>The distributionList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DistributionList {
            get { return BackingStore?.Get<string?>("distributionList"); }
            set { BackingStore?.Set("distributionList", value); }
        }
#nullable restore
#else
        public string DistributionList {
            get { return BackingStore?.Get<string>("distributionList"); }
            set { BackingStore?.Set("distributionList", value); }
        }
#endif
        /// <summary>The emailClusterId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailClusterId {
            get { return BackingStore?.Get<string?>("emailClusterId"); }
            set { BackingStore?.Set("emailClusterId", value); }
        }
#nullable restore
#else
        public string EmailClusterId {
            get { return BackingStore?.Get<string>("emailClusterId"); }
            set { BackingStore?.Set("emailClusterId", value); }
        }
#endif
        /// <summary>The exchangeTransportRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmailExchangeTransportRuleInfo>? ExchangeTransportRules {
            get { return BackingStore?.Get<List<AnalyzedEmailExchangeTransportRuleInfo>?>("exchangeTransportRules"); }
            set { BackingStore?.Set("exchangeTransportRules", value); }
        }
#nullable restore
#else
        public List<AnalyzedEmailExchangeTransportRuleInfo> ExchangeTransportRules {
            get { return BackingStore?.Get<List<AnalyzedEmailExchangeTransportRuleInfo>>("exchangeTransportRules"); }
            set { BackingStore?.Set("exchangeTransportRules", value); }
        }
#endif
        /// <summary>The internetMessageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId {
            get { return BackingStore?.Get<string?>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#nullable restore
#else
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#endif
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>The latestDelivery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailDeliveryDetail? LatestDelivery {
            get { return BackingStore?.Get<AnalyzedEmailDeliveryDetail?>("latestDelivery"); }
            set { BackingStore?.Set("latestDelivery", value); }
        }
#nullable restore
#else
        public AnalyzedEmailDeliveryDetail LatestDelivery {
            get { return BackingStore?.Get<AnalyzedEmailDeliveryDetail>("latestDelivery"); }
            set { BackingStore?.Set("latestDelivery", value); }
        }
#endif
        /// <summary>The loggedDateTime property</summary>
        public DateTimeOffset? LoggedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("loggedDateTime"); }
            set { BackingStore?.Set("loggedDateTime", value); }
        }
        /// <summary>The networkMessageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId {
            get { return BackingStore?.Get<string?>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#nullable restore
#else
        public string NetworkMessageId {
            get { return BackingStore?.Get<string>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#endif
        /// <summary>The originalDelivery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailDeliveryDetail? OriginalDelivery {
            get { return BackingStore?.Get<AnalyzedEmailDeliveryDetail?>("originalDelivery"); }
            set { BackingStore?.Set("originalDelivery", value); }
        }
#nullable restore
#else
        public AnalyzedEmailDeliveryDetail OriginalDelivery {
            get { return BackingStore?.Get<AnalyzedEmailDeliveryDetail>("originalDelivery"); }
            set { BackingStore?.Set("originalDelivery", value); }
        }
#endif
        /// <summary>The overrideSources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OverrideSources {
            get { return BackingStore?.Get<List<string>?>("overrideSources"); }
            set { BackingStore?.Set("overrideSources", value); }
        }
#nullable restore
#else
        public List<string> OverrideSources {
            get { return BackingStore?.Get<List<string>>("overrideSources"); }
            set { BackingStore?.Set("overrideSources", value); }
        }
#endif
        /// <summary>The phishConfidenceLevel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhishConfidenceLevel {
            get { return BackingStore?.Get<string?>("phishConfidenceLevel"); }
            set { BackingStore?.Set("phishConfidenceLevel", value); }
        }
#nullable restore
#else
        public string PhishConfidenceLevel {
            get { return BackingStore?.Get<string>("phishConfidenceLevel"); }
            set { BackingStore?.Set("phishConfidenceLevel", value); }
        }
#endif
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Policy {
            get { return BackingStore?.Get<string?>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#nullable restore
#else
        public string Policy {
            get { return BackingStore?.Get<string>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#endif
        /// <summary>The policyAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyAction {
            get { return BackingStore?.Get<string?>("policyAction"); }
            set { BackingStore?.Set("policyAction", value); }
        }
#nullable restore
#else
        public string PolicyAction {
            get { return BackingStore?.Get<string>("policyAction"); }
            set { BackingStore?.Set("policyAction", value); }
        }
#endif
        /// <summary>The recipientEmailAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecipientEmailAddresses {
            get { return BackingStore?.Get<List<string>?>("recipientEmailAddresses"); }
            set { BackingStore?.Set("recipientEmailAddresses", value); }
        }
#nullable restore
#else
        public List<string> RecipientEmailAddresses {
            get { return BackingStore?.Get<List<string>>("recipientEmailAddresses"); }
            set { BackingStore?.Set("recipientEmailAddresses", value); }
        }
#endif
        /// <summary>The returnPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReturnPath {
            get { return BackingStore?.Get<string?>("returnPath"); }
            set { BackingStore?.Set("returnPath", value); }
        }
#nullable restore
#else
        public string ReturnPath {
            get { return BackingStore?.Get<string>("returnPath"); }
            set { BackingStore?.Set("returnPath", value); }
        }
#endif
        /// <summary>The senderDetail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailSenderDetail? SenderDetail {
            get { return BackingStore?.Get<AnalyzedEmailSenderDetail?>("senderDetail"); }
            set { BackingStore?.Set("senderDetail", value); }
        }
#nullable restore
#else
        public AnalyzedEmailSenderDetail SenderDetail {
            get { return BackingStore?.Get<AnalyzedEmailSenderDetail>("senderDetail"); }
            set { BackingStore?.Set("senderDetail", value); }
        }
#endif
        /// <summary>The sizeInBytes property</summary>
        public int? SizeInBytes {
            get { return BackingStore?.Get<int?>("sizeInBytes"); }
            set { BackingStore?.Set("sizeInBytes", value); }
        }
        /// <summary>The spamConfidenceLevel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpamConfidenceLevel {
            get { return BackingStore?.Get<string?>("spamConfidenceLevel"); }
            set { BackingStore?.Set("spamConfidenceLevel", value); }
        }
#nullable restore
#else
        public string SpamConfidenceLevel {
            get { return BackingStore?.Get<string>("spamConfidenceLevel"); }
            set { BackingStore?.Set("spamConfidenceLevel", value); }
        }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The threatType property</summary>
        public Microsoft.Graph.Beta.Models.Security.ThreatType? ThreatType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ThreatType?>("threatType"); }
            set { BackingStore?.Set("threatType", value); }
        }
        /// <summary>The urls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmailUrl>? Urls {
            get { return BackingStore?.Get<List<AnalyzedEmailUrl>?>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
#nullable restore
#else
        public List<AnalyzedEmailUrl> Urls {
            get { return BackingStore?.Get<List<AnalyzedEmailUrl>>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
#endif
        /// <summary>The urlsCount property</summary>
        public int? UrlsCount {
            get { return BackingStore?.Get<int?>("urlsCount"); }
            set { BackingStore?.Set("urlsCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AnalyzedEmail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedEmail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertIds", n => { AlertIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<AnalyzedEmailAttachment>(AnalyzedEmailAttachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attachmentsCount", n => { AttachmentsCount = n.GetIntValue(); } },
                {"authenticationDetails", n => { AuthenticationDetails = n.GetObjectValue<AnalyzedEmailAuthenticationDetail>(AnalyzedEmailAuthenticationDetail.CreateFromDiscriminatorValue); } },
                {"bulkComplaintLevel", n => { BulkComplaintLevel = n.GetStringValue(); } },
                {"contexts", n => { Contexts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"detectionMethods", n => { DetectionMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"directionality", n => { Directionality = n.GetEnumValue<AntispamDirectionality>(); } },
                {"distributionList", n => { DistributionList = n.GetStringValue(); } },
                {"emailClusterId", n => { EmailClusterId = n.GetStringValue(); } },
                {"exchangeTransportRules", n => { ExchangeTransportRules = n.GetCollectionOfObjectValues<AnalyzedEmailExchangeTransportRuleInfo>(AnalyzedEmailExchangeTransportRuleInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"latestDelivery", n => { LatestDelivery = n.GetObjectValue<AnalyzedEmailDeliveryDetail>(AnalyzedEmailDeliveryDetail.CreateFromDiscriminatorValue); } },
                {"loggedDateTime", n => { LoggedDateTime = n.GetDateTimeOffsetValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"originalDelivery", n => { OriginalDelivery = n.GetObjectValue<AnalyzedEmailDeliveryDetail>(AnalyzedEmailDeliveryDetail.CreateFromDiscriminatorValue); } },
                {"overrideSources", n => { OverrideSources = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"phishConfidenceLevel", n => { PhishConfidenceLevel = n.GetStringValue(); } },
                {"policy", n => { Policy = n.GetStringValue(); } },
                {"policyAction", n => { PolicyAction = n.GetStringValue(); } },
                {"recipientEmailAddresses", n => { RecipientEmailAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"returnPath", n => { ReturnPath = n.GetStringValue(); } },
                {"senderDetail", n => { SenderDetail = n.GetObjectValue<AnalyzedEmailSenderDetail>(AnalyzedEmailSenderDetail.CreateFromDiscriminatorValue); } },
                {"sizeInBytes", n => { SizeInBytes = n.GetIntValue(); } },
                {"spamConfidenceLevel", n => { SpamConfidenceLevel = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"threatType", n => { ThreatType = n.GetEnumValue<ThreatType>(); } },
                {"urls", n => { Urls = n.GetCollectionOfObjectValues<AnalyzedEmailUrl>(AnalyzedEmailUrl.CreateFromDiscriminatorValue)?.ToList(); } },
                {"urlsCount", n => { UrlsCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("alertIds", AlertIds);
            writer.WriteCollectionOfObjectValues<AnalyzedEmailAttachment>("attachments", Attachments);
            writer.WriteIntValue("attachmentsCount", AttachmentsCount);
            writer.WriteObjectValue<AnalyzedEmailAuthenticationDetail>("authenticationDetails", AuthenticationDetails);
            writer.WriteStringValue("bulkComplaintLevel", BulkComplaintLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("contexts", Contexts);
            writer.WriteCollectionOfPrimitiveValues<string>("detectionMethods", DetectionMethods);
            writer.WriteEnumValue<AntispamDirectionality>("directionality", Directionality);
            writer.WriteStringValue("distributionList", DistributionList);
            writer.WriteStringValue("emailClusterId", EmailClusterId);
            writer.WriteCollectionOfObjectValues<AnalyzedEmailExchangeTransportRuleInfo>("exchangeTransportRules", ExchangeTransportRules);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("language", Language);
            writer.WriteObjectValue<AnalyzedEmailDeliveryDetail>("latestDelivery", LatestDelivery);
            writer.WriteDateTimeOffsetValue("loggedDateTime", LoggedDateTime);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteObjectValue<AnalyzedEmailDeliveryDetail>("originalDelivery", OriginalDelivery);
            writer.WriteCollectionOfPrimitiveValues<string>("overrideSources", OverrideSources);
            writer.WriteStringValue("phishConfidenceLevel", PhishConfidenceLevel);
            writer.WriteStringValue("policy", Policy);
            writer.WriteStringValue("policyAction", PolicyAction);
            writer.WriteCollectionOfPrimitiveValues<string>("recipientEmailAddresses", RecipientEmailAddresses);
            writer.WriteStringValue("returnPath", ReturnPath);
            writer.WriteObjectValue<AnalyzedEmailSenderDetail>("senderDetail", SenderDetail);
            writer.WriteIntValue("sizeInBytes", SizeInBytes);
            writer.WriteStringValue("spamConfidenceLevel", SpamConfidenceLevel);
            writer.WriteStringValue("subject", Subject);
            writer.WriteEnumValue<ThreatType>("threatType", ThreatType);
            writer.WriteCollectionOfObjectValues<AnalyzedEmailUrl>("urls", Urls);
            writer.WriteIntValue("urlsCount", UrlsCount);
        }
    }
}
