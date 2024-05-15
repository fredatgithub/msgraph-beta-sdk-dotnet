// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AwsAuthorizationSystem : AuthorizationSystem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of actions for service in authorization system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AwsAuthorizationSystemTypeAction>? Actions
        {
            get { return BackingStore?.Get<List<AwsAuthorizationSystemTypeAction>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<AwsAuthorizationSystemTypeAction> Actions
        {
            get { return BackingStore?.Get<List<AwsAuthorizationSystemTypeAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>Identities in the authorization system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AwsAssociatedIdentities? AssociatedIdentities
        {
            get { return BackingStore?.Get<AwsAssociatedIdentities?>("associatedIdentities"); }
            set { BackingStore?.Set("associatedIdentities", value); }
        }
#nullable restore
#else
        public AwsAssociatedIdentities AssociatedIdentities
        {
            get { return BackingStore?.Get<AwsAssociatedIdentities>("associatedIdentities"); }
            set { BackingStore?.Set("associatedIdentities", value); }
        }
#endif
        /// <summary>Policies associated with the AWS authorization system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AwsPolicy>? Policies
        {
            get { return BackingStore?.Get<List<AwsPolicy>?>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#nullable restore
#else
        public List<AwsPolicy> Policies
        {
            get { return BackingStore?.Get<List<AwsPolicy>>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#endif
        /// <summary>Resources associated with the authorization system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AwsAuthorizationSystemResource>? Resources
        {
            get { return BackingStore?.Get<List<AwsAuthorizationSystemResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<AwsAuthorizationSystemResource> Resources
        {
            get { return BackingStore?.Get<List<AwsAuthorizationSystemResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>Services associated with the authorization system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthorizationSystemTypeService>? Services
        {
            get { return BackingStore?.Get<List<AuthorizationSystemTypeService>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<AuthorizationSystemTypeService> Services
        {
            get { return BackingStore?.Get<List<AuthorizationSystemTypeService>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AwsAuthorizationSystem"/> and sets the default values.
        /// </summary>
        public AwsAuthorizationSystem() : base()
        {
            OdataType = "#microsoft.graph.awsAuthorizationSystem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AwsAuthorizationSystem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AwsAuthorizationSystem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AwsAuthorizationSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<AwsAuthorizationSystemTypeAction>(AwsAuthorizationSystemTypeAction.CreateFromDiscriminatorValue)?.ToList(); } },
                { "associatedIdentities", n => { AssociatedIdentities = n.GetObjectValue<AwsAssociatedIdentities>(AwsAssociatedIdentities.CreateFromDiscriminatorValue); } },
                { "policies", n => { Policies = n.GetCollectionOfObjectValues<AwsPolicy>(AwsPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<AwsAuthorizationSystemResource>(AwsAuthorizationSystemResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "services", n => { Services = n.GetCollectionOfObjectValues<AuthorizationSystemTypeService>(AuthorizationSystemTypeService.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AwsAuthorizationSystemTypeAction>("actions", Actions);
            writer.WriteObjectValue<AwsAssociatedIdentities>("associatedIdentities", AssociatedIdentities);
            writer.WriteCollectionOfObjectValues<AwsPolicy>("policies", Policies);
            writer.WriteCollectionOfObjectValues<AwsAuthorizationSystemResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<AuthorizationSystemTypeService>("services", Services);
        }
    }
}
