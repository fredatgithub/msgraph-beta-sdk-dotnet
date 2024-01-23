// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class GitHubOrganizationEvidence : AlertEvidence, IParsable {
        /// <summary>The company property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company {
            get { return BackingStore?.Get<string?>("company"); }
            set { BackingStore?.Set("company", value); }
        }
#nullable restore
#else
        public string Company {
            get { return BackingStore?.Get<string>("company"); }
            set { BackingStore?.Set("company", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login {
            get { return BackingStore?.Get<string?>("login"); }
            set { BackingStore?.Set("login", value); }
        }
#nullable restore
#else
        public string Login {
            get { return BackingStore?.Get<string>("login"); }
            set { BackingStore?.Set("login", value); }
        }
#endif
        /// <summary>The orgId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrgId {
            get { return BackingStore?.Get<string?>("orgId"); }
            set { BackingStore?.Set("orgId", value); }
        }
#nullable restore
#else
        public string OrgId {
            get { return BackingStore?.Get<string>("orgId"); }
            set { BackingStore?.Set("orgId", value); }
        }
#endif
        /// <summary>The webUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new gitHubOrganizationEvidence and sets the default values.
        /// </summary>
        public GitHubOrganizationEvidence() : base() {
            OdataType = "#microsoft.graph.security.gitHubOrganizationEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GitHubOrganizationEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GitHubOrganizationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"company", n => { Company = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"login", n => { Login = n.GetStringValue(); } },
                {"orgId", n => { OrgId = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("company", Company);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("orgId", OrgId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
