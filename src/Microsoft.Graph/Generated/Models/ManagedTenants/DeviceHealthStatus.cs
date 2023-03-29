using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class DeviceHealthStatus : Entity, IParsable {
        /// <summary>The blueScreenCount property</summary>
        public int? BlueScreenCount {
            get { return BackingStore?.Get<int?>("blueScreenCount"); }
            set { BackingStore?.Set("blueScreenCount", value); }
        }
        /// <summary>The bootTotalDurationInSeconds property</summary>
        public double? BootTotalDurationInSeconds {
            get { return BackingStore?.Get<double?>("bootTotalDurationInSeconds"); }
            set { BackingStore?.Set("bootTotalDurationInSeconds", value); }
        }
        /// <summary>The deviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The deviceMake property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceMake {
            get { return BackingStore?.Get<string?>("deviceMake"); }
            set { BackingStore?.Set("deviceMake", value); }
        }
#nullable restore
#else
        public string DeviceMake {
            get { return BackingStore?.Get<string>("deviceMake"); }
            set { BackingStore?.Set("deviceMake", value); }
        }
#endif
        /// <summary>The deviceModel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel {
            get { return BackingStore?.Get<string?>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#nullable restore
#else
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#endif
        /// <summary>The deviceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The healthStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HealthStatus {
            get { return BackingStore?.Get<string?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
#nullable restore
#else
        public string HealthStatus {
            get { return BackingStore?.Get<string>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
#endif
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The osVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>The primaryDiskType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryDiskType {
            get { return BackingStore?.Get<string?>("primaryDiskType"); }
            set { BackingStore?.Set("primaryDiskType", value); }
        }
#nullable restore
#else
        public string PrimaryDiskType {
            get { return BackingStore?.Get<string>("primaryDiskType"); }
            set { BackingStore?.Set("primaryDiskType", value); }
        }
#endif
        /// <summary>The restartCount property</summary>
        public int? RestartCount {
            get { return BackingStore?.Get<int?>("restartCount"); }
            set { BackingStore?.Set("restartCount", value); }
        }
        /// <summary>The startupPerformanceScore property</summary>
        public double? StartupPerformanceScore {
            get { return BackingStore?.Get<double?>("startupPerformanceScore"); }
            set { BackingStore?.Set("startupPerformanceScore", value); }
        }
        /// <summary>The tenantDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The topProcesses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TopProcesses {
            get { return BackingStore?.Get<string?>("topProcesses"); }
            set { BackingStore?.Set("topProcesses", value); }
        }
#nullable restore
#else
        public string TopProcesses {
            get { return BackingStore?.Get<string>("topProcesses"); }
            set { BackingStore?.Set("topProcesses", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"blueScreenCount", n => { BlueScreenCount = n.GetIntValue(); } },
                {"bootTotalDurationInSeconds", n => { BootTotalDurationInSeconds = n.GetDoubleValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceMake", n => { DeviceMake = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"primaryDiskType", n => { PrimaryDiskType = n.GetStringValue(); } },
                {"restartCount", n => { RestartCount = n.GetIntValue(); } },
                {"startupPerformanceScore", n => { StartupPerformanceScore = n.GetDoubleValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"topProcesses", n => { TopProcesses = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("blueScreenCount", BlueScreenCount);
            writer.WriteDoubleValue("bootTotalDurationInSeconds", BootTotalDurationInSeconds);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceMake", DeviceMake);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("healthStatus", HealthStatus);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("primaryDiskType", PrimaryDiskType);
            writer.WriteIntValue("restartCount", RestartCount);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topProcesses", TopProcesses);
        }
    }
}
