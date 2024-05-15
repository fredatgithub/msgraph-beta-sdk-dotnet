// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class WorkplaceSensorDeviceTelemetry : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The value of the sensor can be true or false. Use it for sensors that report binary values, such as occupancy or heartbeat.</summary>
        public bool? BoolValue
        {
            get { return BackingStore?.Get<bool?>("boolValue"); }
            set { BackingStore?.Set("boolValue", value); }
        }
        /// <summary>The user-defined unique identifier of the device provided at the time of creation. Don&apos;t use the system generated identifier of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId
        {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId
        {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The value of the sensor as an integer. Use it for sensors that report numerical values, such as people count.</summary>
        public int? IntValue
        {
            get { return BackingStore?.Get<int?>("intValue"); }
            set { BackingStore?.Set("intValue", value); }
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
        /// <summary>The user-defined unique identifier of the sensor on the device. Optional. If the device has multiple sensors of the same type, the property must be provided to identify each sensor. If the device has unique sensor types, the property can be omitted. The default value is the sensor type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SensorId
        {
            get { return BackingStore?.Get<string?>("sensorId"); }
            set { BackingStore?.Set("sensorId", value); }
        }
#nullable restore
#else
        public string SensorId
        {
            get { return BackingStore?.Get<string>("sensorId"); }
            set { BackingStore?.Set("sensorId", value); }
        }
#endif
        /// <summary>The sensorType property</summary>
        public WorkplaceSensorType? SensorType
        {
            get { return BackingStore?.Get<WorkplaceSensorType?>("sensorType"); }
            set { BackingStore?.Set("sensorType", value); }
        }
        /// <summary>The date and time when the sensor measured and reported its value. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? Timestamp
        {
            get { return BackingStore?.Get<DateTimeOffset?>("timestamp"); }
            set { BackingStore?.Set("timestamp", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkplaceSensorDeviceTelemetry"/> and sets the default values.
        /// </summary>
        public WorkplaceSensorDeviceTelemetry()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkplaceSensorDeviceTelemetry"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkplaceSensorDeviceTelemetry CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkplaceSensorDeviceTelemetry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "boolValue", n => { BoolValue = n.GetBoolValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "intValue", n => { IntValue = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sensorId", n => { SensorId = n.GetStringValue(); } },
                { "sensorType", n => { SensorType = n.GetEnumValue<WorkplaceSensorType>(); } },
                { "timestamp", n => { Timestamp = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("boolValue", BoolValue);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("intValue", IntValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sensorId", SensorId);
            writer.WriteEnumValue<WorkplaceSensorType>("sensorType", SensorType);
            writer.WriteDateTimeOffsetValue("timestamp", Timestamp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
