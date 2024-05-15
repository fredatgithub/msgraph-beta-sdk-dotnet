// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AwsSecretInformationAccessFinding : Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemIdentity? Identity
        {
            get { return BackingStore?.Get<AuthorizationSystemIdentity?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public AuthorizationSystemIdentity Identity
        {
            get { return BackingStore?.Get<AuthorizationSystemIdentity>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>The identityDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentityDetails? IdentityDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityDetails?>("identityDetails"); }
            set { BackingStore?.Set("identityDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentityDetails IdentityDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityDetails>("identityDetails"); }
            set { BackingStore?.Set("identityDetails", value); }
        }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PermissionsCreepIndex? PermissionsCreepIndex
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsCreepIndex?>("permissionsCreepIndex"); }
            set { BackingStore?.Set("permissionsCreepIndex", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PermissionsCreepIndex PermissionsCreepIndex
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsCreepIndex>("permissionsCreepIndex"); }
            set { BackingStore?.Set("permissionsCreepIndex", value); }
        }
#endif
        /// <summary>The secretInformationWebServices property</summary>
        public AwsSecretInformationWebServices? SecretInformationWebServices
        {
            get { return BackingStore?.Get<AwsSecretInformationWebServices?>("secretInformationWebServices"); }
            set { BackingStore?.Set("secretInformationWebServices", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AwsSecretInformationAccessFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AwsSecretInformationAccessFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.secretInformationAccessAwsResourceFinding" => new SecretInformationAccessAwsResourceFinding(),
                "#microsoft.graph.secretInformationAccessAwsRoleFinding" => new SecretInformationAccessAwsRoleFinding(),
                "#microsoft.graph.secretInformationAccessAwsServerlessFunctionFinding" => new SecretInformationAccessAwsServerlessFunctionFinding(),
                "#microsoft.graph.secretInformationAccessAwsUserFinding" => new SecretInformationAccessAwsUserFinding(),
                _ => new AwsSecretInformationAccessFinding(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "identity", n => { Identity = n.GetObjectValue<AuthorizationSystemIdentity>(AuthorizationSystemIdentity.CreateFromDiscriminatorValue); } },
                { "identityDetails", n => { IdentityDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityDetails>(Microsoft.Graph.Beta.Models.IdentityDetails.CreateFromDiscriminatorValue); } },
                { "permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<Microsoft.Graph.Beta.Models.PermissionsCreepIndex>(Microsoft.Graph.Beta.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
                { "secretInformationWebServices", n => { SecretInformationWebServices = n.GetEnumValue<AwsSecretInformationWebServices>(); } },
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
            writer.WriteObjectValue<AuthorizationSystemIdentity>("identity", Identity);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityDetails>("identityDetails", IdentityDetails);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
            writer.WriteEnumValue<AwsSecretInformationWebServices>("secretInformationWebServices", SecretInformationWebServices);
        }
    }
}
