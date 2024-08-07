// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.ResourceNamespaces;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentApprovals;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentSchedules;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignments;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilitySchedules;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.TransitiveRoleAssignments;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.RoleManagement.EntitlementManagement
{
    /// <summary>
    /// Provides operations to manage the entitlementManagement property of the microsoft.graph.roleManagement entity.
    /// </summary>
    public class EntitlementManagementRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the resourceNamespaces property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.ResourceNamespaces.ResourceNamespacesRequestBuilder ResourceNamespaces
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.ResourceNamespaces.ResourceNamespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentApprovals property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentApprovals.RoleAssignmentApprovalsRequestBuilder RoleAssignmentApprovals
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentApprovals.RoleAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignments.RoleAssignmentsRequestBuilder RoleAssignments
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignments.RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleInstances.RoleAssignmentScheduleInstancesRequestBuilder RoleAssignmentScheduleInstances
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleInstances.RoleAssignmentScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleRequests.RoleAssignmentScheduleRequestsRequestBuilder RoleAssignmentScheduleRequests
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleRequests.RoleAssignmentScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentSchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentSchedules.RoleAssignmentSchedulesRequestBuilder RoleAssignmentSchedules
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentSchedules.RoleAssignmentSchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinitions property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.RoleDefinitionsRequestBuilder RoleDefinitions
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.RoleEligibilityScheduleInstancesRequestBuilder RoleEligibilityScheduleInstances
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.RoleEligibilityScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder RoleEligibilityScheduleRequests
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilitySchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilitySchedules.RoleEligibilitySchedulesRequestBuilder RoleEligibilitySchedules
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilitySchedules.RoleEligibilitySchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the roleScheduleInstances method.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the roleSchedules method.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveRoleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.TransitiveRoleAssignments.TransitiveRoleAssignmentsRequestBuilder TransitiveRoleAssignments
        {
            get => new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.TransitiveRoleAssignments.TransitiveRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntitlementManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/entitlementManagement{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntitlementManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/entitlementManagement{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for roleManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The RbacApplication for Entitlement Management
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.RbacApplication"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.RbacApplication?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.RbacApplication> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.RbacApplication>(requestInfo, Microsoft.Graph.Beta.Models.RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in roleManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.RbacApplication"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.RbacApplication?> PatchAsync(Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.RbacApplication> PatchAsync(Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.RbacApplication>(requestInfo, Microsoft.Graph.Beta.Models.RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The RbacApplication for Entitlement Management
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EntitlementManagementRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The RbacApplication for Entitlement Management
        /// </summary>
        public class EntitlementManagementRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EntitlementManagementRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EntitlementManagementRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
