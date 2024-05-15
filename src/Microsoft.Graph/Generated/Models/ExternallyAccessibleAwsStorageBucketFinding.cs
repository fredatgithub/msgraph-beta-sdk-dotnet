// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ExternallyAccessibleAwsStorageBucketFinding : Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessibility property</summary>
        public AwsAccessType? Accessibility
        {
            get { return BackingStore?.Get<AwsAccessType?>("accessibility"); }
            set { BackingStore?.Set("accessibility", value); }
        }
        /// <summary>The accountsWithAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccountsWithAccess? AccountsWithAccess
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccountsWithAccess?>("accountsWithAccess"); }
            set { BackingStore?.Set("accountsWithAccess", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccountsWithAccess AccountsWithAccess
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccountsWithAccess>("accountsWithAccess"); }
            set { BackingStore?.Set("accountsWithAccess", value); }
        }
#endif
        /// <summary>The storageBucket property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemResource? StorageBucket
        {
            get { return BackingStore?.Get<AuthorizationSystemResource?>("storageBucket"); }
            set { BackingStore?.Set("storageBucket", value); }
        }
#nullable restore
#else
        public AuthorizationSystemResource StorageBucket
        {
            get { return BackingStore?.Get<AuthorizationSystemResource>("storageBucket"); }
            set { BackingStore?.Set("storageBucket", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternallyAccessibleAwsStorageBucketFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternallyAccessibleAwsStorageBucketFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternallyAccessibleAwsStorageBucketFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessibility", n => { Accessibility = n.GetEnumValue<AwsAccessType>(); } },
                { "accountsWithAccess", n => { AccountsWithAccess = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccountsWithAccess>(Microsoft.Graph.Beta.Models.AccountsWithAccess.CreateFromDiscriminatorValue); } },
                { "storageBucket", n => { StorageBucket = n.GetObjectValue<AuthorizationSystemResource>(AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<AwsAccessType>("accessibility", Accessibility);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccountsWithAccess>("accountsWithAccess", AccountsWithAccess);
            writer.WriteObjectValue<AuthorizationSystemResource>("storageBucket", StorageBucket);
        }
    }
}
