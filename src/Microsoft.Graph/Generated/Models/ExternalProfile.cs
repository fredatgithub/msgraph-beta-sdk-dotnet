// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ExternalProfile : DirectoryObject, IParsable {
        /// <summary>The office address of the external user profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PhysicalOfficeAddress? Address {
            get { return BackingStore?.Get<PhysicalOfficeAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public PhysicalOfficeAddress Address {
            get { return BackingStore?.Get<PhysicalOfficeAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>The company name of the external user profile. Supports $filter (eq, startswith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>The object ID of the user who created the external user profile. Read-only. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy {
            get { return BackingStore?.Get<string?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public string CreatedBy {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time when this external user was created. Not nullable. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The department of the external user profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public string Department {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The display name of the external user profile.</summary>
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
        /// <summary>Represents whether the external user profile is discoverable in the directory. When true, this external profile shows up in Teams search.</summary>
        public bool? IsDiscoverable {
            get { return BackingStore?.Get<bool?>("isDiscoverable"); }
            set { BackingStore?.Set("isDiscoverable", value); }
        }
        /// <summary>Represents whether the external user profile is enabled in the directory. This property is peer to the accountEnabled property on the user object.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>The job title of the external user profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The phone number of the external user profile. Must be in E164 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>The object ID of the supervisor of the external user profile. Supports $filter (eq, startswith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupervisorId {
            get { return BackingStore?.Get<string?>("supervisorId"); }
            set { BackingStore?.Set("supervisorId", value); }
        }
#nullable restore
#else
        public string SupervisorId {
            get { return BackingStore?.Get<string>("supervisorId"); }
            set { BackingStore?.Set("supervisorId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ExternalProfile"/> and sets the default values.
        /// </summary>
        public ExternalProfile() : base() {
            OdataType = "#microsoft.graph.externalProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternalProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.externalUserProfile" => new ExternalUserProfile(),
                "#microsoft.graph.pendingExternalUserProfile" => new PendingExternalUserProfile(),
                _ => new ExternalProfile(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalOfficeAddress>(PhysicalOfficeAddress.CreateFromDiscriminatorValue); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isDiscoverable", n => { IsDiscoverable = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"supervisorId", n => { SupervisorId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalOfficeAddress>("address", Address);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDiscoverable", IsDiscoverable);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteStringValue("supervisorId", SupervisorId);
        }
    }
}
