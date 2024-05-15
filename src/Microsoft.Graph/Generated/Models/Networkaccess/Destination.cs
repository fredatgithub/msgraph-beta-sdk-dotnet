// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class Destination : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of unique devices that were seen.</summary>
        public int? DeviceCount
        {
            get { return BackingStore?.Get<int?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>The firstAccessDateTime property</summary>
        public DateTimeOffset? FirstAccessDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstAccessDateTime"); }
            set { BackingStore?.Set("firstAccessDateTime", value); }
        }
        /// <summary>The fully qualified domain name (FQDN) of the destination.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fqdn
        {
            get { return BackingStore?.Get<string?>("fqdn"); }
            set { BackingStore?.Set("fqdn", value); }
        }
#nullable restore
#else
        public string Fqdn
        {
            get { return BackingStore?.Get<string>("fqdn"); }
            set { BackingStore?.Set("fqdn", value); }
        }
#endif
        /// <summary>The internet protocol (IP) used to access the destination.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ip
        {
            get { return BackingStore?.Get<string?>("ip"); }
            set { BackingStore?.Set("ip", value); }
        }
#nullable restore
#else
        public string Ip
        {
            get { return BackingStore?.Get<string>("ip"); }
            set { BackingStore?.Set("ip", value); }
        }
#endif
        /// <summary>The most recent access DateTime.</summary>
        public DateTimeOffset? LastAccessDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastAccessDateTime"); }
            set { BackingStore?.Set("lastAccessDateTime", value); }
        }
        /// <summary>The networkingProtocol property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.NetworkingProtocol? NetworkingProtocol
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.NetworkingProtocol?>("networkingProtocol"); }
            set { BackingStore?.Set("networkingProtocol", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The numeric identifier that is associated with a specific endpoint in a network.</summary>
        public int? Port
        {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>The threatCount property</summary>
        public int? ThreatCount
        {
            get { return BackingStore?.Get<int?>("threatCount"); }
            set { BackingStore?.Set("threatCount", value); }
        }
        /// <summary>The totalBytesReceived property</summary>
        public long? TotalBytesReceived
        {
            get { return BackingStore?.Get<long?>("totalBytesReceived"); }
            set { BackingStore?.Set("totalBytesReceived", value); }
        }
        /// <summary>The totalBytesSent property</summary>
        public long? TotalBytesSent
        {
            get { return BackingStore?.Get<long?>("totalBytesSent"); }
            set { BackingStore?.Set("totalBytesSent", value); }
        }
        /// <summary>The trafficType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.TrafficType? TrafficType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TrafficType?>("trafficType"); }
            set { BackingStore?.Set("trafficType", value); }
        }
        /// <summary>The number of transactions.</summary>
        public int? TransactionCount
        {
            get { return BackingStore?.Get<int?>("transactionCount"); }
            set { BackingStore?.Set("transactionCount", value); }
        }
        /// <summary>The number of unique Microsoft Entra ID users that were seen.</summary>
        public int? UserCount
        {
            get { return BackingStore?.Get<int?>("userCount"); }
            set { BackingStore?.Set("userCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Destination"/> and sets the default values.
        /// </summary>
        public Destination()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Destination"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Destination CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Destination();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceCount", n => { DeviceCount = n.GetIntValue(); } },
                { "firstAccessDateTime", n => { FirstAccessDateTime = n.GetDateTimeOffsetValue(); } },
                { "fqdn", n => { Fqdn = n.GetStringValue(); } },
                { "ip", n => { Ip = n.GetStringValue(); } },
                { "lastAccessDateTime", n => { LastAccessDateTime = n.GetDateTimeOffsetValue(); } },
                { "networkingProtocol", n => { NetworkingProtocol = n.GetEnumValue<NetworkingProtocol>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "port", n => { Port = n.GetIntValue(); } },
                { "threatCount", n => { ThreatCount = n.GetIntValue(); } },
                { "totalBytesReceived", n => { TotalBytesReceived = n.GetLongValue(); } },
                { "totalBytesSent", n => { TotalBytesSent = n.GetLongValue(); } },
                { "trafficType", n => { TrafficType = n.GetEnumValue<TrafficType>(); } },
                { "transactionCount", n => { TransactionCount = n.GetIntValue(); } },
                { "userCount", n => { UserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteDateTimeOffsetValue("firstAccessDateTime", FirstAccessDateTime);
            writer.WriteStringValue("fqdn", Fqdn);
            writer.WriteStringValue("ip", Ip);
            writer.WriteDateTimeOffsetValue("lastAccessDateTime", LastAccessDateTime);
            writer.WriteEnumValue<NetworkingProtocol>("networkingProtocol", NetworkingProtocol);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteIntValue("threatCount", ThreatCount);
            writer.WriteLongValue("totalBytesReceived", TotalBytesReceived);
            writer.WriteLongValue("totalBytesSent", TotalBytesSent);
            writer.WriteEnumValue<TrafficType>("trafficType", TrafficType);
            writer.WriteIntValue("transactionCount", TransactionCount);
            writer.WriteIntValue("userCount", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
