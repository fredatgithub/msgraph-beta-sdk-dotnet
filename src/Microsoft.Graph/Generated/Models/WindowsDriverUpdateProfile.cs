using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows Driver Update Profile</summary>
    public class WindowsDriverUpdateProfile : Entity, IParsable {
        /// <summary>An enum type to represent approval type of a driver update profile.</summary>
        public DriverUpdateProfileApprovalType? ApprovalType {
            get { return BackingStore?.Get<DriverUpdateProfileApprovalType?>("approvalType"); }
            set { BackingStore?.Set("approvalType", value); }
        }
        /// <summary>The list of group assignments of the profile.</summary>
        public List<WindowsDriverUpdateProfileAssignment> Assignments {
            get { return BackingStore?.Get<List<WindowsDriverUpdateProfileAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The date time that the profile was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Deployment deferral settings in days, only applicable when ApprovalType is set to automatic approval.</summary>
        public int? DeploymentDeferralInDays {
            get { return BackingStore?.Get<int?>("deploymentDeferralInDays"); }
            set { BackingStore?.Set("deploymentDeferralInDays", value); }
        }
        /// <summary>The description of the profile which is specified by the user.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Number of devices reporting for this profile</summary>
        public int? DeviceReporting {
            get { return BackingStore?.Get<int?>("deviceReporting"); }
            set { BackingStore?.Set("deviceReporting", value); }
        }
        /// <summary>The display name for the profile.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Driver inventories for this profile.</summary>
        public List<WindowsDriverUpdateInventory> DriverInventories {
            get { return BackingStore?.Get<List<WindowsDriverUpdateInventory>>("driverInventories"); }
            set { BackingStore?.Set("driverInventories", value); }
        }
        /// <summary>Driver inventory sync status for this profile.</summary>
        public WindowsDriverUpdateProfileInventorySyncStatus InventorySyncStatus {
            get { return BackingStore?.Get<WindowsDriverUpdateProfileInventorySyncStatus>("inventorySyncStatus"); }
            set { BackingStore?.Set("inventorySyncStatus", value); }
        }
        /// <summary>The date time that the profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Number of new driver updates available for this profile.</summary>
        public int? NewUpdates {
            get { return BackingStore?.Get<int?>("newUpdates"); }
            set { BackingStore?.Set("newUpdates", value); }
        }
        /// <summary>List of Scope Tags for this Driver Update entity.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>
        /// Instantiates a new windowsDriverUpdateProfile and sets the default values.
        /// </summary>
        public WindowsDriverUpdateProfile() : base() {
            OdataType = "#microsoft.graph.windowsDriverUpdateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDriverUpdateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDriverUpdateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"approvalType", n => { ApprovalType = n.GetEnumValue<DriverUpdateProfileApprovalType>(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<WindowsDriverUpdateProfileAssignment>(WindowsDriverUpdateProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentDeferralInDays", n => { DeploymentDeferralInDays = n.GetIntValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceReporting", n => { DeviceReporting = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"driverInventories", n => { DriverInventories = n.GetCollectionOfObjectValues<WindowsDriverUpdateInventory>(WindowsDriverUpdateInventory.CreateFromDiscriminatorValue).ToList(); } },
                {"inventorySyncStatus", n => { InventorySyncStatus = n.GetObjectValue<WindowsDriverUpdateProfileInventorySyncStatus>(WindowsDriverUpdateProfileInventorySyncStatus.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"newUpdates", n => { NewUpdates = n.GetIntValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DriverUpdateProfileApprovalType>("approvalType", ApprovalType);
            writer.WriteCollectionOfObjectValues<WindowsDriverUpdateProfileAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("deploymentDeferralInDays", DeploymentDeferralInDays);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("deviceReporting", DeviceReporting);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<WindowsDriverUpdateInventory>("driverInventories", DriverInventories);
            writer.WriteObjectValue<WindowsDriverUpdateProfileInventorySyncStatus>("inventorySyncStatus", InventorySyncStatus);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("newUpdates", NewUpdates);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
