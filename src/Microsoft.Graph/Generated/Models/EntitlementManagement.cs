using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EntitlementManagement : Entity, IParsable {
        /// <summary>The accessPackageAssignmentApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Approval>? AccessPackageAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>?>("accessPackageAssignmentApprovals"); }
            set { BackingStore?.Set("accessPackageAssignmentApprovals", value); }
        }
#nullable restore
#else
        public List<Approval> AccessPackageAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>("accessPackageAssignmentApprovals"); }
            set { BackingStore?.Set("accessPackageAssignmentApprovals", value); }
        }
#endif
        /// <summary>Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentPolicy>? AccessPackageAssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>?>("accessPackageAssignmentPolicies"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicies", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>("accessPackageAssignmentPolicies"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicies", value); }
        }
#endif
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentRequest>? AccessPackageAssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>?>("accessPackageAssignmentRequests"); }
            set { BackingStore?.Set("accessPackageAssignmentRequests", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>>("accessPackageAssignmentRequests"); }
            set { BackingStore?.Set("accessPackageAssignmentRequests", value); }
        }
#endif
        /// <summary>Represents the resource-specific role which a subject has been assigned through an access package assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentResourceRole>? AccessPackageAssignmentResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageAssignmentResourceRole>?>("accessPackageAssignmentResourceRoles"); }
            set { BackingStore?.Set("accessPackageAssignmentResourceRoles", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageAssignmentResourceRole>>("accessPackageAssignmentResourceRoles"); }
            set { BackingStore?.Set("accessPackageAssignmentResourceRoles", value); }
        }
#endif
        /// <summary>The assignment of an access package to a subject for a period of time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignment>? AccessPackageAssignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>?>("accessPackageAssignments"); }
            set { BackingStore?.Set("accessPackageAssignments", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignment> AccessPackageAssignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>>("accessPackageAssignments"); }
            set { BackingStore?.Set("accessPackageAssignments", value); }
        }
#endif
        /// <summary>A container of access packages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageCatalog>? AccessPackageCatalogs {
            get { return BackingStore?.Get<List<AccessPackageCatalog>?>("accessPackageCatalogs"); }
            set { BackingStore?.Set("accessPackageCatalogs", value); }
        }
#nullable restore
#else
        public List<AccessPackageCatalog> AccessPackageCatalogs {
            get { return BackingStore?.Get<List<AccessPackageCatalog>>("accessPackageCatalogs"); }
            set { BackingStore?.Set("accessPackageCatalogs", value); }
        }
#endif
        /// <summary>A reference to the geolocation environment in which a resource is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceEnvironment>? AccessPackageResourceEnvironments {
            get { return BackingStore?.Get<List<AccessPackageResourceEnvironment>?>("accessPackageResourceEnvironments"); }
            set { BackingStore?.Set("accessPackageResourceEnvironments", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceEnvironment> AccessPackageResourceEnvironments {
            get { return BackingStore?.Get<List<AccessPackageResourceEnvironment>>("accessPackageResourceEnvironments"); }
            set { BackingStore?.Set("accessPackageResourceEnvironments", value); }
        }
#endif
        /// <summary>Represents a request to add or remove a resource to or from a catalog respectively.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceRequest>? AccessPackageResourceRequests {
            get { return BackingStore?.Get<List<AccessPackageResourceRequest>?>("accessPackageResourceRequests"); }
            set { BackingStore?.Set("accessPackageResourceRequests", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceRequest> AccessPackageResourceRequests {
            get { return BackingStore?.Get<List<AccessPackageResourceRequest>>("accessPackageResourceRequests"); }
            set { BackingStore?.Set("accessPackageResourceRequests", value); }
        }
#endif
        /// <summary>A reference to both a scope within a resource, and a role in that resource for that scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceRoleScope>? AccessPackageResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>?>("accessPackageResourceRoleScopes"); }
            set { BackingStore?.Set("accessPackageResourceRoleScopes", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>>("accessPackageResourceRoleScopes"); }
            set { BackingStore?.Set("accessPackageResourceRoleScopes", value); }
        }
#endif
        /// <summary>A reference to a resource associated with an access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResource>? AccessPackageResources {
            get { return BackingStore?.Get<List<AccessPackageResource>?>("accessPackageResources"); }
            set { BackingStore?.Set("accessPackageResources", value); }
        }
#nullable restore
#else
        public List<AccessPackageResource> AccessPackageResources {
            get { return BackingStore?.Get<List<AccessPackageResource>>("accessPackageResources"); }
            set { BackingStore?.Set("accessPackageResources", value); }
        }
#endif
        /// <summary>Represents access package objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackage>? AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>?>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#nullable restore
#else
        public List<AccessPackage> AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#endif
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConnectedOrganization>? ConnectedOrganizations {
            get { return BackingStore?.Get<List<ConnectedOrganization>?>("connectedOrganizations"); }
            set { BackingStore?.Set("connectedOrganizations", value); }
        }
#nullable restore
#else
        public List<ConnectedOrganization> ConnectedOrganizations {
            get { return BackingStore?.Get<List<ConnectedOrganization>>("connectedOrganizations"); }
            set { BackingStore?.Set("connectedOrganizations", value); }
        }
#endif
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EntitlementManagementSettings? Settings {
            get { return BackingStore?.Get<EntitlementManagementSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public EntitlementManagementSettings Settings {
            get { return BackingStore?.Get<EntitlementManagementSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Represents the subjects within entitlement management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageSubject>? Subjects {
            get { return BackingStore?.Get<List<AccessPackageSubject>?>("subjects"); }
            set { BackingStore?.Set("subjects", value); }
        }
#nullable restore
#else
        public List<AccessPackageSubject> Subjects {
            get { return BackingStore?.Get<List<AccessPackageSubject>>("subjects"); }
            set { BackingStore?.Set("subjects", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignmentApprovals", n => { AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageAssignmentPolicies", n => { AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageAssignmentRequests", n => { AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageAssignmentResourceRoles", n => { AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>(AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageAssignments", n => { AccessPackageAssignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageCatalogs", n => { AccessPackageCatalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResourceEnvironments", n => { AccessPackageResourceEnvironments = n.GetCollectionOfObjectValues<AccessPackageResourceEnvironment>(AccessPackageResourceEnvironment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResourceRequests", n => { AccessPackageResourceRequests = n.GetCollectionOfObjectValues<AccessPackageResourceRequest>(AccessPackageResourceRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResourceRoleScopes", n => { AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>(AccessPackageResourceRoleScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"connectedOrganizations", n => { ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>(ConnectedOrganization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EntitlementManagementSettings>(EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
                {"subjects", n => { Subjects = n.GetCollectionOfObjectValues<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicies", AccessPackageAssignmentPolicies);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("accessPackageAssignments", AccessPackageAssignments);
            writer.WriteCollectionOfObjectValues<AccessPackageCatalog>("accessPackageCatalogs", AccessPackageCatalogs);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceEnvironment>("accessPackageResourceEnvironments", AccessPackageResourceEnvironments);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRequest>("accessPackageResourceRequests", AccessPackageResourceRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRoleScope>("accessPackageResourceRoleScopes", AccessPackageResourceRoleScopes);
            writer.WriteCollectionOfObjectValues<AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<AccessPackageSubject>("subjects", Subjects);
        }
    }
}
