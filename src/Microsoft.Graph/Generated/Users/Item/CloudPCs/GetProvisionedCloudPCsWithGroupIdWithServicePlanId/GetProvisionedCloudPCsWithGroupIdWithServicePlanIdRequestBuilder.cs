// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.CloudPCs.GetProvisionedCloudPCsWithGroupIdWithServicePlanId
{
    /// <summary>
    /// Provides operations to call the getProvisionedCloudPCs method.
    /// </summary>
    public class GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="groupId">Usage: groupId=&apos;{groupId}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="servicePlanId">Usage: servicePlanId=&apos;{servicePlanId}&apos;</param>
        public GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string groupId = "", string servicePlanId = "") : base(requestAdapter, "{+baseurl}/users/{user%2Did}/cloudPCs/getProvisionedCloudPCs(groupId='{groupId}',servicePlanId='{servicePlanId}'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(groupId)) PathParameters.Add("groupId", groupId);
            if (!string.IsNullOrWhiteSpace(servicePlanId)) PathParameters.Add("servicePlanId", servicePlanId);
        }
        /// <summary>
        /// Instantiates a new <see cref="GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/cloudPCs/getProvisionedCloudPCs(groupId='{groupId}',servicePlanId='{servicePlanId}'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get all provisioned Cloud PCs of a specific service plan for users under a Microsoft Entra user group.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-getprovisionedcloudpcs?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="GetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponse?> GetAsGetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponseAsync(Action<RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponse> GetAsGetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponseAsync(Action<RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponse>(requestInfo, GetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all provisioned Cloud PCs of a specific service plan for users under a Microsoft Entra user group.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-getprovisionedcloudpcs?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="GetProvisionedCloudPCsWithGroupIdWithServicePlanIdResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetProvisionedCloudPCsWithGroupIdWithServicePlanIdGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdResponse?> GetAsync(Action<RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdResponse> GetAsync(Action<RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdResponse>(requestInfo, GetProvisionedCloudPCsWithGroupIdWithServicePlanIdResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all provisioned Cloud PCs of a specific service plan for users under a Microsoft Entra user group.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder WithUrl(string rawUrl)
        {
            return new GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all provisioned Cloud PCs of a specific service plan for users under a Microsoft Entra user group.
        /// </summary>
        public class GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetRequestConfiguration : RequestConfiguration<GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilderGetQueryParameters>
        {
        }
    }
}
