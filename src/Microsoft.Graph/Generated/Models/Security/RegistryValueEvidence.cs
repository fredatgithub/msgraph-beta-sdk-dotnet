// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class RegistryValueEvidence : AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId
        {
            get { return BackingStore?.Get<string?>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#nullable restore
#else
        public string MdeDeviceId
        {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#endif
        /// <summary>Registry hive of the key that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryHive
        {
            get { return BackingStore?.Get<string?>("registryHive"); }
            set { BackingStore?.Set("registryHive", value); }
        }
#nullable restore
#else
        public string RegistryHive
        {
            get { return BackingStore?.Get<string>("registryHive"); }
            set { BackingStore?.Set("registryHive", value); }
        }
#endif
        /// <summary>Registry key that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryKey
        {
            get { return BackingStore?.Get<string?>("registryKey"); }
            set { BackingStore?.Set("registryKey", value); }
        }
#nullable restore
#else
        public string RegistryKey
        {
            get { return BackingStore?.Get<string>("registryKey"); }
            set { BackingStore?.Set("registryKey", value); }
        }
#endif
        /// <summary>Data of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValue
        {
            get { return BackingStore?.Get<string?>("registryValue"); }
            set { BackingStore?.Set("registryValue", value); }
        }
#nullable restore
#else
        public string RegistryValue
        {
            get { return BackingStore?.Get<string>("registryValue"); }
            set { BackingStore?.Set("registryValue", value); }
        }
#endif
        /// <summary>Name of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValueName
        {
            get { return BackingStore?.Get<string?>("registryValueName"); }
            set { BackingStore?.Set("registryValueName", value); }
        }
#nullable restore
#else
        public string RegistryValueName
        {
            get { return BackingStore?.Get<string>("registryValueName"); }
            set { BackingStore?.Set("registryValueName", value); }
        }
#endif
        /// <summary>Data type, such as binary or string, of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValueType
        {
            get { return BackingStore?.Get<string?>("registryValueType"); }
            set { BackingStore?.Set("registryValueType", value); }
        }
#nullable restore
#else
        public string RegistryValueType
        {
            get { return BackingStore?.Get<string>("registryValueType"); }
            set { BackingStore?.Set("registryValueType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RegistryValueEvidence"/> and sets the default values.
        /// </summary>
        public RegistryValueEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.registryValueEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RegistryValueEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RegistryValueEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistryValueEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                { "registryHive", n => { RegistryHive = n.GetStringValue(); } },
                { "registryKey", n => { RegistryKey = n.GetStringValue(); } },
                { "registryValue", n => { RegistryValue = n.GetStringValue(); } },
                { "registryValueName", n => { RegistryValueName = n.GetStringValue(); } },
                { "registryValueType", n => { RegistryValueType = n.GetStringValue(); } },
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
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteStringValue("registryHive", RegistryHive);
            writer.WriteStringValue("registryKey", RegistryKey);
            writer.WriteStringValue("registryValue", RegistryValue);
            writer.WriteStringValue("registryValueName", RegistryValueName);
            writer.WriteStringValue("registryValueType", RegistryValueType);
        }
    }
}
