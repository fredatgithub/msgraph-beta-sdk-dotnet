// <auto-generated/>
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Security.Collaboration.AnalyzedEmails.MicrosoftGraphSecurityRemediate
{
    #pragma warning disable CS1591
    public class RemediatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public RemediationAction? Action
        {
            get { return BackingStore?.Get<RemediationAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The analyzedEmails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmail>? AnalyzedEmails
        {
            get { return BackingStore?.Get<List<AnalyzedEmail>?>("analyzedEmails"); }
            set { BackingStore?.Set("analyzedEmails", value); }
        }
#nullable restore
#else
        public List<AnalyzedEmail> AnalyzedEmails
        {
            get { return BackingStore?.Get<List<AnalyzedEmail>>("analyzedEmails"); }
            set { BackingStore?.Set("analyzedEmails", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The remediateSendersCopy property</summary>
        public bool? RemediateSendersCopy
        {
            get { return BackingStore?.Get<bool?>("remediateSendersCopy"); }
            set { BackingStore?.Set("remediateSendersCopy", value); }
        }
        /// <summary>The severity property</summary>
        public RemediationSeverity? Severity
        {
            get { return BackingStore?.Get<RemediationSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="RemediatePostRequestBody"/> and sets the default values.
        /// </summary>
        public RemediatePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RemediatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RemediatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemediatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<RemediationAction>(); } },
                { "analyzedEmails", n => { AnalyzedEmails = n.GetCollectionOfObjectValues<AnalyzedEmail>(AnalyzedEmail.CreateFromDiscriminatorValue)?.ToList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "remediateSendersCopy", n => { RemediateSendersCopy = n.GetBoolValue(); } },
                { "severity", n => { Severity = n.GetEnumValue<RemediationSeverity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RemediationAction>("action", Action);
            writer.WriteCollectionOfObjectValues<AnalyzedEmail>("analyzedEmails", AnalyzedEmails);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("remediateSendersCopy", RemediateSendersCopy);
            writer.WriteEnumValue<RemediationSeverity>("severity", Severity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
