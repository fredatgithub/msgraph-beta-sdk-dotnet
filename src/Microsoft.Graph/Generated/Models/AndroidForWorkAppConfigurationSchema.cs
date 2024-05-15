// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Schema describing an Android for Work application&apos;s custom configurations.
    /// </summary>
    public class AndroidForWorkAppConfigurationSchema : Entity, IParsable
    {
        /// <summary>UTF8 encoded byte array containing example JSON string conforming to this schema that demonstrates how to set the configuration for this app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ExampleJson
        {
            get { return BackingStore?.Get<byte[]?>("exampleJson"); }
            set { BackingStore?.Set("exampleJson", value); }
        }
#nullable restore
#else
        public byte[] ExampleJson
        {
            get { return BackingStore?.Get<byte[]>("exampleJson"); }
            set { BackingStore?.Set("exampleJson", value); }
        }
#endif
        /// <summary>Collection of items each representing a named configuration option in the schema</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidForWorkAppConfigurationSchemaItem>? SchemaItems
        {
            get { return BackingStore?.Get<List<AndroidForWorkAppConfigurationSchemaItem>?>("schemaItems"); }
            set { BackingStore?.Set("schemaItems", value); }
        }
#nullable restore
#else
        public List<AndroidForWorkAppConfigurationSchemaItem> SchemaItems
        {
            get { return BackingStore?.Get<List<AndroidForWorkAppConfigurationSchemaItem>>("schemaItems"); }
            set { BackingStore?.Set("schemaItems", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidForWorkAppConfigurationSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidForWorkAppConfigurationSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkAppConfigurationSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "exampleJson", n => { ExampleJson = n.GetByteArrayValue(); } },
                { "schemaItems", n => { SchemaItems = n.GetCollectionOfObjectValues<AndroidForWorkAppConfigurationSchemaItem>(AndroidForWorkAppConfigurationSchemaItem.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteByteArrayValue("exampleJson", ExampleJson);
            writer.WriteCollectionOfObjectValues<AndroidForWorkAppConfigurationSchemaItem>("schemaItems", SchemaItems);
        }
    }
}
